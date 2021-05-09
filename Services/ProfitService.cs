using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class ProfitService
    {
        ProfitRepository profRep;

        public ProfitService()
        {
            profRep = new ProfitRepository();
        }
        public int Insert(Profit prof)
        {
            return profRep.Insert(prof);
        }
        public List<Profit> Show(string d1,string d2)
        {
            return profRep.Show(d1,d2);
        }
    }
}
