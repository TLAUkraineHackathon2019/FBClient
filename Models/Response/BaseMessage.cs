using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class BaseMessage
    {
        public string Metadata { get; set; }
    }
}
