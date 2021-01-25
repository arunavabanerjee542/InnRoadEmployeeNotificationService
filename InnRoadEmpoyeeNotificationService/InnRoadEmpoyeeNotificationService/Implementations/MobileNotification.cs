using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class MobileNotification : INotification
    {
         public void SendNotification(Message content)
         {
            Console.WriteLine("SENDING " + content.MyMessage + " TO " + content.To);
        }
     }
    
}
