using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sp
{
    public partial class Partial
    {
        public Manufactory Mafactory { get; set; }

        public class Manufactory { 
            public string name { get; set; }
            public string address { get; set; }
        }

        public string description { get; set; }
    }
}
