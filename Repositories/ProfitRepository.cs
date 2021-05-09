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
    public class ProfitRepository:IRepositories<Profit>, IDisposable
    {
        Profit prof;
        DataAccess dataAccess;

        public ProfitRepository()
        {
            dataAccess = new DataAccess();
        }

        public int Insert(Profit prof)
        {
            string sql = "Insert into Profits (SaleId,MedId,Date,Income) values (" + prof.SaleId + "," + prof.MedId + ",'" + prof.Date.ToString() + "'," + prof.Income + ")";
            return dataAccess.ExecuteQuery(sql) ;
        }

        public List<Profit> Show(string d1,string d2)
        {
            List<Profit> profits = new List<Profit>();
            try
            {
                string sql = "Select Date, sum(Income) Income from Profits where Date between '" + d1 + "' and '" + d2 + "' group by Date";
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    prof = new Profit();

                    prof.Date = Convert.ToDateTime(reader["Date"]);
                    prof.Income = Convert.ToInt32(reader["Income"]);

                    profits.Add(prof);
                }
            }
            catch (Exception ex) { }
            return profits;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public List<Profit> GetAll()
        {
            throw new NotImplementedException();
        }

        public int Update(Profit entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
