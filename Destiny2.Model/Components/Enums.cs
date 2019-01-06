using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public static class Enums
    {
        public enum EDestinyScope
        {
            Profile = 0,
            Character = 1,
        }


        public enum EDestinyClass
        {
            Titan = 0,
            Hunter = 1,
            Warlock = 2,
            Unknown = 3,
        }

        public enum EDestinyItemType
        {
            None = 0,
            Currency = 1,
            Armor = 2,
            Weapon = 3,
            Message = 7,
            Engram = 8,
            Consumable = 9,
            ExchangeMaterial = 10,
            MissionReward = 11,
            QuestStep = 12,
            QuestStepComplete = 13,
            Emblem = 14,
            Quest = 15,
            Subclass = 16,
            ClanBanner = 17,
            Aura = 18,
            Mod = 19,
            Dummy = 20,
            Ship = 21,
            Vehicle = 22,
            Emote = 23,
            Ghost = 24,
            Package = 25,
            Bounty = 26
        }

        public enum EDamageType
        {
            None = 0,
            Kinetic = 1,
            Arc = 2,
            Thermal = 3,
            Void = 4,
            Raid = 5
        }

        public enum EDestinyGender
        {
            Male = 0,
            Female = 1,
            Unknown = 2,
        }



        public enum EDestinyComponentType
        {
            None = 0,
            Profiles = 100,
            VendorReceipts = 101,
            ProfileInventories = 102,
            ProfileCurrencies = 103,
            ProfileProgression = 104,
            Characters = 200,
            CharacterInventories = 201,
            CharacterProgressions = 202,
            CharacterRenderData = 203,
            CharacterActivities = 204,
            CharacterEquipment = 205,
            ItemInstances = 300,
            ItemObjectives = 301,
            ItemPerks = 302,
            ItemRenderData = 303,
            ItemStats = 304,
            ItemSockets = 305,
            ItemTalentGrids = 306,
            ItemCommonData = 307,
            Vendor = 400,
            VendorCategories = 401,
            VendorSales = 402,
            Kiosks = 500,
            CurrencyLookups = 600,
            PresentationNodes = 700,
            Collectibles = 800,
            Records = 900
        }

        public enum EDestinyMilestoneType
        {
            Unknown = 0,
            Tutorial = 1,
            OneTime = 2,
            Weekly = 3,
            Daily = 4,
            Special = 5
        }

        public enum EDestinyGatingScope
        {
            None = 0,
            Global = 1,
            Clan = 2,
            Profile = 3,
            Character = 4,
            Item = 5,
            AssumedWorstCase = 6,
        }

        public enum EDestinyUnlockValueUIStyle
        {
            Automatic = 0,
            Fraction = 1,
            Checkbox = 2,
            Percentage = 3,
            DateTime = 4,
            FractionFloat = 5,
            Integer = 6,
            TimeDuration = 7,
            Hidden = 8,
            Multiplier = 9
        }

        public enum EDestinyRewardSourceCategory
        {
            None = 0,
            Activity = 1,
            Vendor = 2,
            Aggregate = 3,
        }

        public enum EDestinyTalentNodeStepWeaponPerformances
        {
            None = 0,
            RateOfFire = 1,
            Damage = 2, 
            Accuracy = 4,
            Range = 8, 
            Zoom = 16,
            Recoil = 32,
            Ready = 64,
            Reload = 128, 
            HairTrigger = 256,
            AmmoAndMagazine = 512,
            TrackingAndDetonation = 1024,
            ShotgunSpread = 2048,
            ChargeTime = 2096,
            All = 8191,
        }

        public enum EDestinyTalentNodeStepImpactEffects
        {
            None = 0,
            ArmorPiercing = 1,
            Ricochet = 2,
            Flinch = 4,
            CollateralDamage = 8,
            Disorient = 16,
            HighlightTarget = 32,
            All = 63,
        }

        public enum EDestinyTalentNodeStepGuardianAttributes
        {
            None = 0,
            Stats = 1,
            Shields = 2,
            Health = 4,
            Revive = 8,
            AimUnderFire = 16,
            Radar = 32,
            Invisibility = 64,
            Reputations = 128,
            All = 255
        }

        public enum EDestinyTalentNodeStepLightAbilities
        {
            None = 0,
            Grenades = 1,
            Melee = 2,
            MovementModes = 4,
            Orbs = 8,
            SuperEnergy = 16,
            SuperMods = 32,
            All = 63,
        }

        public enum EDestinyTalentNodeStepDamageTypes
        {
            None = 0,
            Kinetic = 1,
            Arc = 2,
            Solar = 4,
            Void = 8,
            All = 15,
        }

        public enum ESocketTypeActionType
        {
            InsertPlug = 0,
            InfuseItem = 1,
            ReinitializeSocket = 2,
        }

        public enum EVendorDisplayCategorySortOrder
        {
            Default = 0,
            SortByTier = 1,
        }

        public enum EDestinyVendorInteractionRewardSelection
        {
            None = 0,
            One = 1,
            All = 2,
        }

        public enum EDestinyVendorReplyType
        {
            Accept = 0,
            Decline = 1,
            Complete = 2,
        }

        public enum EVendorInteractionType
        {
            Unknown = 0,
            QuestComplete = 1,
            QuestContinue = 2,
            ReputationPreview = 3,
            RankUpReward = 4,
            TokenTurnIn = 5,
            QuestAccept = 6,
            ProgressTab = 7,
            End = 8,
            Start = 9
        }

        public enum EDestinyVendorItemRefundPolicy
        {
            NotRefundable = 0,
            DeletesItem = 1,
            RevokesLicense = 2,
        }

        public enum EDestinyItemSortType
        {
            ItemId = 0,
            Timestamp = 1,
            StackSize = 2,
        }

        public enum EDestinySocketVisibility
        {
            Visible = 0,
            Hidden = 1,
            HiddenWhenEmpty = 2,
            HiddenIfNoPlugsAvailable = 3,s
        }

        public enum EDestinySocketCategoryStyle
        {
            Unknown = 0,
            Reusable = 1,
            Consumable = 2,
            Unlockable = 3,
            Intrinsic = 4,
        }

        public enum EDestinyProgressionScope
        {
            Account = 0,
            Character = 1,
            Clan = 2,
            Item = 3,
            ImplicitFromEquipment = 4,
            Mapped = 5,
            MappedAggregate = 6,
            MappedStat = 7,
            MappedUnlockValue = 8,
        }

        public enum EDestinyRecordToastStyle
        {
            None = 0,
            Record = 1,
            Lore = 2,
            Badge = 3,
            MetaRecord = 4,
            MedalComplete = 5
        }

        public enum EDestinyRecordValueStyle
        {
            Integer = 0,
            Percentage = 1,
            Milliseconds = 2,
            Boolean = 3,
            Decimal = 4,
        }

        public enum EDestinyProgressionStepDisplayEffect
        {
            None = 0,
            Character = 1,
            Item = 2
        }

        public enum EDestinyObjectiveGrantStyle
        {
            WhenIncomplete = 0,
            WhenComplete = 1,
            Always = 2,
        }

        public enum EDestinyActivityNavPointType
        {

            Inactive= 0,
            PrimaryObjective= 1,
            SecondaryObjective= 2,
            TravelObjective= 3,
            PublicEventObjective= 4,
            AmmoCache= 5,
            PointTypeFlag= 6,
            CapturePoint= 7,
            DefensiveEncounter= 8,
            GhostInteraction= 9,
            KillAi= 10,
            QuestItem= 11,
            PatrolMission= 12,
            Incoming= 13,
            ArenaObjective= 14,
            AutomationHint= 15,
            TrackedQuest= 16,


        }

        public enum EBungieMembershipType
        {
            None = 0,
            TigerXbox = 1,
            TigerPsn = 2,
            TigerBlizzard = 4,
            TigerDemon = 10,
            BungieNext = 254,
            All = -1,
        }

    }
}
