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
    public class HistoryRepository:IRepositories<CustHistory>, IDisposable
    {
        DataAccess dataAccess;

        public HistoryRepository()
        {
            dataAccess = new DataAccess();
        }
        public List<CustHistory> GetAll()
        {
            string sql = "select * from CustomerHistories";
            SqlDataReader reader = dataAccess.GetData(sql);
            List<CustHistory> histories = new List<CustHistory>();
            while (reader.Read())
            {
                CustHistory his = new CustHistory();
                his.Id = Convert.ToInt32(reader["Id"]);
                his.Date = Convert.ToDateTime(reader["Date"]);
                his.Contact = Convert.ToInt32(reader["Contact"]);
                his.SaleId = Convert.ToInt32(reader["SaleId"]);
                his.MedName = reader["MedName"].ToString();
                his.Quantity = Convert.ToInt32(reader["Quantity"]);

                histories.Add(his);
            }
            return histories;
        }

        public List<CustHistory> GetAll(int keyword)
        {
            string sql = "Select * from CustomerHistories where Contact =" + keyword;
            SqlDataReader reader = dataAccess.GetData(sql);
            List<CustHistory> histories = new List<CustHistory>();
            while (reader.Read())
            {
                CustHistory his = new CustHistory();
                his.Id = Convert.ToInt32(reader["Id"]);
                his.Date = Convert.ToDateTime(reader["Date"]);
                his.Contact = Convert.ToInt32(reader["Contact"]);
                his.SaleId = Convert.ToInt32(reader["SaleId"]);
                his.MedName = reader["MedName"].ToString();
                his.Quantity = Convert.ToInt32(reader["Quantity"]);

                histories.Add(his);
            }
            return histories;
        }

        public int Insert(CustHistory his)
        {
            string sql = "Insert into CustomerHistories (Date,Contact,SaleId,MedName,Quantity) values ('" + his.Date + "'," + his.Contact + ","+his.SaleId+",'" + his.MedName + "',"+his.Quantity+")";
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }


        public int Update(CustHistory entity)
        {
            throw new NotImplementedException();
        }

        public int Delete(int id)
        {
            throw new NotImplementedException();
        }
    }
}
