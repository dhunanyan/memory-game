using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile
{
    public partial class FormMain : Container
    {
        private Button currentButton;
        private Form currentForm;
        public FormMain()
        {
            InitializeComponent();
            buttonTimes.Visible = false;
        }


        private Color SelectThemeColor(string buttonName)
        {
            string color = ThemeColor.colorList[buttonName];
            return ColorTranslator.FromHtml(color);
        }

        private void ActivateButton(object buttonSender)
        {
            if(buttonSender == null || currentButton == (Button)buttonSender)
            {
                return;
            }
            DisableButton();
            currentButton = (Button)buttonSender;
            Color currentColor = SelectThemeColor(currentButton.Name);
            currentButton.BackColor = currentColor;
            currentButton.ForeColor = Color.White;
            panelTitleBar.BackColor = currentColor;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.PrimaryColor = currentColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
            buttonTimes.Visible = true;
        }

        private void DisableButton()
        {
            foreach(Control previousButton in panelMenu.Controls)
            {
                if(previousButton.GetType() == typeof(Button))
                {
                    previousButton.BackColor = Color.FromArgb(51, 51, 76);
                    previousButton.ForeColor = Color.Gainsboro;
                }
            }
        }

        private void OpenChildForm(Form childForm, object buttonSender)
        {
            if(currentForm != null)
            {
                currentForm.Close();
            }
            ActivateButton(buttonSender);
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelMain.Controls.Add(childForm);
            panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        // PLAY
        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "PLAY";
            buttonPlay.Enabled = false;
            buttonRanking.Enabled = true;
            buttonSettings.Enabled = true;
            OpenChildForm(new Forms.FormPlay(), sender);
        }

        private void ButtonPlay_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPlay.ForeColor = Color.Gainsboro;
            buttonPlay.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonPlay_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonPlay.ForeColor = currentButton.Enabled ? Color.Gainsboro : Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonPlay.Text = string.Empty;
            e.Graphics.DrawString("Play", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // SETTINGS
        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "SETTINGS";
            buttonSettings.Enabled = false;
            buttonRanking.Enabled = true;
            buttonPlay.Enabled = true;
            OpenChildForm(new Forms.FormSettings(), sender);
        }


        private void ButtonSettings_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonSettings.ForeColor = Color.Gainsboro;
            buttonSettings.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonSettings_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonSettings.ForeColor = currentButton.Enabled ? Color.Gainsboro : Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonSettings.Text = string.Empty;
            e.Graphics.DrawString("Settings", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        // RANKING
        private void ButtonRanking_Click(object sender, EventArgs e)
        {
            labelTitle.Text = "RANKING";
            buttonRanking.Enabled = false;
            buttonSettings.Enabled = true;
            buttonPlay.Enabled = true;
            OpenChildForm(new Forms.FormRanking(), sender);
        }


        private void ButtonRanking_EnabledChanged(object sender, EventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonRanking.ForeColor = Color.Gainsboro;
            buttonRanking.BackColor = currentButton.Enabled ? ThemeColor.PrimaryColor : ThemeColor.ChangeColorBrightness(ThemeColor.SecondaryColor, 0.5);
        }

        private void ButtonRanking_Paint(object sender, PaintEventArgs e)
        {
            Button currentButton = (Button)sender;
            buttonRanking.ForeColor = currentButton.Enabled ? Color.Gainsboro : Color.Gainsboro;
            SolidBrush drawBrush = new SolidBrush(currentButton.ForeColor);
            StringFormat sf = new StringFormat
            {
                Alignment = StringAlignment.Center,
                LineAlignment = StringAlignment.Center
            };
            buttonRanking.Text = string.Empty;
            e.Graphics.DrawString("Ranking", currentButton.Font, drawBrush, e.ClipRectangle, sf);
            drawBrush.Dispose();
            sf.Dispose();
        }

        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            if(currentForm != null)
            {
                labelTitle.Text = currentForm.Text;
                buttonRanking.Enabled = true;
                buttonSettings.Enabled = true;
                buttonPlay.Enabled = true;
                currentForm.Close();
            }
            Reset();
        }

        private void Reset()
        {
            DisableButton();
            labelTitle.Text = "HOME";
            currentButton = null;
            buttonTimes.Visible = false;
        }
    }
}
