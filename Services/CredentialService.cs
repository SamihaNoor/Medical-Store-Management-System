using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class CredentialService
    {
        CredentialRepository credRepo;

        public CredentialService()
        {
            credRepo = new CredentialRepository() ;
        }

        public Credential GetUser(int id, string password)
        {
            return credRepo.Verification(id, password);
        }
        public int ChangePassword(Credential user)
        {
            return credRepo.ChangePassword(user);
        }
        public int InsertUser(Credential u)
        {
            return credRepo.Insert(u);  
        }
        public int DeleteUser(int id)
        {
            return credRepo.Delete(id);
        }

    }
}
