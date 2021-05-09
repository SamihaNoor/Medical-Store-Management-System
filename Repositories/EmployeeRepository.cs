using Entities;
using Interfaces;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repositories
{
    public class EmployeeRepository:IRepositories<Employee>, IDisposable
    {
        DataAccess dataAccess;

        public EmployeeRepository()
        {
            dataAccess = new DataAccess();
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Employee> GetAll()
        {
            
            List<Employee> employees = new List<Employee>();
            try
            {
                string sql = "SELECT * FROM Employees";
                SqlDataReader reader = dataAccess.GetData(sql);
                
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpId = Convert.ToInt32(reader["EmpId"]);
                    emp.EmpName = reader["EmpName"].ToString();
                    emp.Designation = reader["Designation"].ToString();
                    emp.Contact = Convert.ToInt32(reader["Contact"]);
                    emp.Salary = Convert.ToInt32(reader["Salary"]);
                    employees.Add(emp);
                }
            }
            catch (Exception ex) { }

            return employees;
        }
        public List<Employee> GetAll(string keyword)
        {
            List<Employee> employees = new List<Employee>();
            
            try
            {
                string sql = "Select * from Employees where EmpName like '%" + keyword + "%'";
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    Employee emp = new Employee();
                    emp.EmpId = Convert.ToInt32(reader["EmpId"]);
                    emp.EmpName = reader["EmpName"].ToString();
                    emp.Designation = reader["Designation"].ToString();
                    emp.Contact = Convert.ToInt32(reader["Contact"]);
                    emp.Salary = Convert.ToInt32(reader["Salary"]);
                    employees.Add(emp);
                }
            }
            catch (Exception ex) { }

            return employees;
        }

        public int Insert(Employee entity)
        {
            int id = 0;
            try
            {
                string sql = "Insert into Employees (EmpName,Designation,Contact,Salary) Values ('" + entity.EmpName + "','" + entity.Designation + "'," + entity.Contact + "," + entity.Salary + ")";
                int result = dataAccess.ExecuteQuery(sql);

                if (result > 0)
                {
                    dataAccess = new DataAccess();
                    sql = "Select * From Employees where Contact=" + entity.Contact + "";
                    SqlDataReader reader = dataAccess.GetData(sql);
                    reader.Read();
                    id = Convert.ToInt32(reader["EmpId"]);
                }
            }
            catch (Exception ex) { }
            return id;
        }

        public int Update(Employee entity)
        {
             string sql = "Update Employees set EmpName='" + entity.EmpName + "',Designation='" + entity.Designation + "',Contact=" + entity.Contact + ",Salary=" + entity.Salary + " where EmpId=" + entity.EmpId + "";
             return dataAccess.ExecuteQuery(sql);
            
           
        }

        public int Delete(int id)
        {
            string sql = "Delete from Employees where EmpId="+id+"";
            return dataAccess.ExecuteQuery(sql);
        }
    }
}
