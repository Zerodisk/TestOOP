using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class ProcessBooking
    {
        IState preAuthorisationState;
        IState makeBookingState;
        IState makePaymentState;
        IState finalState;
        IState initState;

        IState stateCurrent;
        Booking booking;
        
        
        public ProcessBooking(Booking booking)
        {
            this.booking = booking;

            preAuthorisationState = new PreAuthorisationState(this);
            makeBookingState = new MakeBookingState(this);
            makePaymentState = new MakePaymentState(this);
            finalState = new FinalliseBookingState(this);
            initState = new InitialState(this);

            stateCurrent = initState;
        }

        public Booking Booking
        {
            get { return booking; }
        }

        public void Initial()
        {
            stateCurrent.Initial();
        }

        public void PreAuthorisation()
        {
            stateCurrent.PreAuthorisation();
        }

        public void MakeBooking()
        {
            stateCurrent.MakeBooking();
        }

        public void MakePayment()
        {
            stateCurrent.MakePayment();
        }

        public void FinaliseBooking()
        {
            stateCurrent.FinalliseBooking();
        }

        public IState CurrentState
        {
            get { return stateCurrent; }
            set { stateCurrent = value; }
        }

        public IState getInitialState()
        {
            return initState;
        }
        public IState getPreAuthorisationState()
        {
            return preAuthorisationState;
        }
        public IState getMakeBookingState()
        {
            return makeBookingState;
        }
        public IState getMakePaymentState()
        {
            return makePaymentState;
        }
        public IState getFinalState()
        {
            return finalState;
        }

    }
}
