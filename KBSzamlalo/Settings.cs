  using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KBSzamlalo
{
    public static class Settings
    {
        public static bool SoundOn { get; set; } = false;
        public static bool StopWatch { get; set; } = false;
        public static bool InterVall {  get; set; } = false;
        public static int LineCounter { get; set; } = 0;

        public static List<string> Lines = new List<string>();
    }
}
