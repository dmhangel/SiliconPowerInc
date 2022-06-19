using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using SiliconPowerInc.Models;

namespace SiliconPowerInc.Models
{
    public class Activity_Full
    {
        public Activity AF_Activity { get; set; }
        public Comment[] AF_comments { get; set; }
        public Booking[] AF_Bookigns { get; set; }
        public Image[] AF_Images { get; set; } 
        public Location AF_Location { get; set; }

    }
}