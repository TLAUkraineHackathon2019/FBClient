using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YC.FacebookMessenger.Models.Request
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum ReferralSource
    {
        MESSENGER_CODE = 0,
        DISCOVER_TAB,
        ADS,
        SHORTLINK,
        CUSTOMER_CHAT_PLUGIN
    }
}