using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    public class NotificationDomain
    {
        private List<NotificationType> _favourableTypeOfNotifications;
        public Employee EmployeeToBeNotified { get; set; }

        public NotificationDomain()
        {
            _favourableTypeOfNotifications = new List<NotificationType>();
        }

        public List<NotificationType> GetFavourableTypeOfNotofications()
        {
            return _favourableTypeOfNotifications;
        }

        public void AddFavourableNotificationType(NotificationType notificationType)
        {
            _favourableTypeOfNotifications.Add(notificationType);
        }

        




    }
}
