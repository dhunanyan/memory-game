using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile
{
    public class Container : Form
    {
        public class Difficulty
        {
            public int collectionSize { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public double scale { get; set; }
            public int key { get; set; }

        }

        public static Dictionary<string, Difficulty> difficulty = new Dictionary<string, Difficulty>()
        {
            { "Easy", new Difficulty { collectionSize=32, width=98, height=138, scale=8, key=0 } },
            { "Normal", new Difficulty { collectionSize=50, width=(98*8)/(10), height=(138*(32/8))/(50/10), scale=10, key=1 } },
            { "Hard", new Difficulty { collectionSize=72, width=(98*8)/(12), height=(138*(32/8))/(72/12), scale=12, key=3} },
            { "Extreme", new Difficulty { collectionSize=98, width=(98*8)/(14), height=(138*(32/8))/(98/14), scale=14, key=4} }
        };

        public static string currentDifficulty = "Easy";

        public static int currentDiffColSize = difficulty[currentDifficulty].collectionSize;
        public static int currentDiffWidth = difficulty[currentDifficulty].width;
        public static int currentDiffHeight = difficulty[currentDifficulty].height;
        public static double currentDiffScale = difficulty[currentDifficulty].scale;

        public static void ChangeDifficulty(string changedDifficulty)
        {
            if(changedDifficulty.Length <= 0)
            {
                return;
            }
            currentDiffColSize = difficulty[currentDifficulty].collectionSize;
            currentDiffWidth = difficulty[currentDifficulty].width;
            currentDiffHeight = difficulty[currentDifficulty].height;
            currentDiffScale = difficulty[currentDifficulty].scale;
        }

        public static int parentPanelWidth = (int)(currentDiffWidth * currentDiffScale);
        public static int parentPanelHeight = (int)(currentDiffHeight * (currentDiffColSize / currentDiffScale));

        public static bool isStarted = false;
    }
}
