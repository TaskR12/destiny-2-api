using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Inventory
{
    public class InstanciatedItemComponent
    {
        public long CharacterId { get; set; }

        public ResponseOfComponent<InstanciatedItemDescription> Instance { get; set; }
    }
}
