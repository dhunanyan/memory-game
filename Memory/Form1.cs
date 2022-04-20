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


        //THREAD.SLEEP(2000)
        private void collectionInit()
        {
            int row = 0;
            int col = 0;
            for(int i = 0; i < 16 / 2; i++)
            {
                col += 88;
                if (i % 8 == 0)
                {
                    row += 128;
                    col = 0;
                }

                Card nextCard = new Card()
                {
                    Value = i,
                    BackgroundImage = (Image)rm.GetObject("back.png"),
                    Image = (Image)rm.GetObject("back.png"),
                    Name = "cardA" + i.ToString(),
                    BackgroundImageLayout = ImageLayout.Zoom,
                    Location = new Point(col, row),
                    Size = new Size(88, 128),
                    TabIndex = i + 5,
                    Enabled = true
                };
                panel2.Controls.Add(nextCard);

                //cards.Add(new Card()
                //{
                //    Value = i,
                //    BackgroundImage = (Image)rm.GetObject("back.png"),
                //    Image = (Image)rm.GetObject("back.png"),
                //    Name = "cardB" + i.ToString(),
                //    BackgroundImageLayout = ImageLayout.Zoom,
                //    Location = new Point(59, 184),
                //    Size = new Size(199, 290),
                //    TabIndex = 2,
                //    //Paint += new PaintEventHandler(this.panel1_Paint),
                //    Enabled = true
                //});
            }

            foreach (Control c in panel2.Controls)
            {
                if (c.GetType() == typeof(Card))
                {
                    Console.WriteLine(c.Name);
                }
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
