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
    public class SaleRepository:IRepositories<Sale>, IDisposable
    {
        DataAccess dataAccess;

        public SaleRepository()
        {
            dataAccess = new DataAccess();
        }
        public int Insert(Sale sal)
        {
            string sql = "Insert into Sales (Date,SaleId,MedName,Quantity) values ('" + sal.Date + "'," + sal.SaleId + ",'" + sal.MedName + "'," + sal.Quantity + ")";
            return dataAccess.ExecuteQuery(sql);
        }
        public List<Sale> GetChart(string d1, string d2)
        {
            List<Sale> sales = new List<Sale>();
            try
            {
                string sql = "select MedName,sum(Quantity) Quantity from Sales where Date between '" + d1 + "' and '" + d2 + "' group by MedName ";
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Sale sal = new Sale();
                    sal.MedName = reader["MedName"].ToString();
                    sal.Quantity = Convert.ToInt32(reader["Quantity"]);
                    sales.Add(sal);
                }
            }
            catch (Exception ex) { }
            return sales;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Sale> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Sale entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
