using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class Admin : Employee
    {
        private INotificationStrategy _notificationStrategy;
        public Admin()
        {
            _notificationStrategy = new NotificationStrategy();
        }
            
        public void NotifyAllEmployeesViaGmail(List<Employee> employeeList)
        {
            _notificationStrategy.NotifyViaSingleService(employeeList, NotificationType.Gmail);
        
        }

        public void NotifyAllEmployeesViaOutlook(List<Employee> employeeList)
        {
            _notificationStrategy.NotifyViaSingleService(employeeList, NotificationType.Outlook);           
        }

        public void NotifyAllEmployeesViaMobile(List<Employee> employeeList)
        {
            _notificationStrategy.NotifyViaSingleService(employeeList, NotificationType.Mobile);         
        }

        public void NotifyAllEmployeesViaAllServices(List<Employee> employeeList)
        {
            _notificationStrategy.NotifyViaAllServices(employeeList);         
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

            Console.WriteLine("1.Notify all employees through GMAIL.");
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
