﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.Definitions.Common;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions
{
    public class DestinyRewardSourceDefinition : Definition
    {
        public DestinyDisplayPropertiesDefinition DisplayProperties { get; set; }
        public EDestinyRewardSourceCategory Category { get; set; }

    }
}
