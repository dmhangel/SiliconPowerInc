using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiliconPowerInc.Models
{
    public class Booking
    {
        public int Id { get; set; }
        public int Id_User { get; set; }
        public int Id_Activity { get; set; }
        public DateTime Booking_date{ get; set; }
        public DateTime Start_date { get; set; }
        public DateTime End_date{ get; set; }
        public int Seats { get; set; }
    }
}