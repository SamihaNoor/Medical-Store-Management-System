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
    public class PurchaseRepository : IRepositories<Purchase> , IDisposable
    {
        DataAccess dataAccess;
        public PurchaseRepository()
        {
            dataAccess = new DataAccess();

        }
       public int GetSaleId()
        {
            int id = -1;
            try
            {
                string sql = "Select Max(SaleId) SaleId from Purchases";
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    id = Convert.ToInt32(reader["SaleId"]);
                }
            }
            catch (Exception ex) { }
            return id+1;
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Purchase Check(int mid,int sid)
        {
            Purchase pur = null;
            try
            {
                string sql = "select * from Purchases where MedId=" + mid + " AND SaleId=" + sid;
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    pur = new Purchase();
                    pur.SaleId = Convert.ToInt32(reader["SaleId"]);
                    pur.MedId = Convert.ToInt32(reader["MedId"]);
                    pur.MedName = reader["MedName"].ToString();
                    pur.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    pur.Quantity = Convert.ToInt32(reader["Quantity"]);
                    pur.Amount = Convert.ToDouble(reader["Amount"]);
                }
            }
            catch (Exception ex) { }
            return pur;
        }


        public List<Purchase> GetAll()
        {
            throw new NotImplementedException();
        }


        public List<Purchase> GetAll(int id)
        {
            List<Purchase> purchases = new List<Purchase>();
            try
            {
                string sql = "Select * from Purchases where SaleId=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Purchase pur = new Purchase();

                    pur.SaleId = Convert.ToInt32(reader["SaleId"]);
                    pur.MedId = Convert.ToInt32(reader["MedId"]);
                    pur.MedName = reader["MedName"].ToString();
                    pur.UnitPrice = Convert.ToDouble(reader["UnitPrice"]);
                    pur.Quantity = Convert.ToInt32(reader["Quantity"]);
                    pur.Amount = Convert.ToDouble(reader["Amount"]);

                    purchases.Add(pur);
                }
            }
            catch (Exception ex) { }
            return purchases;
        }

        public int Insert(Purchase pur)
        {
            string sql = "Insert into Purchases (SaleId,MedId,MedName,UnitPrice,Quantity,Amount) values (" + pur.SaleId + "," + pur.MedId + ",'" + pur.MedName + "'," + pur.UnitPrice + "," + pur.Quantity + "," + pur.Amount + ")";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Purchase pur)
        {
            string sql = "Update Purchases set Quantity=" + pur.Quantity + ", Amount=" + pur.Amount + "where MedId=" + pur.MedId + "AND SaleId = " + pur.SaleId;
            return dataAccess.ExecuteQuery(sql);
        }

        public int DeleteMed(int mid,int sid)
        {
            string sql = "Delete from Purchases where MedId=" + mid + "And SaleId="+sid;
            return dataAccess.ExecuteQuery(sql);
        }

        public int Delete(int id)
        {
            string sql = "Delete from Purchases where SaleId=" + id;
            return dataAccess.ExecuteQuery(sql);
        }

        public double GetTotal(int id)
        {
            double total = -1;
            try
            {
                string sql = "select sum(Amount) Amount from Purchases where saleId=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    total = Convert.ToDouble(reader["Amount"]);
                }
            }
            catch (Exception ex) { }
            return total;
        }
    }
}
