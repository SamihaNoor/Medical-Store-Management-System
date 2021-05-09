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
    public class MedicineRepository:IRepositories<Medicine> , IDisposable
    {
        DataAccess dataAccess;
        public MedicineRepository() 
        {
            dataAccess = new DataAccess();
        }
        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public Medicine GetMed(int id)
        {
            Medicine med = null;

            try
            {
                string sql = "Select * from Medicines where MedId=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    med = new Medicine();
                    med.MedId = Convert.ToInt32(reader["MedId"]);
                    med.MedName = reader["MedName"].ToString();
                    med.Type = reader["Type"].ToString();
                    med.BuyingPrice = Convert.ToDouble(reader["BuyingPrice"]);
                    med.SellingPrice = Convert.ToDouble(reader["SellingPrice"]);
                    med.Quantity = Convert.ToInt32(reader["Quantity"]);
                }
            }
            catch (Exception ex) { }
            return med;
        }


        public List<Medicine> GetAll()
        {
            List<Medicine> medicines = new List<Medicine>();
            try
            {
                string sql = "SELECT * FROM Medicines";
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Medicine med = new Medicine();
                    med.MedId = Convert.ToInt32(reader["MedId"]);
                    med.MedName = reader["MedName"].ToString();
                    med.Type = reader["Type"].ToString();
                    med.BuyingPrice = Convert.ToDouble(reader["BuyingPrice"]);
                    med.SellingPrice = Convert.ToDouble(reader["SellingPrice"]);
                    med.Quantity = Convert.ToInt32(reader["Quantity"]);
                    medicines.Add(med);
                }
            }
            catch (Exception ex) { }
            return medicines;
        }
        public List<Medicine> GetAll(string keyword)
        {
            List<Medicine> medicines = new List<Medicine>();

            try
            {
                string sql = "SELECT * FROM Medicines where MedName like '%" + keyword + "%'";
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    Medicine med = new Medicine();
                    med.MedId = Convert.ToInt32(reader["MedId"]);
                    med.MedName = reader["MedName"].ToString();
                    med.Type = reader["Type"].ToString();
                    med.BuyingPrice = Convert.ToDouble(reader["BuyingPrice"]);
                    med.SellingPrice = Convert.ToDouble(reader["SellingPrice"]);
                    med.Quantity = Convert.ToInt32(reader["Quantity"]);
                    medicines.Add(med);
                }
            }
            catch (Exception ex) { }
            return medicines;
        }

        public int Insert(Medicine entity)
        {
            string sql = "Insert into Medicines(MedName,Type,BuyingPrice,SellingPrice,Quantity) values ('" + entity.MedName + "','" + entity.Type + "'," + entity.BuyingPrice + "," + entity.SellingPrice + "," + entity.Quantity + ")";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Medicine entity)
        {
            string sql = "Update Medicines set MedName='" + entity.MedName + "',Type='"+entity.Type+"',BuyingPrice="+entity.BuyingPrice+",SellingPrice="+entity.SellingPrice+",Quantity="+entity.Quantity+" where MedId="+entity.MedId+"";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Delete(int id)
        {
            string sql = "Delete from Medicines where MedId="+id;
            return dataAccess.ExecuteQuery(sql);
        }
        public double GetBuyingPrice(int id)
        {
            double price = -1;
            try
            {
                string sql = "Select BuyingPrice from Medicines where MedId=" + id;
                SqlDataReader reader = dataAccess.GetData(sql);

                while (reader.Read())
                {
                    price = Convert.ToDouble(reader["BuyingPrice"]);
                }
            }
            catch (Exception ex) { }
            return price;
        }
    }
}
