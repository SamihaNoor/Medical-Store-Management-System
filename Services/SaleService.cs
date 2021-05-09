using Entities;
using Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class SaleService
    {
        SaleRepository salRep;

        public SaleService()
        {
            salRep = new SaleRepository();
        }
        public int Insert(Sale sal)
        {
            return salRep.Insert(sal);
        }
        public List<Sale> GetChart(string d1, string d2)
        {
            return salRep.GetChart(d1, d2);
        }
    }
}
