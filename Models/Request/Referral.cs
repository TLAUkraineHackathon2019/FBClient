using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Request
{
    public class Referral
    {
        [JsonProperty("ref")]
        public string Data { get; set; }
        [JsonProperty("source")]
        public ReferralSource Source { get; set; }
        [JsonProperty("type")]
        public ReferralType Type { get; set; }
    }
}