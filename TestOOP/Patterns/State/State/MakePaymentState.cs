using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class MakePaymentState : BasePayment, IState
    {
        ISupplier supplier;
        ProcessBooking bookingProc;

        public MakePaymentState(ProcessBooking bookingProc) : base(bookingProc.Booking)
        {
            this.bookingProc = bookingProc;
            SupplierFactory factory = new SupplierFactory();
            supplier = factory.GetSupplier(bookingProc.Booking);
        }

        public override string ToString()
        {
            return "MakePaymentState";
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
            ActualFinallisaBooking();
            bookingProc.CurrentState = bookingProc.getFinalState();
            bookingProc.Booking.State = bookingProc.CurrentState;
        }
    }
}
