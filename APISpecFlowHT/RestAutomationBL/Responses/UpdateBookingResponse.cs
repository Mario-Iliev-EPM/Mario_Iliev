using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAutomationBL.Responses
{
    public class UpdateBookingResponse
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public long Totalprice { get; set; }
        public bool Depositpaid { get; set; }
        public BookingdatesResp Bookingdates { get; set; }
        public string Additionalneeds { get; set; }
    }

    public partial class BookingdatesResp
    {
        public DateTimeOffset Checkin { get; set; }
        public DateTimeOffset Checkout { get; set; }
    }
}
