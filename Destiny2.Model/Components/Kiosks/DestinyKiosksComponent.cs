using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Kiosks
{
    public class DestinyKiosksComponent
    {
        public Dictionary<long,IEnumerable<long>> KioskItems { get; set; }
    }
}
