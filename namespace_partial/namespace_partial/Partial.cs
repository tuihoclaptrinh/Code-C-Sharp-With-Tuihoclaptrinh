using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sp
{
    public partial class Partial
    {
        public string name { get; set; }
        public decimal price { get; set; }

        public string GetInfo()
        {
            return $"{name} / {price} / {description}";
        }
    }
}
