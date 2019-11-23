using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using YC.FacebookMessenger.Json;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GenericTemplatePayload
    {
        [JsonConverter(typeof(EnumConverter), false)]
        public TemplatePayloadType TemplateType { get; set; } = TemplatePayloadType.Generic;

        public IEnumerable<GenericTemplateElement> Elements { get; set; }
    }
}
