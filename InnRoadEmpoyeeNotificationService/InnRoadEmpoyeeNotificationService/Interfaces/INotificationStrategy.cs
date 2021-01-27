using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    interface INotificationStrategy
    {
         
        void NotifyViaSingleService(List<Employee> employeeList, NotificationType notificationType);
        void NotifyViaAllServices(List<Employee> employeeList);
    }
}
