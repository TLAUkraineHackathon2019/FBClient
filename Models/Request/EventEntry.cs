using System.Collections.Generic;

namespace YC.FacebookMessenger.Models.Request
{
    public class EventEntry
    {
        public string Id { get; set; }
        public ulong Time { get; set; }

        public IEnumerable<MessageEntry> Messaging { get; set; }
    }
}
