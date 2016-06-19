using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class FinalliseBookingState : BasePayment, IState
    {
        ISupplier supplier;
        ProcessBooking bookingProc;

        public FinalliseBookingState(ProcessBooking bookingProc) : base(bookingProc.Booking)
        {
            this.bookingProc = bookingProc;
            SupplierFactory factory = new SupplierFactory();
            supplier = factory.GetSupplier(bookingProc.Booking);
        }


        public override string ToString()
        {
            return "FinalliseBookingState";
        }

        public void Initial()
        {
            Console.WriteLine("error");
        }

        public void PreAuthorisation()
        {
            Console.WriteLine("error");
        }

        public void MakeBooking()
        {
            Console.WriteLine("error");
        }

        public void MakePayment()
        {
            Console.WriteLine("error");
        }

        public void FinalliseBooking()
        {
            Console.WriteLine("Done");
        }
    }
}
