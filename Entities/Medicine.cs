using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
    public class Medicine
    {
        private int medId, quantity;
        private string medName, type;
        private double buyingPrice, unitPrice;

        public int MedId { set; get; }

        public string MedName { set; get; }

        public string Type { set; get; }

        public double BuyingPrice { set; get; }

        public double SellingPrice { set; get; }

        public int Quantity { set; get; }
    }
}
