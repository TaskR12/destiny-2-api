using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Components.Config
{
    public class DestinyManifest
    {
        public string Version { get; set; }
        public string MobileAssetContentPath { get; set; }
        public IEnumerable<GearAssetDataBaseDefinition> MobileGearAssetDataBases { get; set; }
        public Dictionary<string,string> MobileWorldContentPaths { get; set; }
        public Dictionary<string, string> JsonWorldContentPaths { get; set; }
        public string MobileClanBannerDatabasePath { get; set; }
        public Dictionary<string,string> MobileGearCDN { get; set; }
    }
}
