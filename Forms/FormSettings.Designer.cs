namespace Profile.Forms
{
    partial class FormSettings
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.difficultyDropdown = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showTimeoutSettings = new System.Windows.Forms.ComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.difficultyLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyDropdown
            // 
            this.difficultyDropdown.BackColor = System.Drawing.SystemColors.Highlight;
            this.difficultyDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficultyDropdown.Dock = System.Windows.Forms.DockStyle.Right;
            this.difficultyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyDropdown.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.difficultyDropdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyDropdown.ItemHeight = 42;
            this.difficultyDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Extreme"});
            this.difficultyDropdown.Location = new System.Drawing.Point(368, 5);
            this.difficultyDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(227, 50);
            this.difficultyDropdown.TabIndex = 3;
            this.difficultyDropdown.SelectedIndexChanged += new System.EventHandler(this.DifficultyDropdown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1499, 807);
            this.panel1.TabIndex = 4;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.showTimeoutSettings);
            this.panel3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(20, 93);
            this.panel3.Margin = new System.Windows.Forms.Padding(0);
            this.panel3.MaximumSize = new System.Drawing.Size(600, 70);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(5);
            this.panel3.Size = new System.Drawing.Size(600, 70);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(3, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.label1.Size = new System.Drawing.Size(365, 60);
            this.label1.TabIndex = 5;
            this.label1.Text = "Pair Show TIme";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // showTimeoutSettings
            // 
            this.showTimeoutSettings.BackColor = System.Drawing.SystemColors.Highlight;
            this.showTimeoutSettings.Cursor = System.Windows.Forms.Cursors.Hand;
            this.showTimeoutSettings.Dock = System.Windows.Forms.DockStyle.Right;
            this.showTimeoutSettings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.showTimeoutSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.showTimeoutSettings.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.showTimeoutSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.showTimeoutSettings.ItemHeight = 42;
            this.showTimeoutSettings.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "20 sec",
            "40 sec",
            "80 sec",
            "120 sec"});
            this.showTimeoutSettings.Location = new System.Drawing.Point(368, 5);
            this.showTimeoutSettings.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.showTimeoutSettings.MaximumSize = new System.Drawing.Size(500, 0);
            this.showTimeoutSettings.Name = "showTimeoutSettings";
            this.showTimeoutSettings.Size = new System.Drawing.Size(227, 50);
            this.showTimeoutSettings.TabIndex = 4;
            this.showTimeoutSettings.SelectedIndexChanged += new System.EventHandler(this.ShowTimeout_SelectedIndexChanged);
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.difficultyLevel);
            this.panel2.Controls.Add(this.difficultyDropdown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.MaximumSize = new System.Drawing.Size(600, 70);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(5);
            this.panel2.Size = new System.Drawing.Size(600, 70);
            this.panel2.TabIndex = 4;
            // 
            // difficultyLevel
            // 
            this.difficultyLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.difficultyLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.difficultyLevel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.difficultyLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyLevel.Location = new System.Drawing.Point(3, 5);
            this.difficultyLevel.Name = "difficultyLevel";
            this.difficultyLevel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.difficultyLevel.Size = new System.Drawing.Size(365, 60);
            this.difficultyLevel.TabIndex = 4;
            this.difficultyLevel.Text = "Choose Difficulty";
            this.difficultyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 807);
            this.Controls.Add(this.panel1);
            this.Name = "FormSettings";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox difficultyDropdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label difficultyLevel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox showTimeoutSettings;
    }
}