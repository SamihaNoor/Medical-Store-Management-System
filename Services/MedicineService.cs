using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class MedicineService
    {
        MedicineRepository medRepo;
        public MedicineService()
        {
            medRepo = new MedicineRepository();
        }
        public Medicine GetMed(int id)
        {
            return medRepo.GetMed(id);
        }
        public double GetBuyingPrice(int id)
        {
            return medRepo.GetBuyingPrice(id);
        }
        public int InsertMed(Medicine med)
        {
            return medRepo.Insert(med);
        }
        public int DeleteMed(int id)
        {
            return medRepo.Delete(id);
        }
        public List<Medicine> GetMeds()
        {
            return medRepo.GetAll();
        }
        public List<Medicine> GetMeds(string keyword)
        {
            return medRepo.GetAll(keyword);
        }
        public int UpdateMed(Medicine med)
        {
            return medRepo.Update(med);
        }
    }
}
