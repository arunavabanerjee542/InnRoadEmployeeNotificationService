using InnRoadEmpoyeeNotificationService.Enumerations;
using System;
using System.Collections.Generic;
using System.Text;

namespace InnRoadEmpoyeeNotificationService
{
    class Employee
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public DepartmentType Department { get; set; }
        public string GmailId{ get; set; }
        public string OutlookId { get; set; }
        public long MobileNo { get; set; }


        public Employee(string name, int id, DepartmentType department, string gmailId, string outlookId,long mobileNo)
        {
            Name = name;
            Id = id;
            Department = department;
            GmailId = gmailId;
            OutlookId = outlookId;
            MobileNo = mobileNo;

        }

        public Employee()
        {

        }


        public static List<Employee> GetEmployees()
        {
            List<Employee> empList = new List<Employee>()
            {

                new Employee("RAM",1,DepartmentType.Hr,"akdn@aa.a","akscbj@lk.w",9547744030),
                new Employee("RAVI",1,DepartmentType.QualityAssurance,"akdn@aa.a","akscbj@lk.w",9547744030),
                new Employee("RAMA",1,DepartmentType.SoftwareDevelopement,"akdn@aa.a","akscbj@lk.w",9547744030)

            };

            return empList;


        }








    }
}
