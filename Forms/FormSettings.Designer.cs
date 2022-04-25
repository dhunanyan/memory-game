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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.difficultyDropdown = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(639, 61);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(548, 61);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // difficultyDropdown
            // 
            this.difficultyDropdown.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.difficultyDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.difficultyDropdown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.difficultyDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficultyDropdown.DisplayMember = "Difficulty Dropdown";
            this.difficultyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropdown.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.difficultyDropdown.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold);
            this.difficultyDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.difficultyDropdown.FormattingEnabled = true;
            this.difficultyDropdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.difficultyDropdown.ItemHeight = 45;
            this.difficultyDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard",
            "Extreme"});
            this.difficultyDropdown.Location = new System.Drawing.Point(783, 129);
            this.difficultyDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(500, 53);
            this.difficultyDropdown.TabIndex = 3;
            this.difficultyDropdown.SelectedIndexChanged += new System.EventHandler(this.DifficultyDropdown_SelectedIndexChanged);
            this.difficultyDropdown.SelectedItem = Profile.Container.currentDifficulty;
            this.difficultyDropdown.SelectedText = Profile.Container.currentDifficulty;
            // 
            // FormSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1499, 807);
            this.Controls.Add(this.difficultyDropdown);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "FormSettings";
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormSettings_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox difficultyDropdown;
    }
}