using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public interface IState
    {
        void Initial();
        void PreAuthorisation();
        void MakeBooking();
        void MakePayment();
        void FinalliseBooking();
    }
}
