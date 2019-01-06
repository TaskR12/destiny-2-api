using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Characters;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyRaceDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EDestinyRace RaceType { get; set; }
        public Dictionary<EDestinyGender,string> GenderedRaceNames { get; set; }
        public Dictionary<long, string> GenderedRaceNamesByGenderHash { get; set; }
    }
}
