using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model.Characters
{
    public class DestinyCharacterRenderComponent
    {
        public IEnumerable<DyeReference> CustomDyes { get; set; }
        public DestinyCharacterCustomization Customization { get; set; }
        public DestinyCharacterPeerView PeerView { get; set; }
    }
}
