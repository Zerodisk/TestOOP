using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class InitialState : BasePayment, IState
    {
        ISupplier supplier;
        ProcessBooking bookingProc;

        public InitialState(ProcessBooking bookingProc) : base(bookingProc.Booking)
        {
            this.bookingProc = bookingProc;
            SupplierFactory factory = new SupplierFactory();
            supplier = factory.GetSupplier(bookingProc.Booking);
        }

        public override string ToString()
        {
            return "InitialState";
        }

        public void Initial()
        {
            ActualInitial();
            bookingProc.CurrentState = bookingProc.getInitialState();
            bookingProc.Booking.State = bookingProc.CurrentState;
        }

        public void PreAuthorisation()
        {
            ActualPreAuthorisation();
            bookingProc.CurrentState = bookingProc.getPreAuthorisationState();
            bookingProc.Booking.State = bookingProc.CurrentState;
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
            Console.WriteLine("error");
        }
    }
}
