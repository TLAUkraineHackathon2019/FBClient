using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class MenuInfo
    {
        public string Locale { get; set; } = "default";
        public bool ComposerInputDisabled { get; set; }
        public IEnumerable<MenuButton> CallToActions { get; set; }
    }
}
