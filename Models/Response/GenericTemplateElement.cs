using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;
using System.Collections.Generic;
using System.Linq;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class GenericTemplateElement
    {
        public string Title { get; set; }
        public string Subtitle { get; set; }
        public Uri ImageUrl { get; set; }

        public IEnumerable<TemplateButton> Buttons { get; set; }
    }
}
