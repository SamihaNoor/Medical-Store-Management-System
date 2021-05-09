using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Employee
    {
        private int empId, contact, salary;
        private string empName, designation;

        public int EmpId
        {
            set { this.empId = value; }
            get { return this.empId; }
        }
        public string EmpName
        {
            set { this.empName = value; }
            get { return this.empName; }
        }
        public string Designation
        {
            set { this.designation = value; }
            get { return this.designation; }
        }
        public int Contact
        {
            set { this.contact = value; }
            get { return this.contact; }
        }
        public int Salary
        {
            set { this.salary = value; }
            get { return this.salary; }
        }
    }
}
