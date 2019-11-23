using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ProfileSettings
    {
        public IEnumerable<MenuInfo> PersistentMenu { get; set; }
        public IEnumerable<GreetingText> Greeting { get; set; }

        public PayloadModel GetStarted { get; set; }
    }
}
