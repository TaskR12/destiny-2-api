using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.User
{
    public class UserInfoCard
    {
        public string SupplementalDisplayName { get; set; }
        public string IconPath { get; set; }
        public EBungieMembershipType MembershipType { get; set; }
        public long MembershipId { get; set; }
        public string DisplayName { get; set; }
    }
}
