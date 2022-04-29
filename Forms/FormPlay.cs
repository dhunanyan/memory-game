using System;
using System.Collections;
using System.Data.OleDb;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using Profile.Models;
using Profile.Properties;

namespace Profile.Forms
{
    public partial class FormPlay : Container
    {
        private string buttonStartText;
        private string buttonRestartText;
        private static Random random = new Random();
        public static int scoreIteral = 0;
        public static int currentScore = 0;
        public static int multiplier = 2;
        public static int currentTime = 0;

        public FormPlay()
        {
            InitializeComponent();
            panelButtons.SendToBack();
            IsGameOver = new Label()
            {
                Enabled = false
            };
            IsGameOver.EnabledChanged += new EventHandler(IsGameOver_EnabledChanged);
        }

        // DATABASE
        OleDbConnection connection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbConnection connection1 = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=db_users.mdb");
        OleDbCommand command = new OleDbCommand();
        OleDbDataAdapter da = new OleDbDataAdapter();

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

            raiseScore = new Timer(components);
            raiseScore.Tick += new EventHandler(RaiseScore);
            raiseScore.Interval = 1;
        }

        // LOADING THE FORM
        private void FormPlay_Load(object sender, EventArgs e)
        {
            LoadTheme();
            parentPanel.Controls.Clear();
            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);

            labelCurrentUsername.Text = char.ToUpper(CurrentUser[0][0]) + CurrentUser[0].Substring(1, CurrentUser[0].Length - 1) + "        ";

            isStarted = false;
            buttonShow.Enabled = false;
            parentPanel.Enabled = true;
            showTimeout.Enabled = true;

            buttonStart.Image = Resources.playSmall;
            buttonStart.Text = "Start";
            buttonStartText = "Start";
            buttonRestart.Image = Resources.shuffleSmall;
            buttonRestart.Text = "Shuffle";
            buttonRestartText = "Shuffle";

            timer.Interval = 1000;
            timer.Elapsed += OnTimeEvent;
            showTimeout.SelectedItem = currentShowTimeout.ToString() + " sec";
            h = 0;
            m = 0;
            s = 0;
            labelTimer.Text = "00:00:00";
            timer.Stop();

            CurrentMoves = labelMovesValue;
            CurrentHints = labelHintsValue;
            CurrentShows = labelShowsValue;

            CurrentMoves.TextChanged += new EventHandler(LabelMovesValue_TextChanged);
            CurrentShows.TextChanged += new EventHandler(LabelShowsValue_TextChanged);

            multiplier = currentDifficulty == "Easy" ? 2 : currentDifficulty == "Normal" ? 4 : currentDifficulty == "Hard" ? 6 : 8;
            labelDifficultyValue.Text = currentDifficulty;
            labelShowsValue.Text = "0";
            labelHintsValue.Text = "0";
            labelMovesValue.Text = "0";

            ExtremeCardName = new Label
            {
                Text = "backBlack"
            };
            ExtremeCardName.TextChanged += new EventHandler(LabelExtremeCard_TextChanged);

            pictureBoxExtreme.BackgroundImage = isGodeMode ? Resources.backBlack : Resources.trophy;
            pictureBoxExtreme.BackgroundImageLayout = ImageLayout.Zoom;
        }

        
        private async void IsGameOver_EnabledChanged(object sender, EventArgs e)
        {
            if (IsGameOver.Enabled)
            {
                System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));

                timer.Stop();
                timer.Elapsed -= OnTimeEvent;
                labelScore.AutoSize = false;
                labelScore.Font = new Font("Tw Cen MT Condensed", 32F, FontStyle.Bold);
                labelScore.ForeColor = Color.Gainsboro;
                labelScore.Location = new Point(250, 270);
                labelScore.Name = "labelScore";
                labelScore.Size = new Size(290, 50);
                labelScore.TabIndex = 8;
                labelScore.Text = "0 points";
                labelScore.TextAlign = ContentAlignment.MiddleCenter;

                RichTextBox instruction = new RichTextBox();
                instruction.Dock = DockStyle.Fill;
                instruction.AutoSize = false;
                instruction.BackColor = Color.FromArgb(68, 68, 93);
                instruction.BorderStyle = BorderStyle.None;
                instruction.Font = new Font("Tw Cen MT Condensed", 18F, FontStyle.Bold, GraphicsUnit.Point, 238);
                instruction.ForeColor = Color.Gainsboro;
                instruction.Location = new Point(0, 0);
                instruction.Margin = new Padding(0);
                instruction.Name = "labelInstruction";
                instruction.Size = new Size(620, 120);
                instruction.ReadOnly = true;
                instruction.TabIndex = 0;
                instruction.Text = "( [Shows] × [Multiplier] ÷ [Size] × 2) +\n( [Hints] × [Multiplier] × 10 ÷ [Size] )" +
                                    " +\n( [Moves] × [Multiplier] × 100 ÷ [Size] ) +\n[Size] × [Multiplier] ÷ ( [Hours]" +
                                    " × 3600 + [Min] × 60 + [Sec] )";

                Label labelWin = new Label();
                labelWin.AutoSize = false;
                labelWin.BackColor = Color.FromArgb(33, 150, 243);
                labelWin.Font = new Font("Tw Cen MT Condensed", 64F, FontStyle.Bold);
                labelWin.ForeColor = Color.Gainsboro;
                labelWin.Location = new Point(20, 330);
                labelWin.Name = "labelWin";
                labelWin.Size = new Size(740, 200);
                labelWin.TabIndex = 0;
                labelWin.Text = "You Won!";
                labelWin.TextAlign = ContentAlignment.MiddleCenter;

                Panel panelInstruction = new Panel();
                panelInstruction.BackColor = Color.FromArgb(68, 68, 93);
                panelInstruction.Controls.Add(instruction);
                panelInstruction.Location = new Point(20, 20);
                panelInstruction.Name = "panelInstruction";
                panelInstruction.Padding = new Padding(80, 60, 80, 60);
                panelInstruction.Size = new Size(740, 240);
                panelInstruction.TabIndex = 1;
                panelInstruction.Visible = false;
                panelInstruction.ResumeLayout(false);
                panelInstruction.SuspendLayout();
                parentPanel.Controls.Add(panelInstruction);
                parentPanel.Controls.Add(labelScore);
                parentPanel.Controls.Add(labelWin);


                //{ "Username", "Password", "Shows", "Hints", "Moves", "Time", "Score"};
                currentScore =
                    (int.Parse(labelShowsValue.Text) * multiplier / currentDiffColSize * 2) +
                    (int.Parse(labelHintsValue.Text) * multiplier * 10 / currentDiffColSize) +
                    (int.Parse(labelMovesValue.Text) * multiplier * 100 / currentDiffColSize) +
                    (3600 * currentDiffColSize * multiplier / (h * 3600 + m * 60 + s));
                //CurrentUser[3] = labelShowsValue.Text;
                //CurrentUser[4] = labelHintsValue.Text;
                //CurrentUser[5] = labelMovesValue.Text;
                //CurrentUser[6] = labelTimer.Text;
                //CurrentUser[7] = score.ToString();
                Console.WriteLine(currentTime);
                UpdateData(labelShowsValue.Text, labelHintsValue.Text, labelMovesValue.Text, labelTimer.Text, currentScore);
                Console.WriteLine(currentScore);

                await Task.Delay(350);
                panelInstruction.Visible = true;
                raiseScore.Start();
            }
        }

        private void UpdateData(string shows, string hints, string moves, string time, int score)
        {
            connection.Open();
            connection1.Open();
            string userScore = $"SELECT * FROM table_users WHERE username='{CurrentUser[0]}'";
            OleDbCommand command1 = new OleDbCommand(userScore, connection1);
            OleDbDataReader reader = command1.ExecuteReader();

            while (reader.Read())
            {
                if(int.Parse(reader[6].ToString()) <= score){
                    MessageBox.Show($"Congratulations {CurrentUser[0]} It's your new record!", "Ranking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    string query = $"UPDATE table_users SET shows='{shows}', hints='{hints}', moves='{moves}', gameOverTime='{time}', score={score} WHERE username='{CurrentUser[0]}'";
                    command = new OleDbCommand(query, connection);
                    command.ExecuteNonQuery();
                    connection.Close();
                }
                else
                {
                    MessageBox.Show($"You won {CurrentUser[0]}, Try to beat you record!!", "Ranking Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }     
        }

        private void RaiseScore(object sender, EventArgs e)
        {      
            scoreIteral += currentScore.ToString().Length > 2 ? (int)Math.Pow(10, currentScore.ToString().Length - 2) : 10;
            labelScore.Text = scoreIteral.ToString() + " points";
            if(scoreIteral >= currentScore)
            {
                raiseScore.Stop();
            }
        }

        private void FormPlay_Leave(object sender, EventArgs e)
        {
            timer.Stop();
            timer.Elapsed -= OnTimeEvent;
            h = 0;
            m = 0;
            s = 0;
        }

        // HELPER TO FOR RANDOMIZING
        private static int getNum(ArrayList v)
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
        private static ArrayList generateRandom(int n)
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

                Card nextCard = new Card(width - 10, false, (int)randomizedCardsOrder[i] % (collectionSize / 2), parentPanel, buttonShow, buttonStart, buttonRestart, showTimeout, isGodeMode)
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
            int currentShows = int.Parse(CurrentShows.Text);
            currentShows++;
            CurrentShows.Text = currentShows.ToString();
            CollectionToggle(true);
            await Task.Delay(currentInitialShowTime * 1000);
            CollectionToggle(false, true);


            //await Task.Delay(300);
            //parentPanel.Controls.Clear();
            //IsGameOver.Enabled = true;
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
                await Task.Delay(currentInitialShowTime * 1000);
                CollectionToggle(false, true);
                Card currentExtremeCard = (Card)parentPanel.Controls[random.Next(parentPanel.Controls.Count)];
                ExtremeCardName.Text = isGodeMode ?
                    currentExtremeCard.Name.Split(currentExtremeCard.Name[currentExtremeCard.Name.Length - 1])[0] : "backBlack";
                Console.WriteLine(ExtremeCardName);
                timer.Start();
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

        // RESTART | SHUFFLE
        private void ButtonRestart_Click(object sender, EventArgs e)
        {
            labelMovesValue.Text = "0";
            labelShowsValue.Text = "0";
            labelHintsValue.Text = "0";
            buttonStart.Text = "Start";
            buttonStart.Image = Resources.playSmall;
            buttonStartText = "Start";
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
            parentPanel.Controls.Clear();
            CollectionInit(currentDiffColSize, currentDiffWidth, currentDiffHeight, currentDiffScale);
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

        private void LabelMovesValue_TextChanged(object sender, EventArgs e)
        {
            labelMovesValue.Text = CurrentMoves.Text;
        }

        private void LabelShowsValue_TextChanged(object sender, EventArgs e)
        {
            labelShowsValue.Text = CurrentShows.Text;
        }

        private void LabelExtremeCard_TextChanged(object sender, EventArgs e)
        {
            pictureBoxExtreme.BackgroundImage = isGodeMode ?
                (Image)Resources.ResourceManager.GetObject(ExtremeCardName.Text) : Resources.backBlack;
            pictureBoxExtreme.BackgroundImageLayout = ImageLayout.Zoom;
        }

        public Timer raiseScore;
    }
}

