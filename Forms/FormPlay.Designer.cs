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
            this.buttonStart = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelContainer = new System.Windows.Forms.Panel();
            this.labelTimer = new System.Windows.Forms.Label();
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
            this.buttonShow.Size = new System.Drawing.Size(280, 56);
            this.buttonShow.TabIndex = 3;
            this.buttonShow.Text = "Show Cards";
            this.buttonShow.UseVisualStyleBackColor = true;
            this.buttonShow.EnabledChanged += new System.EventHandler(this.ButtonShow_EnabledChanged);
            this.buttonShow.Click += new System.EventHandler(this.ButtonShow_Click);
            this.buttonShow.Paint += new System.Windows.Forms.PaintEventHandler(this.ButtonShow_Paint);
            // 
            // parentPanel
            // 
            this.parentPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.parentPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.parentPanel.Location = new System.Drawing.Point(20, 174);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(0);
            this.parentPanel.MaximumSize = new System.Drawing.Size(1175, 850);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1175, 850);
            this.parentPanel.TabIndex = 4;
            // 
            // panelButtons
            // 
            this.panelButtons.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panelButtons.Controls.Add(this.labelTimer);
            this.panelButtons.Controls.Add(this.buttonStart);
            this.panelButtons.Controls.Add(this.buttonShow);
            this.panelButtons.Location = new System.Drawing.Point(20, 20);
            this.panelButtons.Margin = new System.Windows.Forms.Padding(0, 0, 0, 20);
            this.panelButtons.Name = "panelButtons";
            this.panelButtons.Size = new System.Drawing.Size(1768, 60);
            this.panelButtons.TabIndex = 6;
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
            this.buttonStart.Location = new System.Drawing.Point(280, 0);
            this.buttonStart.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.buttonStart.Name = "buttonStart";
            this.buttonStart.Size = new System.Drawing.Size(216, 56);
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
            this.panelContainer.Size = new System.Drawing.Size(1808, 1044);
            this.panelContainer.TabIndex = 7;
            this.panelContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.panelContainer_Paint);
            // 
            // labelTimer
            // 
            this.labelTimer.Dock = System.Windows.Forms.DockStyle.Left;
            this.labelTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.labelTimer.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.labelTimer.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelTimer.Location = new System.Drawing.Point(496, 0);
            this.labelTimer.Name = "labelTimer";
            this.labelTimer.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.labelTimer.Size = new System.Drawing.Size(206, 56);
            this.labelTimer.TabIndex = 5;
            this.labelTimer.Text = "00:00:00";
            // 
            // FormPlay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1808, 1044);
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
        private System.Windows.Forms.Panel panelButtons;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Panel panelContainer;
        private System.Windows.Forms.Button buttonStart;
        private System.Windows.Forms.Label labelTimer;
    }
}

