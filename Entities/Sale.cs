using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Sale
    {
        public int Id { set; get; }
        public DateTime Date { set; get; }
        public int SaleId { set; get; }
        public string MedName { set; get; }
        public int Quantity { set; get; }
    }
}
