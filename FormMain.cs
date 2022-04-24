using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile
{
    public partial class FormMain : Form
    {
        private Button currentButton;
        private Form currentForm;
        public FormMain()
        {
            InitializeComponent();
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
            labelTitle.Text = currentButton.Text;
            panelLogo.BackColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.PrimaryColor = currentColor;
            ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(currentColor, -0.3);
            ThemeColor.TertiaryColor = ThemeColor.ChangeColorBrightness(currentColor, 0.5);
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
            if(ActiveForm == null)
            {
                return;
            }
            ActivateButton(buttonSender);
            currentForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void ButtonPlay_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormPlay(), sender);
        }

        private void ButtonSettings_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormSettings(), sender);
        }

        private void ButtonRanking_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Forms.FormRanking(), sender);
        }
    }
}
