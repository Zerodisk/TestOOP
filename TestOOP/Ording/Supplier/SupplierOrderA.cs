using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Ording.Supplier
{
    public class SupplierOrderA : AbstractOrder
    {
        public override string SupplierType
        {
            get { return "A";}
        }

        public override void ReserveOrderItem(Order order)
        {
            Console.WriteLine("2." + SupplierType + " reserve order items - done - order by: " + order.FirstName);
        }

        public override void FinalliseOrder()
        {
            Console.WriteLine("4." + SupplierType + " finallise order - done");
        }
    }
}
