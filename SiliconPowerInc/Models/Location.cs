using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiliconPowerInc.Models
{
    public class Location
    {
        public int Id { get; set; }
        public int Id_Activity { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string CP { get; set; }
        public string Country { get; set; }
        public decimal Latitude { get; set; }
        public decimal Longitude { get; set; }
    }
}