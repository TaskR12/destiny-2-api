using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Characters;
using Destiny2.Api.Model.Definitions.Common;
using Destiny2.Api.Model.Inventory;
using Destiny2.Api.Model.Misc;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    

    public enum EDestinyItemSubType
    {
        None = 0,
        AutoRifle = 6, 
        Shotgun = 7,
        Machinegun = 8,
        HandCannon = 9,
        RocketLauncher = 10,
        FusionRifle = 11, 
        SniperRifle = 12,
        PulseRifle = 13,
        ScoutRifle = 14,
        Sidearm = 17,
        Sword = 18,
        Mask = 19,
        Shader = 20,
        Ornament = 21, 
        FusionRifleLine = 22,
        GrenadeLauncher = 23,
        SubmachineGun = 24, 
        TraceRifle = 25, 
        HelmetArmor = 26, 
        GauntletsArmor = 27, 
        ChestArmor = 28, 
        LegArmor = 29,
        ClassArmor = 30,
        Bow = 31,
    }

    public class DestinyInventoryItemDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }

        public long CollectibleHash { get; set; }

        public string SecondaryIcon { get; set; }
        public string SecondaryOverlay { get; set; }
        public string SecondarySpecial { get; set; }
        public Color BackgroundColor { get; set; }
        public string Screenshot { get; set; }
        public string ItemTypeDisplayName { get; set; }
        public string UiItemDisplayStyle { get; set; }
        public string ItemTypeAndTierDisplayName { get; set; }
        public string DisplaySource { get; set; }
        public string TooltipStyle { get; set; }
        public ItemActionBlockDefinition Action { get; set; }
        public ItemInventoryBlockDefinition Inventory { get; set; }
        public ItemSetBlockDefinition SetData { get; set; }
        public ItemStatBlockDefinition Stats { get; set; }
        public long? emblemObjectiveHash { get; set; }
        public EquippingBlockDefinition EquippingBlock { get; set; }
        // Translationblock skipped
        // Preview skipped
        public ItemQualityBlockDefinition Quality { get; set; }
        public ItemValueBlockDefinition Value { get; set; }
        // SourceData skipped
        // Objectives skipped
        // Plug skipped
        //Gearset skipped
        // Sack skipped
        public ItemSocketBlockDefinition Sockets { get; set; }
        // summary skipped
        // talentGrid skipped
        // investmentStats skipped
        public IEnumerable<ItemPerkEntryDefinition> Perks { get; set; }
        public long LoreHash { get; set; }
        public long? SummaryItemHash { get; set; }
        // animations skipped
        public bool AllowActions { get; set; }
        // skipped links
        public bool DoesPostmasterPullHaveSideEffects { get; set; }
        public bool NonTransferrable { get; set; }
        public IEnumerable<long> ItemCategoryHashes { get; set; }
        // Skipped specialItemType
        public EDestinyItemType ItemType { get; set; }
        public EDestinyItemSubType ItemSubType { get; set; }
        public EDestinyClass ClassType { get; set; }
        public bool Equippable { get; set; }
        public IEnumerable<long> DamageTypeHashes { get; set; }
        public IEnumerable<EDamageType> DamageTypes { get; set; }
        public EDamageType DefaultDamageType { get; set; }
        public long DefaultDamageTypeHash { get; set; }






    }
}
