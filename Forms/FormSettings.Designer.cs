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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.difficultyLevel = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxShowInitial = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.showTimeoutSettings = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.checkBoxGodMode = new System.Windows.Forms.CheckBox();
            this.buttonDefault = new System.Windows.Forms.Button();
            this.labelSettings = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.timer)).BeginInit();
            this.panel1.SuspendLayout();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer
            // 
            this.timer.Enabled = false;
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
            this.difficultyDropdown.ItemHeight = 28;
            this.difficultyDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Extreme"});
            this.difficultyDropdown.Location = new System.Drawing.Point(245, 3);
            this.difficultyDropdown.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.difficultyDropdown.MaximumSize = new System.Drawing.Size(335, 0);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(152, 36);
            this.difficultyDropdown.TabIndex = 3;
            this.difficultyDropdown.SelectedIndexChanged += new System.EventHandler(this.DifficultyDropdown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.panel1.Controls.Add(this.flowLayoutPanel1);
            this.panel1.Controls.Add(this.labelSettings);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(14, 13, 14, 13);
            this.panel1.Size = new System.Drawing.Size(999, 525);
            this.panel1.TabIndex = 4;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel5);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.Controls.Add(this.panel4);
            this.flowLayoutPanel1.Controls.Add(this.buttonDefault);
            this.flowLayoutPanel1.Location = new System.Drawing.Point(300, 162);
            this.flowLayoutPanel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(400, 254);
            this.flowLayoutPanel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel2.Controls.Add(this.difficultyLevel);
            this.panel2.Controls.Add(this.difficultyDropdown);
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel2.MaximumSize = new System.Drawing.Size(400, 46);
            this.panel2.Name = "panel2";
            this.panel2.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel2.Size = new System.Drawing.Size(400, 46);
            this.panel2.TabIndex = 4;
            // 
            // difficultyLevel
            // 
            this.difficultyLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.difficultyLevel.Dock = System.Windows.Forms.DockStyle.Right;
            this.difficultyLevel.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.difficultyLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyLevel.Location = new System.Drawing.Point(2, 3);
            this.difficultyLevel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.difficultyLevel.Name = "difficultyLevel";
            this.difficultyLevel.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.difficultyLevel.Size = new System.Drawing.Size(243, 40);
            this.difficultyLevel.TabIndex = 4;
            this.difficultyLevel.Text = "Choose Difficulty";
            this.difficultyLevel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel5.Controls.Add(this.label2);
            this.panel5.Controls.Add(this.comboBoxShowInitial);
            this.panel5.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panel5.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel5.Location = new System.Drawing.Point(0, 52);
            this.panel5.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel5.MaximumSize = new System.Drawing.Size(400, 46);
            this.panel5.Name = "panel5";
            this.panel5.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel5.Size = new System.Drawing.Size(400, 46);
            this.panel5.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label2.Dock = System.Windows.Forms.DockStyle.Right;
            this.label2.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(2, 3);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label2.Size = new System.Drawing.Size(243, 40);
            this.label2.TabIndex = 5;
            this.label2.Text = "Initial Show Time";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // comboBoxShowInitial
            // 
            this.comboBoxShowInitial.BackColor = System.Drawing.SystemColors.Highlight;
            this.comboBoxShowInitial.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboBoxShowInitial.Dock = System.Windows.Forms.DockStyle.Right;
            this.comboBoxShowInitial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxShowInitial.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBoxShowInitial.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.comboBoxShowInitial.ForeColor = System.Drawing.Color.Gainsboro;
            this.comboBoxShowInitial.ItemHeight = 28;
            this.comboBoxShowInitial.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "20 sec",
            "40 sec",
            "80 sec",
            "120 sec"});
            this.comboBoxShowInitial.Location = new System.Drawing.Point(245, 3);
            this.comboBoxShowInitial.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.comboBoxShowInitial.MaximumSize = new System.Drawing.Size(335, 0);
            this.comboBoxShowInitial.Name = "comboBoxShowInitial";
            this.comboBoxShowInitial.Size = new System.Drawing.Size(152, 36);
            this.comboBoxShowInitial.TabIndex = 4;
            this.comboBoxShowInitial.SelectedIndexChanged += new System.EventHandler(this.ComboBoxShowInitial_SelectedIndexChanged);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.showTimeoutSettings);
            this.panel3.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panel3.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel3.Location = new System.Drawing.Point(0, 104);
            this.panel3.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel3.MaximumSize = new System.Drawing.Size(400, 46);
            this.panel3.Name = "panel3";
            this.panel3.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel3.Size = new System.Drawing.Size(400, 46);
            this.panel3.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.label1.Dock = System.Windows.Forms.DockStyle.Right;
            this.label1.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(2, 3);
            this.label1.Margin = new System.Windows.Forms.Padding(0);
            this.label1.Name = "label1";
            this.label1.Padding = new System.Windows.Forms.Padding(0, 3, 0, 0);
            this.label1.Size = new System.Drawing.Size(243, 40);
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
            this.showTimeoutSettings.ItemHeight = 28;
            this.showTimeoutSettings.Items.AddRange(new object[] {
            "1 sec",
            "2 sec",
            "5 sec",
            "10 sec",
            "20 sec",
            "40 sec",
            "80 sec",
            "120 sec"});
            this.showTimeoutSettings.Location = new System.Drawing.Point(245, 3);
            this.showTimeoutSettings.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.showTimeoutSettings.MaximumSize = new System.Drawing.Size(335, 0);
            this.showTimeoutSettings.Name = "showTimeoutSettings";
            this.showTimeoutSettings.Size = new System.Drawing.Size(152, 36);
            this.showTimeoutSettings.TabIndex = 4;
            this.showTimeoutSettings.SelectedIndexChanged += new System.EventHandler(this.ShowTimeout_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panel4.Controls.Add(this.checkBoxGodMode);
            this.panel4.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.panel4.ForeColor = System.Drawing.Color.Gainsboro;
            this.panel4.Location = new System.Drawing.Point(0, 156);
            this.panel4.Margin = new System.Windows.Forms.Padding(0, 0, 0, 6);
            this.panel4.MaximumSize = new System.Drawing.Size(400, 46);
            this.panel4.Name = "panel4";
            this.panel4.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.panel4.Size = new System.Drawing.Size(400, 46);
            this.panel4.TabIndex = 6;
            // 
            // checkBoxGodMode
            // 
            this.checkBoxGodMode.AutoSize = true;
            this.checkBoxGodMode.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.checkBoxGodMode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkBoxGodMode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.checkBoxGodMode.FlatAppearance.BorderSize = 0;
            this.checkBoxGodMode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxGodMode.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.checkBoxGodMode.Location = new System.Drawing.Point(3, 3);
            this.checkBoxGodMode.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.checkBoxGodMode.Name = "checkBoxGodMode";
            this.checkBoxGodMode.Padding = new System.Windows.Forms.Padding(0, 0, 14, 0);
            this.checkBoxGodMode.Size = new System.Drawing.Size(394, 40);
            this.checkBoxGodMode.TabIndex = 6;
            this.checkBoxGodMode.Text = "God Mode";
            this.checkBoxGodMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.checkBoxGodMode.UseVisualStyleBackColor = true;
            this.checkBoxGodMode.CheckedChanged += new System.EventHandler(this.CheckBoxGodMode_CheckedChanged);
            // 
            // buttonDefault
            // 
            this.buttonDefault.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.buttonDefault.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonDefault.FlatAppearance.BorderSize = 0;
            this.buttonDefault.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(59)))));
            this.buttonDefault.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(85)))), ((int)(((byte)(85)))), ((int)(((byte)(110)))));
            this.buttonDefault.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDefault.Font = new System.Drawing.Font("Tw Cen MT Condensed", 18F, System.Drawing.FontStyle.Bold);
            this.buttonDefault.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDefault.Location = new System.Drawing.Point(0, 208);
            this.buttonDefault.Margin = new System.Windows.Forms.Padding(0);
            this.buttonDefault.Name = "buttonDefault";
            this.buttonDefault.Size = new System.Drawing.Size(400, 46);
            this.buttonDefault.TabIndex = 7;
            this.buttonDefault.Text = "Back to Default Settings";
            this.buttonDefault.UseVisualStyleBackColor = false;
            this.buttonDefault.Click += new System.EventHandler(this.ButtonDefault_Click);
            // 
            // labelSettings
            // 
            this.labelSettings.Font = new System.Drawing.Font("Tw Cen MT Condensed", 64F, System.Drawing.FontStyle.Bold);
            this.labelSettings.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelSettings.Location = new System.Drawing.Point(14, 13);
            this.labelSettings.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.labelSettings.Name = "labelSettings";
            this.labelSettings.Size = new System.Drawing.Size(973, 96);
            this.labelSettings.TabIndex = 8;
            this.labelSettings.Text = "Custom Settings";
            this.labelSettings.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(999, 525);
            this.Controls.Add(this.panel1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FormSettings";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.timer)).EndInit();
            this.panel1.ResumeLayout(false);
            this.flowLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel5.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
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
        private System.Windows.Forms.CheckBox checkBoxGodMode;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBoxShowInitial;
        private System.Windows.Forms.Label labelSettings;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Button buttonDefault;
    }
}