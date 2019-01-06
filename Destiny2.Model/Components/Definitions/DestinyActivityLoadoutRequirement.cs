using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions    
{
    public class DestinyActivityLoadoutRequirement
    {
        public long EquipmentSlotHash { get; set; }
        public IEnumerable<long> AllowedEquippedItemHashes { get; set; }
        public IEnumerable<EDestinyItemSubType> AllowedWeaponSubTypes { get; set; }
    }
}
