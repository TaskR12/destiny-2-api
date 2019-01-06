using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;

namespace Destiny2.Api.Model.Definitions
{
    public enum EAggregationType
    {
        CharacterAverage = 0,
        Character = 1,
        Item = 2,
    }

    public enum EStatCategory
    {
        Gameplay = 0,
        Weapon = 1,
        Defense = 2,
        Primary = 3,
    }

    public class DestinyStatDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EAggregationType AggregationType { get; set; }
        public bool HasComputedBlock { get; set; }
        public EStatCategory StatCategory { get; set; }
    }
}
