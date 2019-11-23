using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class Attachment<TPayload>
    {
        [JsonConverter(typeof(EnumConverter))]
        public AttachmentType Type { get; set; } = AttachmentType.Template;

        public TPayload Payload { get; set; }
    }
}
