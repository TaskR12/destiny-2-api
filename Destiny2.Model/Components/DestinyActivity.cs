using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public enum EDestinyActivityDifficultyTier
    {
        Trivial = 0,
        Easy = 1,
        Normal = 2,
        Challenging = 3, 
        Hard = 4,
        Brave = 5,
        AlmostImpossible = 6,
        Impossible = 7
    }


    public class DestinyActivity
    {
        public long ActivityHash { get; set; }
        public bool IsNew { get; set; }
        public bool CanLead { get; set; }
        public bool CanJoin { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsVisible { get; set; }
        public int? DisplayLevel { get; set; }
        public int? RecommendedLight { get; set; }
        public EDestinyActivityDifficultyTier DifficultyTier { get; set; }
    }
}
