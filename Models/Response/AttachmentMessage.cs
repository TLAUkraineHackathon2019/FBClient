using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AttachmentMessage<TPayload>
    {
       public Attachment<TPayload> Attachment { get; set; }
    }
}
