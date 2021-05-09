using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Profit
    {
        public int Id { set; get; }
        public int SaleId { set; get; }
        public int MedId { set; get; }
        public DateTime Date { set; get; }
        public double Income { set; get; }
    }
}
