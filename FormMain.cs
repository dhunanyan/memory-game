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
using System.Data.OleDb;

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
            buttonPlay.Enabled = false;
            buttonRanking.Enabled = false;
            buttonSettings.Enabled = false;

            Color color = ColorTranslator.FromHtml("#33334c");

            buttonPlay.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonPlay.ForeColor = Color.Gainsboro;
            buttonPlay.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonRanking.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonRanking.ForeColor = Color.Gainsboro;
            buttonRanking.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;

            buttonSettings.BackColor = ThemeColor.ChangeColorBrightness(color, 0.5);
            buttonSettings.ForeColor = Color.Gainsboro;
            buttonSettings.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
        }

        // DATABASE
        OleDbConnection con = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_users.mdb");
        OleDbCommand cmd  = new OleDbCommand();

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
            buttonPlay.ForeColor = Color.Gainsboro;
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
            buttonSettings.ForeColor = Color.Gainsboro;
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
            buttonRanking.ForeColor = Color.Gainsboro;
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

        // LOGOUT
        private void ButtonTimes_Click(object sender, EventArgs e)
        {
            CurrentUser[0] = "Username";
            CurrentUser[1] = "Password";
            if (currentForm != null)
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

        // SHOW PASSWORD FOR SIGNUP
        private void CheckBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPassword.PasswordChar = '\0';
                textBoxConfirmPassword.PasswordChar = '\0';
            }
            else
            {
                textBoxPassword.PasswordChar = '●';
                textBoxConfirmPassword.PasswordChar = '●';
            }
        }

        // SIGN UP
        private void ButtonSignup_Click(object sender, EventArgs e)
        {
            if(textBoxUsername.Text == "" && textBoxPassword.Text == "" && textBoxConfirmPassword.Text == "")
            {
                MessageBox.Show("Username and Password fields empty", "Registration failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if(textBoxPassword.Text == textBoxConfirmPassword.Text)
            {
                con.Open();
                string register = "INSERT INTO table_users VALUES ('" + textBoxUsername.Text + "', '" + textBoxPassword.Text + "')";
                cmd = new OleDbCommand(register, con);
                cmd.ExecuteNonQuery();
                con.Close();

                textBoxUsername.Text = "";
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";

                MessageBox.Show("Your Account has been Successfully Created", "Registration Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                SignIn.Visible = true;
                SignUp.Visible = false;
            }
            else
            {
                MessageBox.Show("Passwords does not match, Please enter valid credentials", "Registration Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                textBoxPassword.Text = "";
                textBoxConfirmPassword.Text = "";
                textBoxPassword.Focus();
            }
        }

        private void ButtonClear_Click(object sender, EventArgs e)
        {
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            textBoxUsername.Focus();
        }

        private void LabelChangeToSignin_Click(object sender, EventArgs e)
        {
            checkBoxShowPassword.Checked = false;
            textBoxUsername.Text = "";
            textBoxPassword.Text = "";
            textBoxConfirmPassword.Text = "";
            SignIn.Visible = true;
            SignUp.Visible = false;
        }

        // SHOW PASSWORD FOR SIGNIN
        private void CheckBoxShowPasswordSignin_CheckedChange(object sender, EventArgs e)
        {
            if (checkBoxShowPassword.Checked)
            {
                textBoxPasswordSignin.PasswordChar = '\0';
            }
            else
            {
                textBoxPasswordSignin.PasswordChar = '●';
            }
        }

        // SIGN IN
        private void ButtonSignin_Click(object sender, EventArgs e)
        {
            con.Open();
            string userLogin = "SELECT * FROM table_users WHERE username='" + textBoxUsernameSignin.Text + "' AND password='" + textBoxPasswordSignin.Text + "'";
            cmd = new OleDbCommand(userLogin, con);
            OleDbDataReader dr = cmd.ExecuteReader();

            if(dr.Read() == true)
            {
                CurrentUser[0] = textBoxUsernameSignin.Text;
                CurrentUser[1] = textBoxPasswordSignin.Text;
                buttonPlay.Enabled = true;
                buttonRanking.Enabled = true;
                buttonSettings.Enabled = true;

                if (currentForm != null)
                {
                    labelTitle.Text = currentForm.Text;
                    currentForm.Close();
                }
                textBoxUsernameSignin.Text = "";
                textBoxPasswordSignin.Text = "";
                OpenChildForm(new Forms.FormPlay(), buttonPlay);
                Reset();
                buttonTimes.Visible = true;
                con.Close();
            }
            else
            {
                MessageBox.Show("Invalid Username or Password, Please try again", "Login Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

                textBoxUsernameSignin.Text = "";
                textBoxPasswordSignin.Text = "";
                textBoxUsernameSignin.Focus();
                con.Close();
            }
        }

        private void ButtonClearSignin(object sender, EventArgs e)
        {
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            textBoxUsernameSignin.Focus();
        }


        private void LabelChangeToSignup_Click(object sender, EventArgs e)
        {
            checkBoxShowPasswordSignin.Checked = false;
            textBoxUsernameSignin.Text = "";
            textBoxPasswordSignin.Text = "";
            SignIn.Visible = false;
            SignUp.Visible = true;
        }
    }
}
