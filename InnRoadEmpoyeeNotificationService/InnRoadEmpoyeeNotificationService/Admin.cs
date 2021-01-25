using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class Admin : Employee
    {
        private NotificationService _notificationService;
        private List<NotificationDomain> _listOfNotificationDomain;
        public Admin()
        {
            _notificationService = new NotificationService();
        }

        public void NotifyAllEmployeesViaGmail(List<Employee> employeeList)
        {
            _listOfNotificationDomain = new List<NotificationDomain>();
            foreach(var employee in employeeList)
            {
                 NotificationDomain notificationDomain = new NotificationDomain();
                 notificationDomain.AddFavourableNotificationType(NotificationType.Gmail);
                 notificationDomain.EmployeeToBeNotified = employee;
                _listOfNotificationDomain.Add(notificationDomain);

            }

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);

            }

        }



        public void NotifyAllEmployeesViaOutlook(List<Employee> employeeList)
        {
            _listOfNotificationDomain = new List<NotificationDomain>();
            foreach (var employee in employeeList)
            {
                NotificationDomain notificationDomain = new NotificationDomain();
                notificationDomain.AddFavourableNotificationType(NotificationType.Outlook);
                notificationDomain.EmployeeToBeNotified = employee;
                _listOfNotificationDomain.Add(notificationDomain);

            }

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);

            }


        }

        public void NotifyAllEmployeesViaMobile(List<Employee> employeeList)
        {

            _listOfNotificationDomain = new List<NotificationDomain>();
            foreach (var employee in employeeList)
            {
                NotificationDomain notificationDomain = new NotificationDomain();
                notificationDomain.AddFavourableNotificationType(NotificationType.Mobile);
                notificationDomain.EmployeeToBeNotified = employee;
                _listOfNotificationDomain.Add(notificationDomain);

            }

            foreach (var notificationDomain in _listOfNotificationDomain)
            {
                _notificationService.Notify(notificationDomain);

            }




        }

        public void NotifyAllEmployeesViaAllServices()
        {

        }

        public void NotifyOneDepartmentViaGmail()
        {

        }

        public void NotifyOneDepartmentViaOutlook()
        {

        }

        public void NotifyOneDepartmentViaMobile()
        {

        }

        public void NotifyOneDepartmentViaAllServices()
        {

        }


        public OperationType ShowAvailableOptions()
        {

            Console.WriteLine( "1.Notify all employees through GMAIL." );
            Console.WriteLine("2.Notify all employees through OUTLOOK.");
            Console.WriteLine("3.Notify all employees through MOBILE.");
           Console.WriteLine("4.Notify all employees through GMAIL && OUTLOOK && MOBILE");
            Console.WriteLine("5.Notify employees of Department 'X' through GMAIL.");
            Console.WriteLine("6.Notify employees of Department 'X' through OUTLOOK.");
            Console.WriteLine("7.Notify employees of Department 'X' through MOBILE.");
            Console.WriteLine("8.Notify employees of Department 'X' through GMAIL && OUTLOOK && MOBILE.");

            int choice = Convert.ToInt32(Console.ReadLine());

            return (OperationType)choice - 1;

        }


    }
}
