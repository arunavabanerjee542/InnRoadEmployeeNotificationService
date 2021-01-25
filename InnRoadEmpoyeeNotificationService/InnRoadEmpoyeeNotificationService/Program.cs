using InnRoadEmpoyeeNotificationService.Enumerations;
using System;

namespace InnRoadEmpoyeeNotificationService
{
    class Program
    {
        static void Main(string[] args)
        {
            Admin admin = new Admin();
            bool isAlwaysTrue = true;
            var listOfEmployees = Employee.GetEmployees();


            while(isAlwaysTrue)
            {
              OperationType operationType =  admin.ShowAvailableOptions();

                switch(operationType)
                {
                    case OperationType.SendAllViaGmail:
                        admin.NotifyAllEmployeesViaGmail(listOfEmployees);
                        break;

                    case OperationType.SendAllViaOutlook:
                        admin.NotifyAllEmployeesViaOutlook(listOfEmployees);
                        break;

                    case OperationType.SendAllViaMobile:
                        admin.NotifyAllEmployeesViaMobile(listOfEmployees);
                        break;

                    case OperationType.SendAllViaAllServices:
                        break;

                    case OperationType.SendOneDepartmentViaGmail:
                        break;

                    case OperationType.SendOneDepartmentViaOutlook:
                        break;

                    case OperationType.SendOneDepartmentViaMobile:
                        break;

                    case OperationType.SendOneDepartmentViaAllServices:
                        break;


                }


            }




            
        }
    }
}
