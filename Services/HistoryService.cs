using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class HistoryService
    {
        HistoryRepository hisRepo;

        public HistoryService()
        {
            hisRepo = new HistoryRepository();
        }
        public List<CustHistory> GetAll()
        {
            return hisRepo.GetAll();
        }
        public List<CustHistory> GetAll(int keyword)
        {
            return hisRepo.GetAll(keyword);
        }
        public int Insert(CustHistory his)
        {
            return hisRepo.Insert(his);
        }
    }
}
