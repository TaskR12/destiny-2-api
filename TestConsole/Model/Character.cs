using Destiny2.Api.Model.Characters;
using System;
using System.Collections.Generic;
using static Destiny2.Api.Model.Enums;

namespace TestConsole.Model
{
    public class Character
    {
        public long MembershipId { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public TimeSpan TotalPlaytime { get; set; }
        public int Light { get; set; }
        public int Mobility { get; set; }
        public int Resilience { get; set; }
        public int Recovery { get; set; }
        public EDestinyGender Gender { get; set; }
        public EDestinyClass Class { get; set; }
        public EDestinyRace Race { get; set; }
        public IEnumerable<Item> Equipment { get; set; }
    }
}
