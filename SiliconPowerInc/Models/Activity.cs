using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiliconPowerInc.Models
{
    public class Activity
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string Price { get; set; }
        public string Image_url { get; set; }
    }
}