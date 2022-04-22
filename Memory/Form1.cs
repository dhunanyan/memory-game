using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using Memory.Models;
using Memory.Properties;

namespace Memory
{
    public partial class Form1 : Form
    {
        public int isSelectedCounter = 0;
        public int isSelectedValue = 9999;
        public string isSelectedName = "";
        class Difficulty
        {
            public int collectionSize { get; set; }
            public int width { get; set; }
            public int height { get; set; }
            public double scale { get; set; }
            public int key { get; set; }
            
        }

        Dictionary<string, Difficulty> difficulty = new Dictionary<string, Difficulty>()
        {
            { "Easy", new Difficulty { collectionSize=24, width=118, height=166, scale=1/1.5, key=1 } },
            { "Normal", new Difficulty { collectionSize=48, width=98, height=138, scale=1, key=2 } },
            { "Hard", new Difficulty { collectionSize=96, width=73, height=102, scale=1 + 1 - 1/1.5, key=3} }

        };

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
    
        }

        private void DifficultyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            parentPanel.Controls.Clear();
            int currentDiffColSize = difficulty[difficultyDropdown.SelectedItem.ToString()].collectionSize;
            int currentDiffWidth = difficulty[difficultyDropdown.SelectedItem.ToString()].width;
            int currentDiffHeight = difficulty[difficultyDropdown.SelectedItem.ToString()].height;
            double currentDiffScale = difficulty[difficultyDropdown.SelectedItem.ToString()].scale;
            
            int parentPanelWidth = (int)(currentDiffWidth * (12 * currentDiffScale));
            int parentPanelHeight = (int)(currentDiffHeight * (currentDiffColSize / (12 * currentDiffScale)));
            ClientSize = new Size(parentPanelWidth + 20, parentPanelHeight + 140);
            parentPanel.Size = new Size(parentPanelWidth, parentPanelHeight);

            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);
        }


        
        private void CollectionInit(int collectionSize, int width, int height, double scale)
        {
            string isOdd;
            int value = 0;
            int row = 5;
            int col = 5;
            for(int i = 0; i < collectionSize; i++)
            {
                isOdd = "B";
                if (i % 2 == 0)
                {
                    value++;
                    isOdd = "A";
                }
                
                if (i % Math.Round(12 * scale) == 0 & i != 0)
                {
                    row += height;
                    col = 5;
                }

                Card nextCard = new Card(width - 10, false, value, parentPanel)
                {
                    Image = Resources.back,
                    Name = "_" + value.ToString() + isOdd,
                    BackgroundImage = Resources.back,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(col, row),
                    Height = height - 10,
                    Margin = new Padding(0, 0, 0, 0),
                    TabIndex = i + 5,
                    Cursor = Cursors.Hand,
                    IsSelected = false,
                    Enabled = true,
                };

                nextCard.Click += nextCard.Card_Click;
                parentPanel.Controls.Add(nextCard);

                col += width;
            }


        }

        private void CollectionToggle(bool isShown)
        {
            Start.Enabled = !isShown;
            difficultyDropdown.Enabled = !isShown;

            foreach (Card c in parentPanel.Controls)
            {
                c.Enabled = !isShown;
                int currentCardWidth = c.Width;
                c.BackgroundImage = (Image)Resources.ResourceManager.GetObject(isShown ? "_" + c.Value.ToString() : "back");
                if (isShown)
                {
                    for (int i = 0; i <= currentCardWidth; i++)
                    {
                        c.BorderStyle = BorderStyle.Fixed3D;
                        c.Size = new Size(i, c.Height);
                    }
                }
                else
                {
                    c.BorderStyle = BorderStyle.Fixed3D;
                    c.Size = new Size(currentCardWidth, c.Height);
                }
            }
        }

        private async void Start_Click(object sender, EventArgs e)
        {
            CollectionToggle(true);
            await Task.Delay(5000);
            CollectionToggle(false);
        }
    }
}

