using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestAutomationBL.Responses
{
    public class CreatedBookingResponseDTO
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public int totalprice { get; set; }
        public bool depositpaid { get; set; }
        public BookingdatesResp bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }

    public partial class BookingdatesResp
    {
        public string checkin { get; set; }
        public string checkout { get; set; }
    }

    public class Root
    {
        public int bookingid { get; set; }
        public CreatedBookingResponseDTO booking { get; set; }
    }
}
