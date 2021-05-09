using Repositories;
using Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PurchaseService
    {
        PurchaseRepository pursRepo;
        public PurchaseService()
        {
            pursRepo = new PurchaseRepository();
        }
        public List<Purchase> GetAll(int id)
        {
            return pursRepo.GetAll(id);
        }
        public int AddToCart(Purchase pur)
        {
            return pursRepo.Insert(pur);
        }
        public int DeleteMed(int id,int sid)
        {
            return pursRepo.DeleteMed(id,sid);
        }
        public int DeleteFromCart(int id)
        {
            return pursRepo.Delete(id);
        }
        public int GetSaleId()
        {
            return pursRepo.GetSaleId();
        }

        public double GetTotal(int id)
        {
            return pursRepo.GetTotal(id);
        }
        public Purchase Check(int mid,int sid)
        {
           return pursRepo.Check(mid,sid);
        }
        public int UpdateCart(Purchase pur)
        {
            return pursRepo.Update(pur);
        }
    }
}
