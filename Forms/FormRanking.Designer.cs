namespace Profile.Forms
{
    partial class FormRanking
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.labelRanking = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.labelRanking);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(20, 20);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1553, 948);
            this.panel1.TabIndex = 0;
            // 
            // labelRanking
            // 
            this.labelRanking.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelRanking.Font = new System.Drawing.Font("Tw Cen MT Condensed", 64F, System.Drawing.FontStyle.Bold);
            this.labelRanking.ForeColor = System.Drawing.Color.Gainsboro;
            this.labelRanking.Location = new System.Drawing.Point(151, 0);
            this.labelRanking.Name = "labelRanking";
            this.labelRanking.Size = new System.Drawing.Size(1251, 162);
            this.labelRanking.TabIndex = 0;
            this.labelRanking.Text = "Ranking";
            this.labelRanking.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // FormRanking
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(68)))), ((int)(((byte)(93)))));
            this.ClientSize = new System.Drawing.Size(1593, 988);
            this.Controls.Add(this.panel1);
            this.Name = "FormRanking";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.Text = "FormPlay";
            this.Load += new System.EventHandler(this.FormRanking_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label labelRanking;
    }
}