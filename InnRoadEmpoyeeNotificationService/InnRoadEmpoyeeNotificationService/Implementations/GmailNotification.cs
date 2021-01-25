using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class GmailNotification : INotification
    {
        public void SendNotification(Message content)
        {
            Console.WriteLine("SENDING "+ content.MyMessage + " TO "  +content.To );
        }
    }
}
