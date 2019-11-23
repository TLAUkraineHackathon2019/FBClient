using System.Collections.Generic;
using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;

namespace YC.FacebookMessenger.Models.Response
{
    [JsonObject(NamingStrategyType = typeof(SnakeCaseNamingStrategy))]
    public class QuickRepliesRequest: BaseRequest
    {
        public IEnumerable<QuickReply> QuickReplies { get; set; }
    }
}
