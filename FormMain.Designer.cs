namespace Profile
{
    partial class FormMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.panelMenu = new System.Windows.Forms.Panel();
            this.buttonRanking = new System.Windows.Forms.Button();
            this.buttonSettings = new System.Windows.Forms.Button();
            this.buttonPlay = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.labelMemory = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.buttonTimes = new System.Windows.Forms.Button();
            this.labelTitle = new System.Windows.Forms.Label();
            this.panelMain = new System.Windows.Forms.Panel();
            this.SignUp = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSignup = new System.Windows.Forms.Label();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.labelConfirmPassword = new System.Windows.Forms.Label();
            this.textBoxConfirmPassword = new System.Windows.Forms.TextBox();
            this.checkBoxShowPassword = new System.Windows.Forms.CheckBox();
            this.buttonSignup = new System.Windows.Forms.Button();
            this.buttonClear = new System.Windows.Forms.Button();
            this.labelHaveAcc = new System.Windows.Forms.Label();
            this.labelChangeToSignin = new System.Windows.Forms.Label();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SignIn = new System.Windows.Forms.FlowLayoutPanel();
            this.labelSignin = new System.Windows.Forms.Label();
            this.flowLayoutPanel5 = new System.Windows.Forms.FlowLayoutPanel();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.panelMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panelTitleBar.SuspendLayout();
            this.panelMain.SuspendLayout();
            this.SignUp.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SignIn.SuspendLayout();
            this.flowLayoutPanel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = false;
            // 
            // panelMenu
            // 
            this.panelMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelMenu.Controls.Add(this.buttonRanking);
            this.panelMenu.Controls.Add(this.buttonSettings);
            this.panelMenu.Controls.Add(this.buttonPlay);
            this.panelMenu.Controls.Add(this.panelLogo);
            this.panelMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelMenu.Location = new System.Drawing.Point(0, 0);
            this.panelMenu.Name = "panelMenu";
            this.panelMenu.Size = new System.Drawing.Size(270, 1069);
            this.panelMenu.TabIndex = 0;
            // 
            // buttonRanking
            // 
            this.buttonRanking.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonRanking.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRanking.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonRanking.FlatAppearance.BorderSize = 0;
            this.buttonRanking.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRanking.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonRanking.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRanking.Image = ((System.Drawing.Image)(resources.GetObject("buttonRanking.Image")));
            this.buttonRanking.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRanking.Location = new System.Drawing.Point(0, 270);
            this.buttonRanking.Name = "buttonRanking";
            this.buttonRanking.Padding = new System.Windows.Forms.Padding(10);
            this.buttonRanking.Size = new System.Drawing.Size(270, 90);
            this.buttonRanking.TabIndex = 2;
            this.buttonRanking.Text = "  Ranking";
            this.buttonRanking.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRanking.UseVisualStyleBackColor = true;
            this.buttonRanking.DockChanged += new System.EventHandler(this.ButtonRanking_EnabledChanged);
            this.buttonRanking.EnabledChanged += new System.EventHandler(this.ButtonRanking_EnabledChanged);
            this.buttonRanking.Click += new System.EventHandler(this.ButtonRanking_Click);
            this.buttonRanking.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRanking_Paint);
            // 
            // buttonSettings
            // 
            this.buttonSettings.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSettings.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonSettings.FlatAppearance.BorderSize = 0;
            this.buttonSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSettings.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSettings.Image = ((System.Drawing.Image)(resources.GetObject("buttonSettings.Image")));
            this.buttonSettings.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonSettings.Location = new System.Drawing.Point(0, 180);
            this.buttonSettings.Name = "buttonSettings";
            this.buttonSettings.Padding = new System.Windows.Forms.Padding(10);
            this.buttonSettings.Size = new System.Drawing.Size(270, 90);
            this.buttonSettings.TabIndex = 1;
            this.buttonSettings.Text = "  Settings";
            this.buttonSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonSettings.UseVisualStyleBackColor = true;
            this.buttonSettings.EnabledChanged += new System.EventHandler(this.ButtonSettings_EnabledChanged);
            this.buttonSettings.Click += new System.EventHandler(this.ButtonSettings_Click);
            this.buttonSettings.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonSettings_Paint);
            // 
            // buttonPlay
            // 
            this.buttonPlay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.buttonPlay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPlay.FlatAppearance.BorderSize = 0;
            this.buttonPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonPlay.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonPlay.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonPlay.Image = ((System.Drawing.Image)(resources.GetObject("buttonPlay.Image")));
            this.buttonPlay.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonPlay.Location = new System.Drawing.Point(0, 90);
            this.buttonPlay.Name = "buttonPlay";
            this.buttonPlay.Padding = new System.Windows.Forms.Padding(10);
            this.buttonPlay.Size = new System.Drawing.Size(270, 90);
            this.buttonPlay.TabIndex = 0;
            this.buttonPlay.Text = "  Play";
            this.buttonPlay.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonPlay.UseVisualStyleBackColor = true;
            this.buttonPlay.EnabledChanged += new System.EventHandler(this.ButtonPlay_EnabledChanged);
            this.buttonPlay.Click += new System.EventHandler(this.ButtonPlay_Click);
            this.buttonPlay.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonPlay_Paint);
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.pictureBox1);
            this.panelLogo.Controls.Add(this.labelMemory);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.ForeColor = System.Drawing.Color.Gainsboro;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Padding = new System.Windows.Forms.Padding(5);
            this.panelLogo.Size = new System.Drawing.Size(270, 90);
            this.panelLogo.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox1.ErrorImage = null;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = null;
            this.pictureBox1.Location = new System.Drawing.Point(5, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Padding = new System.Windows.Forms.Padding(10, 16, 10, 16);
            this.pictureBox1.Size = new System.Drawing.Size(64, 80);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // labelMemory
            // 
            this.labelMemory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelMemory.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelMemory.Location = new System.Drawing.Point(5, 5);
            this.labelMemory.Name = "labelMemory";
            this.labelMemory.Size = new System.Drawing.Size(260, 80);
            this.labelMemory.TabIndex = 0;
            this.labelMemory.Text = "   MEMORY";
            this.labelMemory.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.panelTitleBar.Controls.Add(this.buttonTimes);
            this.panelTitleBar.Controls.Add(this.labelTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(270, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(0);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1588, 90);
            this.panelTitleBar.TabIndex = 1;
            // 
            // buttonTimes
            // 
            this.buttonTimes.BackgroundImage = global::Profile.Properties.Resources.logout;
            this.buttonTimes.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.buttonTimes.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonTimes.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonTimes.FlatAppearance.BorderSize = 0;
            this.buttonTimes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTimes.Location = new System.Drawing.Point(0, 0);
            this.buttonTimes.Name = "buttonTimes";
            this.buttonTimes.Size = new System.Drawing.Size(90, 90);
            this.buttonTimes.TabIndex = 1;
            this.buttonTimes.UseVisualStyleBackColor = true;
            this.buttonTimes.Click += new System.EventHandler(this.ButtonTimes_Click);
            // 
            // labelTitle
            // 
            this.labelTitle.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTitle.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelTitle.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTitle.Location = new System.Drawing.Point(0, 0);
            this.labelTitle.Margin = new System.Windows.Forms.Padding(0);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(1588, 90);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "HOME";
            this.labelTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panelMain
            // 
            this.panelMain.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panelMain.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelMain.Controls.Add(this.SignUp);
            this.panelMain.Controls.Add(this.flowLayoutPanel1);
            this.panelMain.Controls.Add(this.SignIn);
            this.panelMain.Location = new System.Drawing.Point(270, 90);
            this.panelMain.Margin = new System.Windows.Forms.Padding(0);
            this.panelMain.Name = "panelMain";
            this.panelMain.Size = new System.Drawing.Size(1588, 979);
            this.panelMain.TabIndex = 2;
            // 
            // SignUp
            // 
            this.SignUp.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.SignUp.Controls.Add(this.labelSignup);
            this.SignUp.Controls.Add(this.flowLayoutPanel2);
            this.SignUp.Location = new System.Drawing.Point(570, 290);
            this.SignUp.Name = "SignUp";
            this.SignUp.Size = new System.Drawing.Size(450, 660);
            this.SignUp.TabIndex = 16;
            // 
            // labelSignup
            // 
            this.labelSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.labelSignup.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSignup.Location = new System.Drawing.Point(3, 0);
            this.labelSignup.Name = "labelSignup";
            this.labelSignup.Size = new System.Drawing.Size(450, 70);
            this.labelSignup.TabIndex = 3;
            this.labelSignup.Text = "SIGN UP";
            this.labelSignup.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.flowLayoutPanel2.Controls.Add(this.labelUsername);
            this.flowLayoutPanel2.Controls.Add(this.textBoxUsername);
            this.flowLayoutPanel2.Controls.Add(this.labelPassword);
            this.flowLayoutPanel2.Controls.Add(this.textBoxPassword);
            this.flowLayoutPanel2.Controls.Add(this.labelConfirmPassword);
            this.flowLayoutPanel2.Controls.Add(this.textBoxConfirmPassword);
            this.flowLayoutPanel2.Controls.Add(this.checkBoxShowPassword);
            this.flowLayoutPanel2.Controls.Add(this.buttonSignup);
            this.flowLayoutPanel2.Controls.Add(this.buttonClear);
            this.flowLayoutPanel2.Controls.Add(this.labelHaveAcc);
            this.flowLayoutPanel2.Controls.Add(this.labelChangeToSignin);
            this.flowLayoutPanel2.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel2.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel2.Size = new System.Drawing.Size(450, 590);
            this.flowLayoutPanel2.TabIndex = 15;
            // 
            // labelUsername
            // 
            this.labelUsername.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelUsername.AutoSize = true;
            this.labelUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelUsername.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelUsername.Location = new System.Drawing.Point(20, 20);
            this.labelUsername.Margin = new System.Windows.Forms.Padding(0);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(144, 42);
            this.labelUsername.TabIndex = 4;
            this.labelUsername.Text = "Username";
            this.labelUsername.Click += new System.EventHandler(this.labelUsername_Click);
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxUsername.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxUsername.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxUsername.Location = new System.Drawing.Point(20, 62);
            this.textBoxUsername.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(410, 46);
            this.textBoxUsername.TabIndex = 6;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelPassword.Location = new System.Drawing.Point(20, 128);
            this.labelPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(136, 42);
            this.labelPassword.TabIndex = 5;
            this.labelPassword.Text = "Password";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxPassword.Location = new System.Drawing.Point(20, 170);
            this.textBoxPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '●';
            this.textBoxPassword.Size = new System.Drawing.Size(410, 46);
            this.textBoxPassword.TabIndex = 7;
            // 
            // labelConfirmPassword
            // 
            this.labelConfirmPassword.AutoSize = true;
            this.labelConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.labelConfirmPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelConfirmPassword.Location = new System.Drawing.Point(20, 236);
            this.labelConfirmPassword.Margin = new System.Windows.Forms.Padding(0);
            this.labelConfirmPassword.Name = "labelConfirmPassword";
            this.labelConfirmPassword.Size = new System.Drawing.Size(245, 42);
            this.labelConfirmPassword.TabIndex = 8;
            this.labelConfirmPassword.Text = "Confirm Password";
            // 
            // textBoxConfirmPassword
            // 
            this.textBoxConfirmPassword.BackColor = System.Drawing.Color.Gainsboro;
            this.textBoxConfirmPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBoxConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBoxConfirmPassword.Location = new System.Drawing.Point(20, 278);
            this.textBoxConfirmPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBoxConfirmPassword.Name = "textBoxConfirmPassword";
            this.textBoxConfirmPassword.PasswordChar = '●';
            this.textBoxConfirmPassword.Size = new System.Drawing.Size(410, 46);
            this.textBoxConfirmPassword.TabIndex = 9;
            // 
            // checkBoxShowPassword
            // 
            this.checkBoxShowPassword.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPassword.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxShowPassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxShowPassword.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBoxShowPassword.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBoxShowPassword.Location = new System.Drawing.Point(20, 344);
            this.checkBoxShowPassword.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.checkBoxShowPassword.Name = "checkBoxShowPassword";
            this.checkBoxShowPassword.Size = new System.Drawing.Size(410, 32);
            this.checkBoxShowPassword.TabIndex = 10;
            this.checkBoxShowPassword.Text = "Show Password";
            this.checkBoxShowPassword.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxShowPassword.UseVisualStyleBackColor = true;
            this.checkBoxShowPassword.CheckedChanged += new System.EventHandler(this.CheckBoxShowPassword_CheckedChanged);
            // 
            // buttonSignup
            // 
            this.buttonSignup.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonSignup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSignup.FlatAppearance.BorderSize = 0;
            this.buttonSignup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSignup.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonSignup.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonSignup.Location = new System.Drawing.Point(20, 386);
            this.buttonSignup.Margin = new System.Windows.Forms.Padding(0);
            this.buttonSignup.Name = "buttonSignup";
            this.buttonSignup.Size = new System.Drawing.Size(410, 60);
            this.buttonSignup.TabIndex = 11;
            this.buttonSignup.Text = "Sign up";
            this.buttonSignup.UseVisualStyleBackColor = false;
            this.buttonSignup.Click += new System.EventHandler(this.ButtonSignup_Click);
            // 
            // buttonClear
            // 
            this.buttonClear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.buttonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonClear.FlatAppearance.BorderSize = 3;
            this.buttonClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClear.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonClear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.buttonClear.Location = new System.Drawing.Point(20, 456);
            this.buttonClear.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(410, 60);
            this.buttonClear.TabIndex = 12;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = false;
            this.buttonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // labelHaveAcc
            // 
            this.labelHaveAcc.AutoSize = true;
            this.labelHaveAcc.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.labelHaveAcc.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelHaveAcc.Location = new System.Drawing.Point(20, 526);
            this.labelHaveAcc.Margin = new System.Windows.Forms.Padding(0);
            this.labelHaveAcc.Name = "labelHaveAcc";
            this.labelHaveAcc.Size = new System.Drawing.Size(229, 28);
            this.labelHaveAcc.TabIndex = 13;
            this.labelHaveAcc.Text = "Already have an account?";
            this.labelHaveAcc.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelChangeToSignin
            // 
            this.labelChangeToSignin.AutoSize = true;
            this.labelChangeToSignin.Cursor = System.Windows.Forms.Cursors.Hand;
            this.labelChangeToSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.labelChangeToSignin.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.labelChangeToSignin.Location = new System.Drawing.Point(249, 526);
            this.labelChangeToSignin.Margin = new System.Windows.Forms.Padding(0);
            this.labelChangeToSignin.Name = "labelChangeToSignin";
            this.labelChangeToSignin.Size = new System.Drawing.Size(170, 32);
            this.labelChangeToSignin.TabIndex = 14;
            this.labelChangeToSignin.Text = "Back to SIGN IN";
            this.labelChangeToSignin.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.labelChangeToSignin.Click += new System.EventHandler(this.LabelChangeToSignin_Click);
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.pictureBox2);
            this.flowLayoutPanel1.Controls.Add(this.label1);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(362, 29);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(870, 230);
            this.flowLayoutPanel1.TabIndex = 2;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::Profile.Properties.Resources.cardsBlueMain;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Left;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(230, 230);
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 92F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(192)))), ((int)(((byte)(251)))));
            this.label1.Location = new System.Drawing.Point(230, 0);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(640, 230);
            this.label1.TabIndex = 1;
            this.label1.Text = "Memory";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // SignIn
            // 
            this.SignIn.Controls.Add(this.labelSignin);
            this.SignIn.Controls.Add(this.flowLayoutPanel5);
            this.SignIn.Location = new System.Drawing.Point(570, 290);
            this.SignIn.Name = "SignIn";
            this.SignIn.Size = new System.Drawing.Size(450, 546);
            this.SignIn.TabIndex = 17;
            this.SignIn.Visible = false;
            // 
            // labelSignin
            // 
            this.labelSignin.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.labelSignin.Font = new System.Drawing.Font("Tw Cen MT Condensed", 24F, System.Drawing.FontStyle.Bold);
            this.labelSignin.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSignin.Location = new System.Drawing.Point(3, 0);
            this.labelSignin.Name = "labelSignin";
            this.labelSignin.Size = new System.Drawing.Size(450, 70);
            this.labelSignin.TabIndex = 3;
            this.labelSignin.Text = "SIGN IN";
            this.labelSignin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // flowLayoutPanel5
            // 
            this.flowLayoutPanel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.flowLayoutPanel5.Controls.Add(this.label5);
            this.flowLayoutPanel5.Controls.Add(this.textBox1);
            this.flowLayoutPanel5.Controls.Add(this.label6);
            this.flowLayoutPanel5.Controls.Add(this.textBox2);
            this.flowLayoutPanel5.Controls.Add(this.checkBox1);
            this.flowLayoutPanel5.Controls.Add(this.button1);
            this.flowLayoutPanel5.Controls.Add(this.button2);
            this.flowLayoutPanel5.Controls.Add(this.label8);
            this.flowLayoutPanel5.Controls.Add(this.label9);
            this.flowLayoutPanel5.Location = new System.Drawing.Point(0, 70);
            this.flowLayoutPanel5.Margin = new System.Windows.Forms.Padding(0);
            this.flowLayoutPanel5.Name = "flowLayoutPanel5";
            this.flowLayoutPanel5.Padding = new System.Windows.Forms.Padding(20);
            this.flowLayoutPanel5.Size = new System.Drawing.Size(450, 476);
            this.flowLayoutPanel5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label5.ForeColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(20, 20);
            this.label5.Margin = new System.Windows.Forms.Padding(0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 42);
            this.label5.TabIndex = 4;
            this.label5.Text = "Username";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBox1.Location = new System.Drawing.Point(20, 62);
            this.textBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(410, 46);
            this.textBox1.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label6.ForeColor = System.Drawing.Color.Gainsboro;
            this.label6.Location = new System.Drawing.Point(20, 128);
            this.label6.Margin = new System.Windows.Forms.Padding(0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(136, 42);
            this.label6.TabIndex = 5;
            this.label6.Text = "Password";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.Gainsboro;
            this.textBox2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.textBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.textBox2.Location = new System.Drawing.Point(20, 170);
            this.textBox2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.textBox2.Name = "textBox2";
            this.textBox2.PasswordChar = '●';
            this.textBox2.Size = new System.Drawing.Size(410, 46);
            this.textBox2.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBox1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.checkBox1.ForeColor = System.Drawing.Color.Gainsboro;
            this.checkBox1.Location = new System.Drawing.Point(20, 236);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(0, 0, 0, 10);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(410, 32);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "Show Password";
            this.checkBox1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.Color.Gainsboro;
            this.button1.Location = new System.Drawing.Point(20, 278);
            this.button1.Margin = new System.Windows.Forms.Padding(0);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(410, 60);
            this.button1.TabIndex = 11;
            this.button1.Text = "Sign in";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.FlatAppearance.BorderSize = 3;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.button2.Location = new System.Drawing.Point(20, 348);
            this.button2.Margin = new System.Windows.Forms.Padding(0, 10, 0, 10);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(410, 60);
            this.button2.TabIndex = 12;
            this.button2.Text = "Clear";
            this.button2.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tw Cen MT Condensed", 12F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Gainsboro;
            this.label8.Location = new System.Drawing.Point(20, 418);
            this.label8.Margin = new System.Windows.Forms.Padding(0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(209, 28);
            this.label8.TabIndex = 13;
            this.label8.Text = "Don\'t have an account?";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label9.Font = new System.Drawing.Font("Tw Cen MT Condensed", 14F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(150)))), ((int)(((byte)(243)))));
            this.label9.Location = new System.Drawing.Point(229, 418);
            this.label9.Margin = new System.Windows.Forms.Padding(0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(156, 32);
            this.label9.TabIndex = 14;
            this.label9.Text = "Go to SIGN UP";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label9.Click += new System.EventHandler(this.LabelChangeToSignup_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1858, 1069);
            this.Controls.Add(this.panelMain);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(1880, 1125);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Memory";
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.panelMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panelTitleBar.ResumeLayout(false);
            this.panelMain.ResumeLayout(false);
            this.SignUp.ResumeLayout(false);
            this.flowLayoutPanel2.ResumeLayout(false);
            this.flowLayoutPanel2.PerformLayout();
            this.flowLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.SignIn.ResumeLayout(false);
            this.flowLayoutPanel5.ResumeLayout(false);
            this.flowLayoutPanel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelMenu;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Button buttonPlay;
        private System.Windows.Forms.Button buttonRanking;
        private System.Windows.Forms.Button buttonSettings;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label labelMemory;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panelMain;
        private System.Windows.Forms.Button buttonTimes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.Label labelSignup;
        private System.Windows.Forms.TextBox textBoxConfirmPassword;
        private System.Windows.Forms.Label labelConfirmPassword;
        private System.Windows.Forms.Button buttonSignup;
        private System.Windows.Forms.CheckBox checkBoxShowPassword;
        private System.Windows.Forms.Label labelChangeToSignin;
        private System.Windows.Forms.Label labelHaveAcc;
        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.FlowLayoutPanel SignUp;
        private System.Windows.Forms.FlowLayoutPanel SignIn;
        private System.Windows.Forms.Label labelSignin;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel5;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

