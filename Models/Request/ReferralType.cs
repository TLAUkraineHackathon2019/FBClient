using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YC.FacebookMessenger.Models.Request
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferralType
    {
        OPEN_THREAD = 0
    }
}