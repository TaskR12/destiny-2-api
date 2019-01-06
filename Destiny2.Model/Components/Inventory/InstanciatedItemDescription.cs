using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Inventory
{

    public enum EEquipFailureReason
    {
        None = 0,
        ItemUnequippable = 1,
        ItemUniqueEquipRestricted = 2,
        ItemFailedUnlockCheck = 4,
        ItemFailedLevelCheck = 8,
        ItemNotOnCharacter = 16,
    }


    public class InstanciatedItemDescription
    {
        public EDamageType DamageType { get; set; }

        public long DamageTypeHash { get; set; }    

        public StatDescription PrimaryStat { get; set; }

        public int ItemLevel { get; set; }

        public int Quality { get; set; }

        public bool IsEquipped { get; set; }

        public bool CanEquip { get; set; }

        public int EquipRequiredLevel { get; set; }

        public IEnumerable<long> UnlockHashesRequiredToEquip { get; set; }

        public EEquipFailureReason CannotEquipReason { get; set; }
    }
}
