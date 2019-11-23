using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GreetingText
    {
        public string Locale { get; set; } = "default";
        public string Text { get; set; }
    }
}
