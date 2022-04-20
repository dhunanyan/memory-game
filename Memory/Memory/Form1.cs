using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory.Models;
using Memory.Properties;

namespace Memory
{
    public partial class Form1 : Form
    {
        private int collectionSize;
        private List<Card> cards = new List<Card>();
        private List<Card> shuffledCards = new List<Card>();
        private ResourceManager rm = Resources.ResourceManager;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void difficultyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            collectionSize = Int32.Parse(difficultyDropdown.SelectedItem.ToString());
            Console.WriteLine(collectionSize);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        //THREAD.SLEEP(2000)
        private void collectionInit()
        {
            for(int i  = 0; i < collectionSize / 2; i++)
            {
                cards.Add(new Card() { 
                    Value = i,
                    BackgroundImage = (Image)rm.GetObject("back.png"),
                    Image = (Image)rm.GetObject("back.png"),
                    Name = "cardA" + i.ToString()
                });

                cards.Add(new Card()
                {
                    Value = i,
                    BackgroundImage = (Image)rm.GetObject("back.png"),
                    Image = (Image)rm.GetObject("back.png"),
                    Name = "cardB" + i.ToString()
                });
            }
        }

        private void generateCollection()
        {

        }

        private void Start_Click(object sender, EventArgs e)
        {
            collectionInit();
        }
    }
}
