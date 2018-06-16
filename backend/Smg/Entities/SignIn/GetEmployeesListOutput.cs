using System.Collections.Generic;
using Newtonsoft.Json;

namespace Signature.Domain.Entities.SignIn
{
    public class GetEmployeesListOutput : BaseResponse
    {
        [JsonProperty("Profiles")]
        public IList<ShortProfileModel> Profiles { get; set; }
    }
}
