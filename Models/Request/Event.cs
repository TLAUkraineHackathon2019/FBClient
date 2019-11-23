using System.Collections.Generic;

namespace YC.FacebookMessenger.Models.Request
{
    public class Event
    {
        public string Object { get; set; }
        public IEnumerable<EventEntry> Entry { get; set; }
    }
}
