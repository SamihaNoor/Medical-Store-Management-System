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
    public class CredentialRepository:IRepositories<Credential> , IDisposable
    {
        DataAccess dataAccess;
        
        public CredentialRepository()
        {
            dataAccess = new DataAccess();
        }
        public Credential Verification(int id, string password)
        {
            Credential user = null;
            
            try
            {
                string sql = "Select * from Credentials where UserId=" + id + " AND Password='" + password + "'";
                SqlDataReader reader = dataAccess.GetData(sql);
                while (reader.Read())
                {
                    user = new Credential();
                    user.Id = Convert.ToInt32(reader["Id"]);
                    user.UserId = Convert.ToInt32(reader["UserId"]);
                    user.Password = reader["Password"].ToString();
                    user.Type = Convert.ToInt32(reader["Type"]);
                }
            }
            catch (Exception ex) { }
            return user;
               
        }

    
        public List<Credential> GetAll()
        {
 	        throw new NotImplementedException();
        }

        public int Insert(Credential entity)
        {
            string sql = "Insert into Credentials (UserId,Password,Type) Values (" + entity.UserId + ",'" + entity.Password + "'," + entity.Type + ")";

            return dataAccess.ExecuteQuery(sql);
        }

        public int Update(Credential entity)
        {
 	        throw new NotImplementedException();
        }

        public int ChangePassword(Credential user)
        {
            string sql = "Update Credentials set Password='"+user.Password+"' where UserId="+user.UserId+"";
            return dataAccess.ExecuteQuery(sql);
        }

        public int Delete(int id)
        {
            string sql = "Delete from Credentials where UserId=" + id + "";
            return dataAccess.ExecuteQuery(sql);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }
    }
}
