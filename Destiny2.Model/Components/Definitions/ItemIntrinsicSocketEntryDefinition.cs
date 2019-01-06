using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemIntrinsicSocketEntryDefinition
    {
        public long PlugItemHash { get; set; }
        public long SocketTypeHash { get; set; }
        public bool DefaultVisible { get; set; }
    }
}
