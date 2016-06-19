using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestOOP.Patterns.State
{
    public class Booking
    {
        public int BookingId { get; set; }
        public decimal TotalAmount { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string SupplierCode { get; set; }
        public IState State { get; set; }        //which state object are we at
        public string Status { get; set; }
    }
}
