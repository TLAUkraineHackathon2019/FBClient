using System;
using System.Collections.Generic;
using System.Text;

namespace YC.FacebookMessenger.Models.Request
{
    public class Postback
    {
        public string Payload { get; set; }
        public string Title { get; set; }
    }
}
