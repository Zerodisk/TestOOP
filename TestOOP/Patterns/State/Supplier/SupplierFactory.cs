using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class SupplierFactory
    {
        public ISupplier GetSupplier(Booking booking)
        {
            if (booking.SupplierCode == "GTA")
            {
                return new SupplierGTA(booking);
            }
            else if (booking.SupplierCode == "ORB")
            {
                return new SupplierOrbitz(booking);
            }
            else
            {
                return null;
            }
        }
    }
}
