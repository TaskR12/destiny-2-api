using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Inventory;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Items
{
    public class DestinyItemInstanceComponent
    {
        public EDamageType DamageType { get; set; }
        public long DamageTypeHash { get; set; }
        public DestinyStat PrimaryStat { get; set; }
        public int ItemLevel { get; set; }
        public int Quality { get; set; }
        public bool IsEquipped { get; set; }
        public bool CanEquip { get; set; }
        public int EquipRequiredLevel { get; set; }
        public IEnumerable<long> UnlockHashesRequiredToEquip { get; set; }
        public EEquipFailureReason CannotEquipFailureReason { get; set; }
    }
}
