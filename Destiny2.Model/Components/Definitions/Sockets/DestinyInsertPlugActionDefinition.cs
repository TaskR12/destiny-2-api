using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Destiny2.Api.Model.Enums;

namespace Destiny2.Api.Model.Definitions.Sockets
{
    public class DestinyInsertPlugActionDefinition
    {
        public int ActionExecuteSeconds { get; set; }
        public ESocketTypeActionType ActionType { get; set; }
    }
}
