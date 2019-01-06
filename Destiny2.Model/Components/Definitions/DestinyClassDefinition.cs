using System;
using System.Collections.Generic;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyClassDefinition : Definition
    {
        public EDestinyClass ClassType { get; set; }
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public Dictionary<EDestinyGender,string> GenderedClassNames { get; set; }
        public Dictionary<long, string> GenderedClassNamesByGenderHash { get; set; }
        public long MentorVendorHash { get; set; }
    }
}
