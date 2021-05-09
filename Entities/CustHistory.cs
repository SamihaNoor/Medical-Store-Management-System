using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class CustHistory
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int SaleId { set; get; }
        public int Contact { set; get; }
        public string MedName { set; get; }
        public int Quantity { set; get; }
    }
}
