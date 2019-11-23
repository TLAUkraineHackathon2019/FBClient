using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class TextMessage : BaseMessage
    {
        public string Text { get; set; }
        public IEnumerable<QuickReply> QuickReplies { get; set; } 
    }
}
