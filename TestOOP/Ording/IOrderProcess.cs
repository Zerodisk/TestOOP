using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Ording
{
    public interface IOrderProcess
    {
        //set as initial to know what type of supplier
        string SupplierType { get; }

        void PreAuthorisation(Order order);
        void ReserveOrderItem(Order order);
        void MakePayment();
        void FinalliseOrder();

        //this is the facade of all above 4 step
        void MakeOrder(Order order);
    }
}
