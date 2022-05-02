using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Profile
{
    public class Container : Form
    {
        public static Button currentButton;
        public static Form currentForm;
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
            { "Easy", new Difficulty { collectionSize=8*4, width=98, height=138, scale=8, key=0 } },
            { "Normal", new Difficulty { collectionSize=10*5, width=(98*8)/(10), height=(138*(32/8))/(50/10), scale=10, key=1 } },
            { "Hard", new Difficulty { collectionSize=12*6, width=(98*8)/(12), height=(138*(32/8))/(72/12), scale=12, key=3} },
            { "Extreme", new Difficulty { collectionSize=14*7, width=(98*8)/(14), height=(138*(32/8))/(98/14), scale=14, key=4} }
        };
        public static string currentDifficulty = "Easy";
        public static bool isGodeMode = false;
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

        public static Dictionary<string, string> stats = new Dictionary<string, string>()
        {
            { "Moves", "0" },
            { "Shows", "0" },
            { "Hints", "0" },
            { "Difficulty", "Easy" },
        };

        public static bool isStarted;
        public static bool isLaunched;

        public int h, m, s;
        public System.Timers.Timer timer = new System.Timers.Timer();
        public static int currentShowTimeout = 5;
        public static int currentInitialShowTime = 5;

        public static Label CurrentMoves { get; set; }

        public static Label CurrentShows { get; set; }
        public static Label CurrentHints { get; set; }
        public static Label CurrentDifficulty { get; set; }
        public static Label ExtremeCardName { get; set; }
        
        public static string[] currentUser = {"Username", "Password", "Shows", "Hints", "Moves", "Time", "Score"};
        public static string[] CurrentUser { get => currentUser; set => currentUser = value; }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            this.ClientSize =new System.Drawing.Size(1924, 1055);
            this.Name = "Container";
            this.ResumeLayout(false);
        }


        public static Label IsGameOver { get; set; }
    }
}
