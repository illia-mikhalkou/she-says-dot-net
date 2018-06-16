using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Signature.Domain.Entities
{
    /// <summary>
    /// 
    /// </summary>
    public class BaseResponse
    {
        /// <summary>
        /// Gets or sets the extension data.
        /// </summary>
        /// <value>
        /// The extension data.
        /// </value>
        [JsonProperty("ExtensionData")]
        public ExtensionDataObject ExtensionData { get; set; }

        /// <summary>
        /// Gets or sets the error code.
        /// </summary>
        /// <value>
        /// The error code.
        /// </value>
        [JsonProperty("ErrorCode")]
        public string ErrorCode { get; set; }

        /// <summary>
        /// Gets or sets the permission.
        /// </summary>
        /// <value>
        /// The permission.
        /// </value>
        [JsonProperty("Permission")]
        public string Permission { get; set; }
    }
}
