using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class SupplierGTA : ISupplier
    {
        private Booking booking;

        public SupplierGTA(Booking booking)
        {
            this.booking = booking;
        }

        public void MakeBooking()
        {
            Console.WriteLine("do Make booking via GTA" );
            this.booking.Status = "BOOKED";
        }
    }
}
