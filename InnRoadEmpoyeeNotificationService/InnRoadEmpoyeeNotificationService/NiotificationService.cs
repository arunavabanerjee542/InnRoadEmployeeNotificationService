using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class NotificationService
    {
        INotification notificationObject;
        Message message;


    public void Notify(NotificationDomain notificationDomain)
      {

            foreach(var notificationType in notificationDomain.GetFavourableTypeOfNotofications())
            {
                switch(notificationType)
                {
                        case NotificationType.Gmail:
                        notificationObject = new GmailNotification();
                           message = new Message(notificationDomain.EmployeeToBeNotified.Name,
                            "SENDING VIA GMAIL");              
                        break;

                        case NotificationType.Outlook:
                        notificationObject = new OutlookNotification();
                        message = new Message(notificationDomain.EmployeeToBeNotified.Name,
                         "SENDING VIA OUTLOOK");
                        break;

                        default:
                        notificationObject = new MobileNotification();
                        message = new Message(notificationDomain.EmployeeToBeNotified.Name,
                         "SENDING VIA MOBILE");
                        break;

                }

                notificationObject.SendNotification(message);


            }



      }






    }
}
