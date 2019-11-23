using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TemplateButton
    {
        [JsonConverter(typeof(EnumConverter))]
        public ButtonType Type { get; set; }
        public string Title { get; set; }
        public string Payload { get; set; }
        public Uri Url { get; set; }
    }
}
