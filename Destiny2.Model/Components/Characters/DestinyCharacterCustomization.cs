using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Characters
{
    public class DestinyCharacterCustomization
    {
        public long Personality { get; set; }
        public long Face { get; set; }
        public long SkinColor { get; set; }
        public long LipColor { get; set; }
        public long EyeColor { get; set; }
        public IEnumerable<long> HairColors { get; set; }
        public IEnumerable<long> FeatureColors { get; set; }
        public long DecalColor { get; set; }
        public bool WearHelmet { get; set; }
        public int HairIndex { get; set; }
        public int FeatureIndex { get; set; }
        public int DecalIndex { get; set; }
    }
}
