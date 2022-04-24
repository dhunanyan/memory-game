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
            { "Easy", new Difficulty { collectionSize=24, width=118, height=166, scale=1/1.5, key=0 } },
            { "Normal", new Difficulty { collectionSize=48, width=98, height=138, scale=1, key=1 } },
            { "Hard", new Difficulty { collectionSize=96, width=73, height=102, scale=1 + 1 - 1/1.5, key=2} }

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

        public static int parentPanelWidth = (int)(currentDiffWidth * (12 * currentDiffScale));
        public static int parentPanelHeight = (int)(currentDiffHeight * (currentDiffColSize / (12 * currentDiffScale)));
    }
}
