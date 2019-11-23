using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class QuickReply
    {
        public QuickReplyType ContentType { get; set; }
        public string Title { get; set; }
        public string Payload { get; set; }
        public string ImageUrl { get; set; }
    }
}
