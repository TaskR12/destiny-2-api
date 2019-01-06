using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Definitions
{
    public class ItemQualityBlockDefinition
    {
        public IEnumerable<int> ItemLevels { get; set; }
        public int QualityLevel { get; set; }
        public string InfusionCategoryName { get; set; }
        public long InfusionCategoryHash { get; set; }
        public IEnumerable<long> InfusionCategoryHashes { get; set; }
        public long ProgressionLevelRequirementHash { get; set; }
    }
}
