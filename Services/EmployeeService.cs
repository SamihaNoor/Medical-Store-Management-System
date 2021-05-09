using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class EmployeeService
    {
        EmployeeRepository empRepo;

        public EmployeeService()
        {
            empRepo = new EmployeeRepository();
        }
        public int InsertEmp(Employee emp)
        {
            return empRepo.Insert(emp);
        }
        public List<Employee> GetEmps()
        {
            return empRepo.GetAll();
        }
        public List<Employee> GetEmps(string keyword)
        {
            return empRepo.GetAll(keyword);
        }
        public int UpdateEmp(Employee emp)
        {
            return empRepo.Update(emp);
        }
        public int DeleteEmp(int id)
        {
            return empRepo.Delete(id);
        }
    }
}
