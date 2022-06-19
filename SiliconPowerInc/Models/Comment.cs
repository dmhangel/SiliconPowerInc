using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiliconPowerInc.Models
{
    public class Comment
    {
        public int Id { get; set; }
        public int Id_Activity { get; set; }
        public DateTime Date { get; set; }
        public string Comment_Text { get; set; }
        public int Rating { get; set; }
    }
}