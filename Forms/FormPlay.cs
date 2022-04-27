using System;
using System.Collections;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Profile.Models;
using Profile.Properties;

namespace Profile.Forms
{
    public partial class FormPlay : Container
    {
        private string buttonStartText = "Start";
        private string buttonRestartText = "Shuffle";

        public FormPlay()
        {
            InitializeComponent();
            panelButtons.SendToBack();
        }

        // LOADING CURRENT THEME
        private void LoadTheme()
        {
            buttonRestart.BackColor = ThemeColor.PrimaryColor;
            buttonRestart.ForeColor = Color.Gainsboro;
            buttonRestart.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonShow.BackColor = ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
            buttonShow.ForeColor = Color.Gainsboro;
            buttonShow.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonStart.BackColor = ThemeColor.PrimaryColor;
            buttonStart.ForeColor = Color.Gainsboro;
            buttonStart.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            showTimeout.BackColor = showTimeout.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
            showTimeout.ForeColor = Color.Gainsboro;
        }

        // LOADING THE FORM
        private void FormPlay_Load(object sender, EventArgs e)
        {
            LoadTheme();
            parentPanel.Controls.Clear();
            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);
            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            showTimeout.SelectedItem = currentShowTimeout.ToString() + " sec";
            h = 0;
            m = 0;
            s = 0;
            labelTimer.Text = "00:00:00";
        }

        // HELPER TO FOR RANDOMIZING
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

        // HELPER TO FOR RANDOMIZING
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

        // COLLECTION INIT AND RANDOMIZE
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

                Card nextCard = new Card(width - 10, false, (int)randomizedCardsOrder[i] % (collectionSize / 2), parentPanel, buttonShow, buttonStart, buttonRestart)
                {
                    Name = "_" + ((int)randomizedCardsOrder[i] % (collectionSize / 2)).ToString() + isOdd,
                    //BackgroundImage = (Image)Resources.ResourceManager.GetObject("_" + ((int)randomizedCardsOrder[i] % (collectionSize / 2)).ToString()),
                    BackgroundImage = Resources.backBlack,
                    BackgroundImageLayout = ImageLayout.Stretch,
                    Location = new Point(col, row),
                    Height = height - 10,
                    Margin = new Padding(0, 0, 0, 0),
                    TabIndex = i + 5,
                    Cursor = Cursors.Hand,
                    IsSelected = false,
                    Enabled = false,
                };

                nextCard.Click += nextCard.Card_Click;
                parentPanel.Controls.Add(nextCard);

                col += width;

                usedCards[(int)randomizedCardsOrder[i] % (collectionSize / 2)] = true;
            }
        }

        // COLLECTION TOGGLE
        private void CollectionToggle(bool isShown, bool isTurned = false)
        {
            buttonShow.Enabled = !isShown;
            buttonStart.Enabled = !isShown;
            buttonRestart.Enabled = !isShown;
            showTimeout.Enabled = !isShown;
            foreach (Card c in parentPanel.Controls)
            {
                c.Enabled = !isShown;
                int currentCardWidth = c.Width;
                c.BackgroundImage = (Image)Resources.ResourceManager.GetObject(isShown ? "_" + c.Value.ToString() : "backBlack");
                c.Enabled = isTurned ? true : false;
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

        // SHOW
        private async void ButtonShow_Click(object sender, EventArgs e)
        {
            CollectionToggle(true);
            await Task.Delay(5000);
            CollectionToggle(false, true);
        }

        private void ButtonShow_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonShow.ForeColor = Color.Gainsboro;
            buttonShow.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonShow_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonShow.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat { 
                Alignment = StringAlignment.Center, 
                LineAlignment = StringAlignment.Center 
            };
            buttonShow.Text = string.Empty;
            e.Graphics.DrawString("Show", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // START | STOP | RESUME
        private async void ButtonStart_Click(object sender, EventArgs e)
        {
            if (buttonStartText == "Start")
            {
                CollectionToggle(true);
                await Task.Delay(5000);
                CollectionToggle(false, true);
            }

            if (isStarted)
            {
                timer.Stop();
                isStarted = false;
                buttonShow.Enabled = false;
                parentPanel.Enabled = false;
                showTimeout.Enabled = false;
                buttonStart.Image = Resources.playSmall;
                buttonStart.Text = "Resume";
                buttonStartText = "Resume";
            }
            else
            {
                timer.Start();
                buttonShow.Enabled = true;
                parentPanel.Enabled = true;
                showTimeout.Enabled = true;
                isStarted = true;
                buttonStart.Image = Resources.pauseSmall;
                buttonStart.Text = "Pause";
                buttonStartText = "Pause";
                buttonRestart.Image = Resources.restartSmall;
                buttonRestart.Text = "Restart";
                buttonRestartText = "Restart";
            }
        }

        private void ButtonStart_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonStart.ForeColor = Color.Gainsboro;
            buttonStart.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonStart_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonStart.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonStart.Text = string.Empty;
            e.Graphics.DrawString(buttonStartText, currentButton.Font, drawBrush, e.ClipRectangle, sf);

            drawBrush.Dispose();
            sf.Dispose();
        }

        // RESTART | RESUME
        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            buttonStart.Text = "Start";
            buttonStart.Image = Resources.playSmall;
            buttonStartText = "Start";
            parentPanel.Controls.Clear();
            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);
            labelTimer.Text = "00:00:00";
            timer.Stop();
            h = 0;
            m = 0;
            s = 0;
            buttonRestartText = "Shuffle";
            buttonRestart.Text = "Shuffle";
            buttonRestart.Image = Resources.shuffleSmall;
            isStarted = false;
            buttonShow.Enabled = false;
            parentPanel.Enabled = false;
        }

        private void ButtonRestart_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonRestart.ForeColor = Color.Gainsboro;
            buttonRestart.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonRestart_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonRestart.ForeColor = Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonRestart.Text = string.Empty;
            e.Graphics.DrawString(buttonRestartText, currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // COUNTDOWN TIMER
        public void OnTimeEvent(object sender, System.Timers.ElapsedEventArgs e)
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
                labelTimer.Text = string.Format(
                    "{0}:{1}:{2}",
                    h.ToString().PadLeft(2, '0'),
                    m.ToString().PadLeft(2, '0'),
                    s.ToString().PadLeft(2, '0'));
            }));
        }

        private void ShowTimeout_EnabledChanged(object sender, EventArgs e)
        {
            ComboBox currentComboBox = (ComboBox)sender;
            buttonRestart.ForeColor = Color.Gainsboro;
            buttonRestart.BackColor = currentComboBox.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        // SHOW TIME OUT DROPDOWN
        public void ShowTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShowTimeout = Int32.Parse(showTimeout.SelectedItem.ToString().Split(' ')[0]);

            foreach(Card card in parentPanel.Controls)
            {
                card.currentShowTimeout = currentShowTimeout;
                card.comboBoxShowTimeout = showTimeout;
            }
        }

        private void ShowTimeout_DrawItem(object sender, DrawItemEventArgs e)
        {
            int index = e.Index >= 0 ? e.Index : 0;
            ComboBox currentComboBox = (ComboBox)sender;
            currentComboBox.BackColor = currentComboBox.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
            SolidBrush drawBrush = new SolidBrush(currentComboBox.ForeColor);
            buttonRestart.ForeColor = Color.Gainsboro;
            showTimeout.Size = new Size(94, 42);
            showTimeout.DropDownWidth = 32;
            showTimeout.ItemHeight = 36;
            e.DrawBackground();
            e.Graphics.DrawString(showTimeout.Items[index].ToString(), e.Font, drawBrush, e.Bounds, StringFormat.GenericDefault);
            e.DrawFocusRectangle();
        }

        private void CurrentMoves_TextChanged(object sender, EventArgs e)
        {
            Console.WriteLine(CurrentMoves);
        }
    }
}

