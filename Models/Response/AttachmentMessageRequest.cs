using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AttachmentMessageRequest<TPayload> : BaseRequest
    {
        public AttachmentMessage<TPayload> Message { get; set; }
    }
}
