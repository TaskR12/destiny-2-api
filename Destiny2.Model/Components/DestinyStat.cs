using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public class DestinyStat
    {
        public long StatHash { get; set; }
        public int Value { get; set; }
        public int MaximumValue { get; set; }
    }
}
