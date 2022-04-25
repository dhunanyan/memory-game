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
            this.buttonShow = new System.Windows.Forms.Button();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.panelButtons = new System.Windows.Forms.Panel();
            this.showTimeout = new System.Windows.Forms.ComboBox();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonShow
            // 
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonShow.Enabled = false;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShow.Location = new System.Drawing.Point(0, 0);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(0);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Size = new System.Drawing.Size(260, 56);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "ShowCards";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.EnabledChanged += new System.EventHandler(this.ButtonShow_EnabledChanged);
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            this.buttonShow.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonShow_Paint);
            // 
            // parentPanel
            // 
            this.parentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.parentPanel.Location = new System.Drawing.Point(20, 20);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(0, 20, 0, 0);
            this.parentPanel.MaximumSize = new System.Drawing.Size(1175, 850);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.parentPanel.Size = new System.Drawing.Size(1175, 850);
            this.parentPanel.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.showTimeout);
            this.panelButtons.Controls.Add(this.buttonRestart);
            this.panelButtons.Controls.Add(this.labelTimer);
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Controls.Add(this.buttonShow);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(20, 870);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelButtons.MaximumSize = new System.Drawing.Size(1172, 60);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1172, 60);
            this.panelButtons.TabIndex = 6;
            // 
            // showTimeout
            // 
            this.showTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.showTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTimeout.Dock = System.Windows.Forms.DockStyle.Left;
            this.showTimeout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.showTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTimeout.DropDownWidth = 162;
            this.showTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTimeout.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.showTimeout.ForeColor = System.Drawing.Color.Gainsboro;
            this.showTimeout.Items.AddRange(new object[] {
            "1s - ShowTime",
            "2s - ShowTime",
            "5s - ShowTime",
            "10s - ShowTime",
            "20s - ShowTime",
            "40s - ShowTime",
            "80s - ShowTime",
            "120s - ShowTime"});
            this.showTimeout.Location = new System.Drawing.Point(800, 0);
            this.showTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.showTimeout.MaximumSize = new System.Drawing.Size(500, 0);
            this.showTimeout.Name = "showTimeout";
            this.showTimeout.Size = new System.Drawing.Size(373, 58);
            this.showTimeout.TabIndex = 8;
            this.showTimeout.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ShowTimeout_DrawItem);
            this.showTimeout.SelectedIndexChanged += new System.EventHandler(this.ShowTimeout_SelectedIndexChanged);
            // 
            // buttonRestart
            // 
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestart.Location = new System.Drawing.Point(612, 0);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Size = new System.Drawing.Size(188, 56);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Shuffle";
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.EnabledChanged += new System.EventHandler(this.ButtonRestart_EnabledChanged);
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            this.buttonRestart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRestart_Paint);
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimer.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.labelTimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTimer.Location = new System.Drawing.Point(406, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelTimer.Size = new System.Drawing.Size(206, 56);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00:00";
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStart.Location = new System.Drawing.Point(260, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(146, 56);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Start";
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.EnabledChanged += new System.EventHandler(this.ButtonStart_EnabledChanged);
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.buttonStart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonStart_Paint);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelContainer.Controls.Add(this.panelButtons);
            this.panelContainer.Controls.Add(this.parentPanel);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.Color.Coral;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(1595, 958);
            this.panelContainer.TabIndex = 7;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1595, 958);
            this.Controls.Add(this.panelContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1450, 910);
            this.Name = "FormPlay";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.panelButtons.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonShow;
        public System.Windows.Forms.Panel parentPanel;
        public System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelContainer;
        public System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimer;
        public System.Windows.Forms.Button buttonRestart;
        private System.Windows.Forms.ComboBox showTimeout;
    }
}

