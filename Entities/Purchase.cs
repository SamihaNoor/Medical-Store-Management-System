using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Purchase
    {
        private int saleId, medId, quantity;
        string medName;
        double unitPrice, amount;

        public int SaleId { set; get; }
        public int MedId { set; get; }
        public string MedName { set; get; }
        public double UnitPrice { set; get; }
        public int Quantity { set; get; }
        public double Amount { set; get; }
    }
}
