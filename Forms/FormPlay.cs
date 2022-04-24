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
using Profile.Models;
using Profile.Properties;

namespace Profile.Forms
{
    public partial class FormPlay : Container
    {


        public FormPlay()
        {
            InitializeComponent();         
        }

        private void LoadTheme()
        {
            foreach (Control control in panelButtons.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.BackColor = ThemeColor.PrimaryColor;
                    button.ForeColor = Color.Gainsboro;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormPlay_Load(object sender, EventArgs e)
        {
            LoadTheme();
            parentPanel.Controls.Clear();
            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);
        }

        public void DifficultyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            ComboBox currentDifficultyDropdown = (ComboBox)sender;
            int currentDiffColSize = difficulty[currentDifficultyDropdown.SelectedItem.ToString()].collectionSize;
            int currentDiffWidth = difficulty[currentDifficultyDropdown.SelectedItem.ToString()].width;
            int currentDiffHeight = difficulty[currentDifficultyDropdown.SelectedItem.ToString()].height;
            double currentDiffScale = difficulty[currentDifficultyDropdown.SelectedItem.ToString()].scale;

            int parentPanelWidth = (int)(currentDiffWidth * (12 * currentDiffScale));
            int parentPanelHeight = (int)(currentDiffHeight * (currentDiffColSize / (12 * currentDiffScale)));
            ClientSize = new Size(parentPanelWidth + 20, parentPanelHeight + 140);
            parentPanel.Size = new Size(parentPanelWidth, parentPanelHeight);

            
        }

        private void CollectionInit(int collectionSize, int width, int height, double scale)
        {
            string isOdd;
            int value = 0;
            int row = 5;
            int col = 5;
            for (int i = 0; i < collectionSize; i++)
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
            buttonShow.Enabled = !isShown;

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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

