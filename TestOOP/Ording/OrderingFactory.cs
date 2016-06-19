using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TestOOP.Ording.Supplier;

namespace TestOOP.Ording
{
    public class OrderingFactory
    {

        public IOrderProcess GetOrderSupplier(string supplierType)
        {
            switch(supplierType)
            {
                case "A":
                    return new SupplierOrderA();
                case "B":
                    return new SupplierOrderB();
                default:
                    return null;
            }
        }
    }
}
