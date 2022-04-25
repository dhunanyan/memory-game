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
            this.panel3 = new System.Windows.Forms.Panel();
            this.showTimeout = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTimer = new System.Windows.Forms.Label();
            this.buttonRestart = new System.Windows.Forms.Button();
            this.buttonStart = new System.Windows.Forms.Button();
            this.buttonShow = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panelButtons.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panelContainer.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel7.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // parentPanel
            // 
            this.parentPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.parentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parentPanel.Location = new System.Drawing.Point(0, 80);
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
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.panel3);
            this.panelButtons.Controls.Add(this.labelTimer);
            this.panelButtons.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelButtons.Location = new System.Drawing.Point(0, 0);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelButtons.MaximumSize = new System.Drawing.Size(1172, 70);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1172, 70);
            this.panelButtons.TabIndex = 6;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.showTimeout);
            this.panel3.Controls.Add(this.label1);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(217, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MaximumSize = new System.Drawing.Size(600, 70);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(400, 66);
            this.panel3.TabIndex = 6;
            // 
            // showTimeout
            // 
            this.showTimeout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.showTimeout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTimeout.Dock = System.Windows.Forms.DockStyle.Right;
            this.showTimeout.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.showTimeout.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTimeout.DropDownWidth = 130;
            this.showTimeout.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.showTimeout.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.showTimeout.ForeColor = System.Drawing.Color.Gainsboro;
            this.showTimeout.ItemHeight = 30;
            this.showTimeout.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "20 sec",
            "40 sec",
            "80 sec",
            "120 sec"});
            this.showTimeout.Location = new System.Drawing.Point(256, 5);
            this.showTimeout.Margin = new System.Windows.Forms.Padding(0);
            this.showTimeout.MaximumSize = new System.Drawing.Size(500, 0);
            this.showTimeout.Name = "showTimeout";
            this.showTimeout.Size = new System.Drawing.Size(139, 36);
            this.showTimeout.TabIndex = 8;
            this.showTimeout.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.ShowTimeout_DrawItem);
            this.showTimeout.SelectedIndexChanged += new System.EventHandler(this.ShowTimeout_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Left;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Image = ((System.Drawing.Image)(resources.GetObject("label1.Image")));
            this.label1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(15, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(264, 56);
            this.label1.TabIndex = 5;
            this.label1.Text = " Pair Show TIme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
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
            this.labelTimer.Size = new System.Drawing.Size(217, 66);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00:00";
            this.labelTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonRestart
            // 
            this.buttonRestart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRestart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonRestart.FlatAppearance.BorderSize = 0;
            this.buttonRestart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonRestart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonRestart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRestart.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonRestart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonRestart.Image = global::Profile.Properties.Resources.shuffleSmall;
            this.buttonRestart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRestart.Location = new System.Drawing.Point(0, 0);
            this.buttonRestart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonRestart.Name = "buttonRestart";
            this.buttonRestart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonRestart.Size = new System.Drawing.Size(408, 108);
            this.buttonRestart.TabIndex = 6;
            this.buttonRestart.Text = "Shuffle";
            this.buttonRestart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonRestart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonRestart.UseVisualStyleBackColor = true;
            this.buttonRestart.EnabledChanged += new System.EventHandler(this.ButtonRestart_EnabledChanged);
            this.buttonRestart.Click += new System.EventHandler(this.ButtonRestart_Click);
            this.buttonRestart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonRestart_Paint);
            // 
            // buttonStart
            // 
            this.buttonStart.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStart.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonStart.FlatAppearance.BorderSize = 0;
            this.buttonStart.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonStart.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonStart.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonStart.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonStart.Image = global::Profile.Properties.Resources.playSmall;
            this.buttonStart.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonStart.Location = new System.Drawing.Point(0, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(5);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonStart.Size = new System.Drawing.Size(408, 100);
            this.buttonStart.TabIndex = 4;
            this.buttonStart.Text = "Play";
            this.buttonStart.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonStart.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonStart.UseVisualStyleBackColor = true;
            this.buttonStart.EnabledChanged += new System.EventHandler(this.ButtonStart_EnabledChanged);
            this.buttonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            this.buttonStart.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonStart_Paint);
            // 
            // buttonShow
            // 
            this.buttonShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonShow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.buttonShow.Enabled = false;
            this.buttonShow.FlatAppearance.BorderSize = 0;
            this.buttonShow.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(194)))), ((int)(((byte)(8)))), ((int)(((byte)(56)))));
            this.buttonShow.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(246)))), ((int)(((byte)(60)))), ((int)(((byte)(108)))));
            this.buttonShow.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonShow.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonShow.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonShow.Image = global::Profile.Properties.Resources.showSmall;
            this.buttonShow.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonShow.Location = new System.Drawing.Point(0, 0);
            this.buttonShow.Margin = new System.Windows.Forms.Padding(5);
            this.buttonShow.Name = "buttonShow";
            this.buttonShow.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.buttonShow.Size = new System.Drawing.Size(408, 95);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show";
            this.buttonShow.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonShow.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.EnabledChanged += new System.EventHandler(this.ButtonShow_EnabledChanged);
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            this.buttonShow.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonShow_Paint);
            // 
            // panelContainer
            // 
            this.panelContainer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panelContainer.Controls.Add(this.flowLayoutPanel1);
            this.panelContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelContainer.ForeColor = System.Drawing.Color.Coral;
            this.panelContainer.Location = new System.Drawing.Point(0, 0);
            this.panelContainer.Name = "panelContainer";
            this.panelContainer.Padding = new System.Windows.Forms.Padding(20);
            this.panelContainer.Size = new System.Drawing.Size(1635, 986);
            this.panelContainer.TabIndex = 7;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel7);
            this.flowLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(20, 20);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(1595, 946);
            this.flowLayoutPanel1.TabIndex = 8;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panelButtons);
            this.panel1.Controls.Add(this.parentPanel);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1175, 926);
            this.panel1.TabIndex = 7;
            // 
            // panel7
            // 
            this.panel7.Controls.Add(this.panel5);
            this.panel7.Controls.Add(this.panel2);
            this.panel7.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel7.Location = new System.Drawing.Point(1184, 3);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(408, 337);
            this.panel7.TabIndex = 9;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.buttonRestart);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 229);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(408, 108);
            this.panel5.TabIndex = 8;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel2.Controls.Add(this.panel6);
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(408, 210);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.buttonShow);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 115);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(408, 95);
            this.panel6.TabIndex = 8;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.buttonStart);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(408, 100);
            this.panel4.TabIndex = 7;
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1635, 986);
            this.Controls.Add(this.panelContainer);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MinimumSize = new System.Drawing.Size(1450, 910);
            this.Name = "FormPlay";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.FormPlay_Load);
            this.panelButtons.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panelContainer.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel7.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
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
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel7;
    }
}

