using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SiliconPowerInc.Models
{
    public class BD_GenericDataStorageDM
    {
        public List<Tuple<string, int>> Integers { get; set; }
        public List<Tuple<string, string>> Strings { get; set; }
        public List<Tuple<string, DateTime>> DateTimes { get; set; }
        public List<Tuple<string, decimal>> Decimals { get; set; }
    }
}