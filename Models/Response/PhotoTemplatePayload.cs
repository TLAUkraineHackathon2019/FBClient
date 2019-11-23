using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AttachmentTemplatePayload
    {
        public bool IsReusable { get; set; } = true;
        public string Url { get; set; }
    }
}