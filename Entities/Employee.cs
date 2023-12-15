using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CourierManagement.Entities
{
    internal class Employee
    {
        private long employeeID;
        private string employeeName;
        private string email;
        private long contactNumber;
        private string role;
        private double salary;

        public Employee() { }

        public Employee(long employeeID, string employeeName, string email, long contactNumber, string role, double salary)
        {
            this.employeeID = employeeID;
            this.employeeName = employeeName;
            this.email = email;
            this.contactNumber = contactNumber;
            this.role = role;
            this.salary = salary;
        }

        public long EmployeeID { get => employeeID; set => employeeID = value; }
        public string EmployeeName { get => employeeName; set => employeeName = value; }
        public string Email { get => email; set => email = value; }
        public long ContactNumber { get => contactNumber; set => contactNumber = value; }
        public string Role { get => role; set => role = value; }
        public double Salary { get => salary; set => salary = value; }

        public override string ToString()
        {
            return $"Employee{{employeeID={employeeID}, employeeName='{employeeName}', email='{email}', contactNumber={contactNumber}, role='{role}', salary={salary}}}";
        }
    }
}
