using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class AttachmentPayload
    {
        public bool IsReusable { get; set; } = true;
        public string Url { get; set; }
    }
}