using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json.Serialization;
using YC.FacebookMessenger.Models.Response;

namespace YC.FacebookMessenger.Models.Request
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class MessageContent
    {
        [JsonProperty("mid")]
        public string MessageId { get; set; }

        [JsonProperty("seq")]
        public int Sequence { get; set; }

        public string Text { get; set; }
        public QuickReply QuickReply { get; set; }
    }
}
