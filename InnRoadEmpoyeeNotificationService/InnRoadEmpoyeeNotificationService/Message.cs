namespace InnRoadEmpoyeeNotificationService
{
    public class Message
    {
        public string To { get; set; }
        public string MyMessage { get; set; }

        public Message(string to,string myMessage)
        {
            To = to;
            MyMessage = myMessage;
        }

    }
}