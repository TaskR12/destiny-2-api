using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Milestones
{
    public enum EActivityModeType
    {
        None = 0,
        Story = 2,
        Strike = 3,
        Raid = 4,
        AllPvP = 5,
        Patrol = 6,
        AllPvE = 7,
        Reserved9 = 9,
        Control = 10,
        Reserved11 = 11,
        Clash = 12,
        Reserved13 = 13,
        CromsonDoubles = 15,
        Nightfall = 16,
        HeroicNightfall = 17,
        AllStrikes = 18,
        IronBanner = 19,
        Reserved20 = 20,
        Reserved21 = 21,
        Reserved22 = 22,
        Reserved24 = 24,
        AllMayhem = 25,
        Reserved26 = 26,
        Reserved27 = 27,
        Reserved28 = 28,
        Reserved29 = 29,
        Reserved30 = 30,
        Supremacy = 31,
        PrivateMatchesAll = 32,
        Survival = 37,
        Countdown = 38,
        TrialsOfTheNine = 39,
        Social = 40,
        TrialsCountdown = 41,
        TrialsSurvival = 42,
        IronBannerControl = 43,
        IronBannerClash = 44,
        IronBannerSupremacy = 45, 
        ScoredNightfall = 46,
        ScoredHeroicNightfall = 47,
        Rumble = 48,
        AllDoubles = 49,
        Doubles = 50, 
        PrivateMatchesClash = 51,
        PrivateMatchesControl = 52,
        PrivateMatchesSupremacy = 53,
        PrivateMatchesCountdown = 54,
        PrivateMatchesSurvival = 55,
        PrivateMatchesMayhem = 56,
        PrivateMatchesRumble = 57,
        HeroicAdventure = 58,
        Showdown = 59, 
        Lockdown= 60, 
        Scrorched = 61,
        ScrorchedTeam = 62,
        Gambit = 63,
        AllPvECompetitive = 64,
        Breakthrough = 65,
        BlackArmoryRun = 66,
        Salvage = 67,
        IronBannerSalvage = 68


    }

    public class DestinyMilestoneActivity
    {
        public long ActivityHash { get; set; }
        public long? ActivityModeHash { get; set; }
        public EActivityModeType ActivityModeType { get; set; }
        public IEnumerable<long> ModifierHashes { get; set; }
        public IEnumerable<DestinyMilestoneActivityVariant> Variants { get; set; }
    }
}
