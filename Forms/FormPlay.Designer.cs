namespace Profile.Forms
{
    partial class FormPlay
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormPlay));
            this.parentPanel = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.panelTimerContainer = new System.Windows.Forms.Panel();
            this.showTimeout = new System.Windows.Forms.ComboBox();
            this.labelTimeShow = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.timerCardFlip = new System.Windows.Forms.Timer(this.components);
            this.panelWrapper = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelMainContainer = new System.Windows.Forms.Panel();
            this.panelSide = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.labelHintsValue = new System.Windows.Forms.Label();
            this.labelHintsKey = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.labelDifficultyValue = new System.Windows.Forms.Label();
            this.labelDifficultyKey = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.labelShowsValue = new System.Windows.Forms.Label();
            this.labelShowsKey = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.labelMovesValue = new System.Windows.Forms.Label();
            this.labelMovesKey = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelButtonsContainer = new System.Windows.Forms.Panel();
            this.panelShuffle = new System.Windows.Forms.Panel();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.panelButtonsSubContainer = new System.Windows.Forms.Panel();
            this.panelShow = new System.Windows.Forms.Panel();
            this.buttonShow = new System.Windows.Forms.Button();
            this.panelPlay = new System.Windows.Forms.Panel();
            this.buttonStart = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.panelButtons.SuspendLayout();
            this.panelTimerContainer.SuspendLayout();
            this.panelWrapper.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panelMainContainer.SuspendLayout();
            this.panelSide.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelButtonsContainer.SuspendLayout();
            this.panelShuffle.SuspendLayout();
            this.panelButtonsSubContainer.SuspendLayout();
            this.panelShow.SuspendLayout();
            this.panelPlay.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = false;
            // 
            // parentPanel
            // 
            this.parentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parentPanel.Location = new System.Drawing.Point(0, 94);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.parentPanel.MaximumSize = new System.Drawing.Size(1175, 850);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parentPanel.Size = new System.Drawing.Size(1175, 846);
            this.parentPanel.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panelButtons.Controls.Add(this.panelTimerContainer);
            this.panelButtons.Controls.Add(this.labelTimer);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelButtons.MaximumSize = new System.Drawing.Size(1172, 70);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1172, 70);
            this.panelButtons.TabIndex = 6;
            // 
            // panelTimerContainer
            // 
            this.panelTimerContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelTimerContainer.Controls.Add(this.showTimeout);
            this.panelTimerContainer.Controls.Add(this.labelTimeShow);
            this.panelTimerContainer.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelTimerContainer.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panelTimerContainer.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelTimerContainer.Location = new System.Drawing.Point(217, 0);
            this.panelTimerContainer.Margin = new System.Windows.Forms.Padding(0);
            this.panelTimerContainer.MaximumSize = new System.Drawing.Size(600, 70);
            this.panelTimerContainer.Name = "panelTimerContainer";
            this.panelTimerContainer.Padding = new System.Windows.Forms.Padding(5);
            this.panelTimerContainer.Size = new System.Drawing.Size(471, 70);
            this.panelTimerContainer.TabIndex = 6;
            // 
            // showTimeout
            // 
            this.showTimeout.BackColor = System.Drawing.SystemColors.Highlight;
            this.showTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTimeout.Dock = System.Windows.Forms.DockStyle.Right;
            this.showTimeout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.showTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTimeout.DropDownWidth = 78;
            this.showTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showTimeout.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.showTimeout.ForeColor = System.Drawing.Color.Gainsboro;
            this.showTimeout.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.showTimeout.ItemHeight = 42;
            this.showTimeout.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "20 sec",
            "40 sec",
            "80 sec",
            "120 sec"});
            this.showTimeout.Location = new System.Drawing.Point(326, 5);
            this.showTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.showTimeout.MaximumSize = new System.Drawing.Size(500, 0);
            this.showTimeout.Name = "showTimeout";
            this.showTimeout.Size = new System.Drawing.Size(140, 48);
            this.showTimeout.TabIndex = 8;
            this.showTimeout.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ShowTimeout_DrawItem);
            this.showTimeout.SelectedIndexChanged += new System.EventHandler(this.ShowTimeout_SelectedIndexChanged);
            this.showTimeout.EnabledChanged += new System.EventHandler(this.ShowTimeout_EnabledChanged);
            // 
            // labelTimeShow
            // 
            this.labelTimeShow.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.labelTimeShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimeShow.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelTimeShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTimeShow.Image = ((System.Drawing.Image)(resources.GetObject("labelTimeShow.Image")));
            this.labelTimeShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelTimeShow.Location = new System.Drawing.Point(5, 5);
            this.labelTimeShow.Margin = new System.Windows.Forms.Padding(0);
            this.labelTimeShow.Name = "labelTimeShow";
            this.labelTimeShow.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.labelTimeShow.Size = new System.Drawing.Size(294, 60);
            this.labelTimeShow.TabIndex = 5;
            this.labelTimeShow.Text = " Pair Show TIme";
            this.labelTimeShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimer.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelTimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTimer.Location = new System.Drawing.Point(0, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelTimer.Size = new System.Drawing.Size(217, 70);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelWrapper
            // 
            this.panelWrapper.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelWrapper.Controls.Add(this.flowLayoutPanel1);
            this.panelWrapper.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelWrapper.ForeColor = System.Drawing.Color.Coral;
            this.panelWrapper.Location = new System.Drawing.Point(0, 0);
            this.panelWrapper.Name = "panelWrapper";
            this.panelWrapper.Padding = new System.Windows.Forms.Padding(20);
            this.panelWrapper.Size = new System.Drawing.Size(1593, 988);
            this.panelWrapper.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panelMainContainer);
            this.flowLayoutPanel1.Controls.Add(this.panelSide);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1553, 948);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panelMainContainer
            // 
            this.panelMainContainer.Controls.Add(this.panelButtons);
            this.panelMainContainer.Controls.Add(this.parentPanel);
            this.panelMainContainer.Location = new System.Drawing.Point(3, 3);
            this.panelMainContainer.Name = "panelMainContainer";
            this.panelMainContainer.Size = new System.Drawing.Size(1175, 940);
            this.panelMainContainer.TabIndex = 7;
            // 
            // panelSide
            // 
            this.panelSide.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelSide.Controls.Add(this.panel1);
            this.panelSide.Controls.Add(this.panelButtonsContainer);
            this.panelSide.Dock = System.Windows.Forms.DockStyle.Right;
            this.panelSide.Location = new System.Drawing.Point(1201, 3);
            this.panelSide.Margin = new System.Windows.Forms.Padding(20, 3, 3, 3);
            this.panelSide.Name = "panelSide";
            this.panelSide.Size = new System.Drawing.Size(345, 940);
            this.panelSide.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 342);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(345, 598);
            this.panel1.TabIndex = 10;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.panel7);
            this.panel3.Controls.Add(this.panel6);
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(20, 253);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(20);
            this.panel3.Size = new System.Drawing.Size(305, 325);
            this.panel3.TabIndex = 0;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel5.Controls.Add(this.labelHintsValue);
            this.panel5.Controls.Add(this.labelHintsKey);
            this.panel5.Location = new System.Drawing.Point(20, 170);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(265, 60);
            this.panel5.TabIndex = 2;
            // 
            // labelHintsValue
            // 
            this.labelHintsValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelHintsValue.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelHintsValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHintsValue.Location = new System.Drawing.Point(120, 0);
            this.labelHintsValue.Name = "labelHintsValue";
            this.labelHintsValue.Size = new System.Drawing.Size(145, 60);
            this.labelHintsValue.TabIndex = 2;
            this.labelHintsValue.Text = "0";
            this.labelHintsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelHintsKey
            // 
            this.labelHintsKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelHintsKey.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelHintsKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHintsKey.Location = new System.Drawing.Point(0, 0);
            this.labelHintsKey.Name = "labelHintsKey";
            this.labelHintsKey.Size = new System.Drawing.Size(109, 60);
            this.labelHintsKey.TabIndex = 1;
            this.labelHintsKey.Text = "Hints:";
            this.labelHintsKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel7.Controls.Add(this.labelDifficultyValue);
            this.panel7.Controls.Add(this.labelDifficultyKey);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(20, 245);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(265, 60);
            this.panel7.TabIndex = 1;
            // 
            // labelDifficultyValue
            // 
            this.labelDifficultyValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelDifficultyValue.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelDifficultyValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDifficultyValue.Location = new System.Drawing.Point(143, 0);
            this.labelDifficultyValue.Name = "labelDifficultyValue";
            this.labelDifficultyValue.Size = new System.Drawing.Size(122, 60);
            this.labelDifficultyValue.TabIndex = 2;
            this.labelDifficultyValue.Text = "Extreme";
            this.labelDifficultyValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelDifficultyKey
            // 
            this.labelDifficultyKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelDifficultyKey.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelDifficultyKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelDifficultyKey.Location = new System.Drawing.Point(0, 0);
            this.labelDifficultyKey.Name = "labelDifficultyKey";
            this.labelDifficultyKey.Size = new System.Drawing.Size(142, 60);
            this.labelDifficultyKey.TabIndex = 1;
            this.labelDifficultyKey.Text = "Difficulty:";
            this.labelDifficultyKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel6.Controls.Add(this.labelShowsValue);
            this.panel6.Controls.Add(this.labelShowsKey);
            this.panel6.Location = new System.Drawing.Point(20, 95);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(265, 60);
            this.panel6.TabIndex = 1;
            // 
            // labelShowsValue
            // 
            this.labelShowsValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelShowsValue.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelShowsValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelShowsValue.Location = new System.Drawing.Point(120, 0);
            this.labelShowsValue.Name = "labelShowsValue";
            this.labelShowsValue.Size = new System.Drawing.Size(145, 60);
            this.labelShowsValue.TabIndex = 3;
            this.labelShowsValue.Text = "0";
            this.labelShowsValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelShowsKey
            // 
            this.labelShowsKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelShowsKey.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelShowsKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelShowsKey.Location = new System.Drawing.Point(0, 0);
            this.labelShowsKey.Name = "labelShowsKey";
            this.labelShowsKey.Size = new System.Drawing.Size(109, 60);
            this.labelShowsKey.TabIndex = 2;
            this.labelShowsKey.Text = "Shows:";
            this.labelShowsKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.panel4.Controls.Add(this.labelMovesValue);
            this.panel4.Controls.Add(this.labelMovesKey);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(20, 20);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(265, 60);
            this.panel4.TabIndex = 0;
            // 
            // labelMovesValue
            // 
            this.labelMovesValue.Dock = System.Windows.Forms.DockStyle.Right;
            this.labelMovesValue.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelMovesValue.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMovesValue.Location = new System.Drawing.Point(120, 0);
            this.labelMovesValue.Name = "labelMovesValue";
            this.labelMovesValue.Size = new System.Drawing.Size(145, 60);
            this.labelMovesValue.TabIndex = 1;
            this.labelMovesValue.Text = this.CurrentMoves;
            this.labelMovesValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // labelMovesKey
            // 
            this.labelMovesKey.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelMovesKey.Font = new System.Drawing.Font("Tw Cen MT Condensed", 16F, System.Drawing.FontStyle.Bold);
            this.labelMovesKey.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelMovesKey.Location = new System.Drawing.Point(0, 0);
            this.labelMovesKey.Name = "labelMovesKey";
            this.labelMovesKey.Size = new System.Drawing.Size(109, 60);
            this.labelMovesKey.TabIndex = 0;
            this.labelMovesKey.Text = "Moves:";
            this.labelMovesKey.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel2
            // 
            this.panel2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(45, 0, 45, 0);
            this.panel2.Size = new System.Drawing.Size(305, 215);
            this.panel2.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.pictureBox1.BackgroundImage = global::Profile.Properties.Resources.trophy;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureBox1.Location = new System.Drawing.Point(45, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 215);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panelButtonsContainer
            // 
            this.panelButtonsContainer.Controls.Add(this.panelShuffle);
            this.panelButtonsContainer.Controls.Add(this.panelButtonsSubContainer);
            this.panelButtonsContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonsContainer.Location = new System.Drawing.Point(0, 0);
            this.panelButtonsContainer.Name = "panelButtonsContainer";
            this.panelButtonsContainer.Size = new System.Drawing.Size(345, 320);
            this.panelButtonsContainer.TabIndex = 9;
            // 
            // panelShuffle
            // 
            this.panelShuffle.Controls.Add(this.buttonRestart);
            this.panelShuffle.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShuffle.Location = new System.Drawing.Point(0, 220);
            this.panelShuffle.Name = "panelShuffle";
            this.panelShuffle.Size = new System.Drawing.Size(345, 100);
            this.panelShuffle.TabIndex = 8;
            // 
            // buttonRestart
            // 
            this.buttonRestart.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(184)))), ((int)(((byte)(245)))));
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestart.Image = global::Profile.Properties.Resources.shuffleSmall;
            this.buttonRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestart.Location = new System.Drawing.Point(0, 0);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonRestart.Size = new System.Drawing.Size(345, 100);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Shuffle";
            this.buttonRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestart.UseVisualStyleBackColor = false;
            this.buttonRestart.EnabledChanged += new System.EventHandler(this.ButtonRestart_EnabledChanged);
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            this.buttonRestart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRestart_Paint);
            // 
            // panelButtonsSubContainer
            // 
            this.panelButtonsSubContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelButtonsSubContainer.Controls.Add(this.panelShow);
            this.panelButtonsSubContainer.Controls.Add(this.panelPlay);
            this.panelButtonsSubContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtonsSubContainer.Location = new System.Drawing.Point(0, 0);
            this.panelButtonsSubContainer.Name = "panelButtonsSubContainer";
            this.panelButtonsSubContainer.Size = new System.Drawing.Size(345, 210);
            this.panelButtonsSubContainer.TabIndex = 8;
            // 
            // panelShow
            // 
            this.panelShow.Controls.Add(this.buttonShow);
            this.panelShow.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelShow.Location = new System.Drawing.Point(0, 110);
            this.panelShow.Name = "panelShow";
            this.panelShow.Size = new System.Drawing.Size(345, 100);
            this.panelShow.TabIndex = 8;
            // 
            // buttonShow
            // 
            this.buttonShow.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Enabled = false;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.buttonShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(184)))), ((int)(((byte)(245)))));
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShow.Image = global::Profile.Properties.Resources.showSmall;
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(0, 0);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(5);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonShow.Size = new System.Drawing.Size(345, 100);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShow.UseVisualStyleBackColor = false;
            this.buttonShow.EnabledChanged += new System.EventHandler(this.ButtonShow_EnabledChanged);
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            this.buttonShow.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonShow_Paint);
            // 
            // panelPlay
            // 
            this.panelPlay.Controls.Add(this.buttonStart);
            this.panelPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelPlay.Location = new System.Drawing.Point(0, 0);
            this.panelPlay.Name = "panelPlay";
            this.panelPlay.Size = new System.Drawing.Size(345, 100);
            this.panelPlay.TabIndex = 7;
            // 
            // buttonStart
            // 
            this.buttonStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(132)))), ((int)(((byte)(209)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(67)))), ((int)(((byte)(184)))), ((int)(((byte)(245)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStart.Image = global::Profile.Properties.Resources.playSmall;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(0, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonStart.Size = new System.Drawing.Size(345, 100);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Play";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStart.UseVisualStyleBackColor = false;
            this.buttonStart.EnabledChanged += new System.EventHandler(this.ButtonStart_EnabledChanged);
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.buttonStart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonStart_Paint);
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1593, 988);
            this.Controls.Add(this.panelWrapper);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1470, 910);
            this.Name = "FormPlay";
            this.Text = "Play";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.panelButtons.ResumeLayout(false);
            this.panelTimerContainer.ResumeLayout(false);
            this.panelWrapper.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panelMainContainer.ResumeLayout(false);
            this.panelSide.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelButtonsContainer.ResumeLayout(false);
            this.panelShuffle.ResumeLayout(false);
            this.panelButtonsSubContainer.ResumeLayout(false);
            this.panelShow.ResumeLayout(false);
            this.panelPlay.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShow;
        public System.Windows.Forms.Panel parentPanel;
        public System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Timer timerCardFlip;
        private System.Windows.Forms.Panel panelWrapper;
        public System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimer;
        public System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ComboBox showTimeout;
        private System.Windows.Forms.Panel panelMainContainer;
        private System.Windows.Forms.Panel panelTimerContainer;
        private System.Windows.Forms.Label labelTimeShow;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panelButtonsSubContainer;
        private System.Windows.Forms.Panel panelShuffle;
        private System.Windows.Forms.Panel panelShow;
        private System.Windows.Forms.Panel panelPlay;
        private System.Windows.Forms.Panel panelButtonsContainer;
        private System.Windows.Forms.Panel panelSide;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label labelHintsValue;
        private System.Windows.Forms.Label labelHintsKey;
        public System.Windows.Forms.Label labelDifficultyValue;
        private System.Windows.Forms.Label labelDifficultyKey;
        public System.Windows.Forms.Label labelShowsValue;
        private System.Windows.Forms.Label labelShowsKey;
        public System.Windows.Forms.Label labelMovesValue;
        private System.Windows.Forms.Label labelMovesKey;
    }
}

