using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Misc;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Characters
{
    public enum EDestinyRace
    {
        Human = 0,
        Awoken = 1,
        Exo = 2,
        Unknown = 3,
    }


    public class DestinyCharacterComponent
    {
        public long MembershipId { get; set; }

        public long CharacterId { get; set; }

        public EBungieMembershipType MembershipType { get; set; }

        public DateTime DateLastPlayed { get; set; }

        public int MinutesPlayedThisSession { get; set; }

        public int MinutesPlayedTotal { get; set; }

        public int Light { get; set; }

        public Dictionary<long,int> Stats { get; set; }

        public long RaceHash { get; set; }

        public long GenderHash { get; set; }

        public long ClassHash { get; set; }

        public EDestinyRace RaceType { get; set; }

        public EDestinyClass ClassType { get; set; }

        public EDestinyGender GenderType { get; set; }

        public string EmblemPath { get; set; }

        public string EmblemBackgroundPath { get; set; }

        public long EmblemHash { get; set; }

        public Color EmblemColor { get; set; }

        public DestinyProgression LevelProgression { get; set; }

        public int BaseCharacterLevel { get; set; }

        public float PercentToNextLevel { get; set; }

        public long TitleRecordHash { get; set; }



    }
}
