using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class MenuButton
    {
        public string Title { get; set; }

        [JsonConverter(typeof(EnumConverter))]
        public ButtonType Type { get; set; }

        public string Payload { get; set; }

        public IEnumerable<MenuButton> CallToActions { get; set; }
    }
}
