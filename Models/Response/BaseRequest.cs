using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BaseRequest
    {
        [JsonConverter(typeof(EnumConverter))]
        public MessagingType? MessagingType { get; set; }

        public ChatParticipant Recipient { get; set; }

        [JsonConverter(typeof(EnumConverter))]
        public NotificationType? NotificationType { get; set; }

        public string Tag { get; set; }
    }
}
