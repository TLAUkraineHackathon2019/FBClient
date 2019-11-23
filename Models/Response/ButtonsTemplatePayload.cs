using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ButtonsTemplatePayload
    {
        [JsonConverter(typeof(EnumConverter), false)]
        public TemplatePayloadType TemplateType { get; set; } = TemplatePayloadType.Button;

        public string Text { get; set; }

        public IEnumerable<TemplateButton> Buttons { get; set; }
    }
}
