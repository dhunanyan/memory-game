using System;
using System.Collections;
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
        System.Timers.Timer timer = new System.Timers.Timer();
        public static int h, m, s;

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
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += onTimeEvent;
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

        static int getNum(ArrayList v)
        {
            int n = v.Count;
            Random rand = new Random();
            int index = (rand.Next() % n);
            int num = (int)v[index];
            v[index] = (int)v[n - 1];
            v.Remove(v[n - 1]);
            return num;
        }

        static ArrayList generateRandom(int n)
        {
            ArrayList v = new ArrayList(n);
            for (int i = 0; i < n; i++)
            {
                v.Add(i + 1);
            }
            ArrayList resultV = new ArrayList(n);
            while (v.Count > 0)
            {
                resultV.Add(getNum(v));
            }
            return resultV;
        }

        private void CollectionInit(int collectionSize, int width, int height, double scale)
        {
            string isOdd;
            int row = 5;
            int col = 5;

            ArrayList randomizedCardsOrder = generateRandom(collectionSize);
            bool[] usedCards = new bool[collectionSize/2];

            for (int i = 0; i < randomizedCardsOrder.Count; i++)
            {
                isOdd = "B";
                if (usedCards[(int)randomizedCardsOrder[i] % (collectionSize / 2)])
                {
                    isOdd = "A";
                }

                if (i % scale == 0 & i != 0)
                {
                    row += height;
                    col = 5;
                }

                Card nextCard = new Card(width - 10, false, (int)randomizedCardsOrder[i] % (collectionSize / 2), parentPanel)
                {
                    Name = "_" + ((int)randomizedCardsOrder[i] % (collectionSize / 2)).ToString() + isOdd,
                    BackgroundImage = (Image)Resources.ResourceManager.GetObject("_" + ((int)randomizedCardsOrder[i] % (collectionSize / 2)).ToString()),
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

                usedCards[(int)randomizedCardsOrder[i] % (collectionSize / 2)] = true;
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

        private async void ButtonShow_Click(object sender, EventArgs e)
        {
            CollectionToggle(true);
            await Task.Delay(5000);
            CollectionToggle(false);
        }

        private void ButtonShow_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonShow.ForeColor = currentButton.Enabled ? Color.Gainsboro : Color.Black;
            buttonShow.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonShow_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonShow.ForeColor = isStarted ? Color.Gainsboro : Color.Gray;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat { 
                Alignment = StringAlignment.Center, 
                LineAlignment = StringAlignment.Center 
            };
            buttonShow.Text = string.Empty;
            e.Graphics.DrawString("Show Cards", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void ButtonStart_Click(object sender, EventArgs e)
        {
            if (buttonStart.Text == "Start")
            {
                CollectionToggle(false);
            }
            if (isStarted)
            {
                timer.Stop();
                isStarted = false;
                buttonShow.Enabled = false;
                parentPanel.Enabled = false;
                buttonStart.Text = "Resume";
            }
            else
            {
                timer.Start();
                buttonShow.Enabled = true;
                parentPanel.Enabled = true;
                isStarted = true;
                buttonStart.Text = "Pause";
            }
        }

        private void ButtonStart_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            currentButton.ForeColor = currentButton.Enabled ? Color.Gainsboro : Color.Silver;
            currentButton.BackColor = currentButton.Enabled ? ThemeColor.TertiaryColor : ThemeColor.TertiaryColor;
            currentButton.FlatAppearance.BorderColor = currentButton.Enabled ? ThemeColor.SecondaryColor : ThemeColor.TertiaryColor;
            currentButton.UseVisualStyleBackColor = false;
            currentButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(100, Color.Black);
        }

        private void panelContainer_Paint(object sender, PaintEventArgs e)
        {

        }



        public void onTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
        {
            Invoke(new Action(() =>
            {
                s++;
                if (s == 60)
                {
                    s = 0;
                    m++;
                }
                if (m == 60)
                {
                    m = 0;
                    h++;
                }
                labelTimer.Text = string.Format("{0}:{1}:{2}",
                    h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'));
            }));
        }
    }
}

