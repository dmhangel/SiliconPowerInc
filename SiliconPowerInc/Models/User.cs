using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace SiliconPowerInc.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Mail { get; set; }
        public string Pswrd { get; set; }
        public string Name { get; set; }
        public string SurName { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
        public string Town { get; set; }
        public string CP { get; set; }
        public string Country { get; set; }
    }
}