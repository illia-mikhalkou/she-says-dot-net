using Newtonsoft.Json;

namespace Signature.Domain.Entities.SignIn
{
    /// <summary>
    /// 
    /// </summary>
    /// <seealso cref="Signature.Domain.Entities.BaseResponse" />
    public class AuthenticateOutput : BaseResponse
    {
        /// <summary>
        /// Gets or sets the session identifier.
        /// </summary>
        /// <value>
        /// The session identifier.
        /// </value>
        [JsonProperty("SessionId")]
        public int SessionId { get; set; }
    }
}
