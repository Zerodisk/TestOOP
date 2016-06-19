using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class SupplierOrbitz : ISupplier
    {
        private Booking booking;

        public SupplierOrbitz(Booking booking)
        {
            this.booking = booking;
        }

        public void MakeBooking()
        {
            Console.WriteLine("do Make booking via ORBITZ");
            this.booking.Status = "BOOKED";
        }
    }
}
