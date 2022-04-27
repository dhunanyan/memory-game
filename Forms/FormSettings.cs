using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile.Forms
{
    public partial class FormSettings : Container
    {
        public FormSettings()
        {
            InitializeComponent();
            difficultyDropdown.SelectedItem = currentDifficulty;
            showTimeoutSettings.SelectedItem = currentShowTimeout.ToString() + " sec";
            comboBoxShowInitial.SelectedItem = currentInitialShowTime.ToString() + " sec";
            checkBoxGodMode.Checked = isGodeMode;
        }

        private void LoadTheme()
        {
            foreach (Control control in this.Controls)
            {
                if (control.GetType() == typeof(Button))
                {
                    Button button = (Button)control;
                    button.BackColor = ThemeColor.PrimaryColor;
                    button.ForeColor = Color.Gainsboro;
                    button.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormSettings_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void DifficultyDropdown_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentDifficulty = difficultyDropdown.SelectedItem.ToString();
            ChangeDifficulty(currentDifficulty);
        }

        private void ShowTimeout_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentShowTimeout = Int32.Parse(showTimeoutSettings.SelectedItem.ToString().Split(' ')[0]);
        }

        private void CheckBoxGodMode_CheckedChanged(object sender, EventArgs e)
        {
            isGodeMode = checkBoxGodMode.Checked;
        }

        private void ComboBoxShowInitial_SelectedIndexChanged(object sender, EventArgs e)
        {
            currentInitialShowTime = Int32.Parse(comboBoxShowInitial.SelectedItem.ToString().Split(' ')[0]);
        }
    }
}
