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
            this.panel2 = new System.Windows.Forms.Panel();
            this.difficultyLevel = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyDropdown
            // 
            this.difficultyDropdown.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.difficultyDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.difficultyDropdown.BackColor = System.Drawing.SystemColors.Highlight;
            this.difficultyDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficultyDropdown.DisplayMember = "Difficulty Dropdown";
            this.difficultyDropdown.Dock = System.Windows.Forms.DockStyle.Left;
            this.difficultyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyDropdown.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.difficultyDropdown.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyDropdown.FormattingEnabled = true;
            this.difficultyDropdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.difficultyDropdown.ItemHeight = 47;
            this.difficultyDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Extreme"});
            this.difficultyDropdown.Location = new System.Drawing.Point(0, 0);
            this.difficultyDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(227, 55);
            this.difficultyDropdown.TabIndex = 3;
            this.difficultyDropdown.SelectedIndexChanged += new System.EventHandler(this.DifficultyDropdown_SelectedIndexChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(20);
            this.panel1.Size = new System.Drawing.Size(1499, 807);
            this.panel1.TabIndex = 4;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.difficultyLevel);
            this.panel2.Controls.Add(this.difficultyDropdown);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(20, 20);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1459, 55);
            this.panel2.TabIndex = 4;
            // 
            // difficultyLevel
            // 
            this.difficultyLevel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.difficultyLevel.Dock = System.Windows.Forms.DockStyle.Left;
            this.difficultyLevel.Font = new System.Drawing.Font("Lucida Calligraphy", 18F, System.Drawing.FontStyle.Bold);
            this.difficultyLevel.ForeColor = System.Drawing.Color.Gainsboro;
            this.difficultyLevel.Location = new System.Drawing.Point(227, 0);
            this.difficultyLevel.Name = "difficultyLevel";
            this.difficultyLevel.Padding = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.difficultyLevel.Size = new System.Drawing.Size(382, 55);
            this.difficultyLevel.TabIndex = 4;
            this.difficultyLevel.Text = "Choose difficulty";
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
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ComboBox difficultyDropdown;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label difficultyLevel;
    }
}