using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ActionRequest : BaseRequest
    {
        [JsonConverter(typeof(EnumConverter), false)]
        public ChatActionType SenderAction { get; set; }
    }
}
