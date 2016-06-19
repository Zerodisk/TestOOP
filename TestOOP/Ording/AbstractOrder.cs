using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Ording
{
    public abstract class AbstractOrder : IOrderProcess
    {
        public abstract string SupplierType { get; }

        public void MakeOrder(Order order)
        {
            PreAuthorisation(order);
            ReserveOrderItem(order);
            MakePayment();
            FinalliseOrder();
        }

        public void PreAuthorisation(Order order)
        {
            Console.WriteLine("1. Pre-Authorisation - done - order from " + order.FirstName);
        }

        public abstract void ReserveOrderItem(Order order);

        public void MakePayment()
        {
            Console.WriteLine("3. Making payment - done");
        }

        public abstract void FinalliseOrder();

        
    }
}
