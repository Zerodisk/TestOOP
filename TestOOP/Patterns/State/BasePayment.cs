using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class BasePayment
    {
        Booking booking;

        public BasePayment(Booking booking)
        {
            this.booking = booking;
        }

        public void ActualInitial()
        {
            Console.WriteLine("Init the booking");
            this.booking.Status = "NEW";
        }

        public void ActualPreAuthorisation()
        {
            Console.WriteLine("do Pre-Auth for amount of $" + booking.TotalAmount.ToString());
            this.booking.Status = "PREAUTH";
        }

        public void ActualMakePayment()
        {
            Console.WriteLine("do Payment for amount of $" + booking.TotalAmount.ToString() );
            this.booking.Status = "PAID";

        }

        public void ActualFinallisaBooking()
        {
            Console.WriteLine("do finallise the booking for name: " + booking.FirstName + " " + booking.LastName );
            this.booking.Status = "DONE";
        }

    }
}
