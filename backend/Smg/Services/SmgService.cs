using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Authentication;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;

using Signature.Domain.Entities.SignIn;

namespace Signature.Domain.Services
{
    public class SmgService
    {
        #region Constants

        private const string SmgEndpoint = "https://smg.itechart-group.com/MobileServiceNew/MobileService.svc/";
        private const string UsernameRequestParameter = "username";
        private const string PasswordRequestParameter = "password";
        private const string SessionIdRequestParameter = "sessionId";
        private const string ProfileIdRequestParameter = "profileId";
        private const string AuthenticateAction = "Authenticate?";
        private const string GetAllEmployeesAction = "GetAllEmployees?";
        private const string GetEmployeeDetailsAction = "GetEmployeeDetails?";

        #endregion

        #region Private Fields

        private readonly HttpClient _httpClient;
        private int _sessionId;

        #endregion

        #region Constructors

        public SmgService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(SmgEndpoint);
            _httpClient.DefaultRequestHeaders.Accept.Clear();
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        #endregion

        #region Implementation of ISmgService interface

        /// <summary>
        /// Gets the profile data.
        /// </summary>
        /// <param name="username">The username.</param>
        /// <param name="password">The password.</param>
        /// <returns></returns>
        public async Task<ProfileDetails> GetProfileDataAsync(string username, string password)
        {
            this._sessionId = (await Authenticate(username, password)).SessionId;
            var employees = await GetAllEmployees(_sessionId);

            var result = await ShortSearch(username, employees.Profiles);

            if (result == null)
            {
                result = await LongSearch(username, employees.Profiles);
            }

            return result;
        }

        #endregion

        #region Private Methods

        public async Task<AuthenticateOutput> Authenticate(string username, string password)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query[UsernameRequestParameter] = username;
            query[PasswordRequestParameter] = password;

            var response = await _httpClient.GetAsync(AuthenticateAction + query.ToString());
            response.EnsureSuccessStatusCode();

            var result = JsonConvert.DeserializeObject<AuthenticateOutput>(await response.Content.ReadAsStringAsync());

            if (!string.IsNullOrEmpty(result.ErrorCode))
            {
                throw new InvalidCredentialException("The username or password is incorrect.");
            }

            return result;
        }

        public async Task<GetEmployeesListOutput> GetAllEmployees(int sessionId)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query[SessionIdRequestParameter] = sessionId.ToString();

            var response = await _httpClient.GetAsync(GetAllEmployeesAction + query);
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<GetEmployeesListOutput>(await response.Content.ReadAsStringAsync());
        }

        private async Task<ProfileDetails> ShortSearch(string username, IList<ShortProfileModel> profiles)
        {
            string[] words = username.Split('.');
            string firstName = words[0].ToUpperInvariant();
            string lastName = words[1].ToUpperInvariant();

            int? profileId = profiles.FirstOrDefault(profile => profile.LastNameEng.ToUpperInvariant() == lastName && profile.FirstNameEng.ToUpperInvariant() == firstName)?.ProfileId;

            if (profileId == null)
            {
                return null;
            }

            var model = await GetEmployeeDetailsById(_sessionId, (int)profileId);

            if (model.Profile.DomenName.Equals(username))
            {
                return model.Profile;
            }
            else
            {
                return null;
            }
        }

        private async Task<ProfileDetails> LongSearch(string username, IList<ShortProfileModel> profiles)
        {
            foreach (var profile in profiles)
            {
                var model = await GetEmployeeDetailsById(_sessionId, profile.ProfileId);

                if (model.Profile.DomenName.ToUpperInvariant() == username.ToUpperInvariant())
                {
                    return model.Profile;
                }
            }

            return null;
        }

        public async Task<GetProfileDetailsOutput> GetEmployeeDetailsById(int sessionId, int profileId)
        {
            var query = HttpUtility.ParseQueryString(string.Empty);
            query[SessionIdRequestParameter] = sessionId.ToString();
            query[ProfileIdRequestParameter] = profileId.ToString();

            var response = await _httpClient.GetAsync(GetEmployeeDetailsAction + query.ToString());
            response.EnsureSuccessStatusCode();

            return JsonConvert.DeserializeObject<GetProfileDetailsOutput>(await response.Content.ReadAsStringAsync());
        }

        #endregion
    }
}
