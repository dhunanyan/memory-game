namespace Memory
{
    partial class Form1
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
            this.difficultyDropdown = new System.Windows.Forms.ComboBox();
            this.Start = new System.Windows.Forms.Button();
            this.parentPanel = new System.Windows.Forms.Panel();
            this.buttonsPanel = new System.Windows.Forms.Panel();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.card = new Memory.Models.Card(90, false, 999, null);
            this.buttonsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // difficultyDropdown
            // 
            this.difficultyDropdown.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDown;
            this.difficultyDropdown.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.difficultyDropdown.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.difficultyDropdown.Cursor = System.Windows.Forms.Cursors.Hand;
            this.difficultyDropdown.DisplayMember = "Difficulty Dropdown";
            this.difficultyDropdown.Dock = System.Windows.Forms.DockStyle.Fill;
            this.difficultyDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.difficultyDropdown.Font = new System.Drawing.Font("Tempus Sans ITC", 17F, System.Drawing.FontStyle.Bold);
            this.difficultyDropdown.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.difficultyDropdown.FormattingEnabled = true;
            this.difficultyDropdown.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.difficultyDropdown.ItemHeight = 45;
            this.difficultyDropdown.Items.AddRange(new object[] {
            "Easy",
            "Normal",
            "Hard"});
            this.difficultyDropdown.Location = new System.Drawing.Point(0, 0);
            this.difficultyDropdown.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.difficultyDropdown.MaximumSize = new System.Drawing.Size(500, 0);
            this.difficultyDropdown.Name = "difficultyDropdown";
            this.difficultyDropdown.Size = new System.Drawing.Size(181, 53);
            this.difficultyDropdown.TabIndex = 1;
            this.difficultyDropdown.SelectedIndexChanged += new System.EventHandler(this.DifficultyDropdown_SelectedIndexChanged);
            // 
            // Start
            // 
            this.Start.Font = new System.Drawing.Font("Tempus Sans ITC", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(20, 11);
            this.Start.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(197, 54);
            this.Start.TabIndex = 3;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = true;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // parentPanel
            // 
            this.parentPanel.BackColor = System.Drawing.Color.DarkGray;
            this.parentPanel.Location = new System.Drawing.Point(20, 205);
            this.parentPanel.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.parentPanel.Name = "parentPanel";
            this.parentPanel.Size = new System.Drawing.Size(1770, 850);
            this.parentPanel.TabIndex = 4;
            // 
            // buttonsPanel
            // 
            this.buttonsPanel.Controls.Add(this.difficultyDropdown);
            this.buttonsPanel.Location = new System.Drawing.Point(225, 12);
            this.buttonsPanel.Name = "buttonsPanel";
            this.buttonsPanel.Size = new System.Drawing.Size(181, 53);
            this.buttonsPanel.TabIndex = 6;
            // 
            // card
            // 
            this.card.BackgroundImage = global::Memory.Properties.Resources.back;
            this.card.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.card.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.card.Image = null;
            this.card.IsSelected = false;
            this.card.Location = new System.Drawing.Point(127, 76);
            this.card.Margin = new System.Windows.Forms.Padding(0);
            this.card.Name = "card";
            this.card.Size = new System.Drawing.Size(90, 125);
            this.card.TabIndex = 5;
            this.card.Value = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(48)))), ((int)(((byte)(48)))), ((int)(((byte)(48)))));
            this.ClientSize = new System.Drawing.Size(1808, 1074);
            this.Controls.Add(this.card);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.buttonsPanel);
            this.Controls.Add(this.parentPanel);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.buttonsPanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Start;
        public System.Windows.Forms.Panel parentPanel;
        private Models.Card card;
        private System.Windows.Forms.ComboBox difficultyDropdown;
        private System.Windows.Forms.Panel buttonsPanel;
        private System.Windows.Forms.Timer timer1;
    }
}

