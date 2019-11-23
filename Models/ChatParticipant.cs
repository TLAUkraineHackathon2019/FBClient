using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ChatParticipant
    {
        public string Id { get; set; }
    }
}
