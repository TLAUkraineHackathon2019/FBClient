using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace YC.FacebookMessenger.Models
{
    [JsonConverter(typeof(StringEnumConverter))]
    public enum QuickReplyType
    {
        Text = 0,
        UserPhoneNumber,
        UserEmail
    }
}
