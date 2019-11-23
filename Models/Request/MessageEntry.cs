namespace YC.FacebookMessenger.Models.Request
{
    public class MessageEntry
    {
        public ChatParticipant Recipient { get; set; }
        public ChatParticipant Sender { get; set; }
        public ulong? Timestamp { get; set; }
        public MessageContent Message { get; set; }
        public Referral Referral { get; set; }
        public Postback Postback { get; set; }
    }
}
