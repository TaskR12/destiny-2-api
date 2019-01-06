using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Destiny2.Api.Model
{
    public class DestinyProgression
    {
        public long ProgressionHash { get; set; }
        public int DailyProgress { get; set; }
        public int DailyLimit { get; set; }
        public int WeeklyProgress { get; set; }
        public int WeeklyLimit { get; set; }
        // Current XP
        public int CurrentProgress { get; set; }
        public int Level { get; set; }
        public int LevelCap { get; set; }
        public int StepIndex { get; set; }
        public int ProgressToNextLevel { get; set; }
        public int NextLevelAt { get; set; }
    }
}
