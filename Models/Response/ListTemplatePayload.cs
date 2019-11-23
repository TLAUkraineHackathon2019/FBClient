using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class ListTemplatePayload
    {
        [JsonConverter(typeof(EnumConverter), false)]
        public TemplatePayloadType TemplateType { get; set; } = TemplatePayloadType.List;

        [JsonConverter(typeof(EnumConverter), false)]
        public ListElementStyle TopElementStyle { get; set; }

        public IEnumerable<GenericTemplateElement> Elements { get; set; }
    }
}
