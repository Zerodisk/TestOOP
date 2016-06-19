using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class MakeBookingState : BasePayment, IState
    {
        ISupplier supplier;
        ProcessBooking bookingProc;

        public MakeBookingState(ProcessBooking bookingProc) : base(bookingProc.Booking)
        {
            this.bookingProc = bookingProc;
            SupplierFactory factory = new SupplierFactory();
            supplier = factory.GetSupplier(bookingProc.Booking);
        }

        public override string ToString()
        {
            return "MakeBookingState";
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
            ActualMakePayment();
            bookingProc.CurrentState = bookingProc.getMakePaymentState();
            bookingProc.Booking.State = bookingProc.CurrentState;
        }

        public void FinalliseBooking()
        {
            Console.WriteLine("error");
        }
    }
}
