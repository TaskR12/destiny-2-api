using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemSocketCategoryDefinition
    {
        public long SocketCategoryHash { get; set; }
        public IEnumerable<int> SocketIndexes { get; set; }
    }
}
