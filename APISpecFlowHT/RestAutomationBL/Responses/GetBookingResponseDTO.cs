using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace APISpecFlowHT.DTO
{
    public class GetBookingResponseDTO
    {
        public string firstname { get; set; }
        public string lastname { get; set; }
        public long totalprice { get; set; }
        public bool depositpaid { get; set; }
        public GetBookingBookingdates bookingdates { get; set; }
        public string additionalneeds { get; set; }
    }

    public partial class GetBookingBookingdates
    {
        public DateTimeOffset checkin { get; set; }
        public DateTimeOffset checkout { get; set; }
    }

}

