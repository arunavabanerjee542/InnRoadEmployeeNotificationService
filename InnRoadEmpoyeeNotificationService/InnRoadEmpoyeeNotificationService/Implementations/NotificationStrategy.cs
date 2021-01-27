using System;
using System.Collections.Generic;
using System.Text;
using InnRoadEmpoyeeNotificationService.Enumerations;

namespace InnRoadEmpoyeeNotificationService
{
    public delegate void NotifyViaAllServices(List<Employee> empoloyeeList);

    public class NotificationStrategy : INotificationStrategy
    {
        private NotificationService _notificationService;
        public event NotifyViaAllServices NotificationEvent;

        public NotificationStrategy()
        {
            _notificationService = new NotificationService();
        }

        public void NotifyViaAllServices(List<Employee> employeeList)
        {
            NotificationEvent += NotifyAllEmployeesViaGmail;
            NotificationEvent += NotifyAllEmployeesViaOutlook;
            NotificationEvent += NotifyAllEmployeesViaMobile;

            NotificationEvent(employeeList);

        }

        public void NotifyViaSingleService(List<Employee> employeeList, NotificationType notificationType)
        {
            switch(notificationType)
            {
                case NotificationType.Gmail:
                    NotifyAllEmployeesViaGmail(employeeList);
                    break;

                case NotificationType.Outlook:
                    NotifyAllEmployeesViaOutlook(employeeList);
                    break;

                default:
                    NotifyAllEmployeesViaMobile(employeeList);
                    break;

            }
            
        }


        public void NotifyAllEmployeesViaGmail(List<Employee> employeeList)
        {
            List<NotificationDomain> _listOfNotificationDomain =
                PopulateNotificationDomain(employeeList, NotificationType.Gmail);

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);

            }

        }



        public void NotifyAllEmployeesViaOutlook(List<Employee> employeeList)
        {
            List<NotificationDomain> _listOfNotificationDomain =
            PopulateNotificationDomain(employeeList, NotificationType.Outlook);

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);
            }

        }


        public void NotifyAllEmployeesViaMobile(List<Employee> employeeList)
        {
            List<NotificationDomain> _listOfNotificationDomain =
                 PopulateNotificationDomain(employeeList, NotificationType.Mobile);

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);

            }

        }



        public List<NotificationDomain> PopulateNotificationDomain(List<Employee> employeeList, NotificationType notificationType)
        {
            List<NotificationDomain> _listOfNotificationDomain = new List<NotificationDomain>();
            foreach (var employee in employeeList)
            {
                NotificationDomain notificationDomain = new NotificationDomain();
                notificationDomain.AddFavourableNotificationType(notificationType);
                notificationDomain.EmployeeToBeNotified = employee;
                _listOfNotificationDomain.Add(notificationDomain);

            }
            return _listOfNotificationDomain;

        }











    }
}
