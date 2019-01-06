using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Destiny2.Api.Model.User;

namespace Destiny2.Api.Model.Profiles
{
    public enum EDestinyGameVersions
    {
        None = 0,
        Destiny2 = 1,
        DLC1 = 2,
        DLC2 = 4,
        Forsaken = 8,
        YearTwoAnnualPass = 16,
    }

    public class DestinyProfileComponent
    {
        public UserInfoCard UserInfo { get; set; }
        public DateTime DateLastPlayed { get; set; }
        public EDestinyGameVersions VersionsOwned { get; set; }
        public IEnumerable<long> CharacterIds { get; set; }
    }
}
