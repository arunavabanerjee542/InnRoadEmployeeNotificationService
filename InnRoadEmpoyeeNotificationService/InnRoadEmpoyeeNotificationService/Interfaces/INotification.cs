using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    interface INotification
    {
        void SendNotification(Message content);
           

    }
}
