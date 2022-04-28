using Profile.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Profile.Forms
{
    public partial class FormRanking : Container
    {
        public FormRanking()
        {
            InitializeComponent();
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

        private void FormRanking_Load(object sender, EventArgs e)
        {
            LoadTheme();
            LoadData();
        }

        private void LoadData()
        {
            
            using (OleDbConnection conection = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0; Data Source=db_users.mdb"))
            {
                conection.Open();
                string query = "SELECT * FROM table_users ORDER BY score DESC";
                OleDbCommand command = new OleDbCommand(query, conection);
                OleDbDataReader reader = command.ExecuteReader();
                int index = 0;
                int locationY = 0;
                while (reader.Read())
                {
                    if(locationY > 430)
                    {
                        dataContainer.AutoScroll = true;
                        dataContainer.AutoScrollMinSize = new Size(0, locationY);
                    }
                    FlowLayoutPanel currentRecord = new FlowLayoutPanel()
                    {
                        BackColor = CurrentUser[0] == reader[0].ToString() ? Color.FromArgb(33, 150, 243) : Color.FromArgb(85, 85, 110),
                        Location = new Point(0, 0 + locationY),
                        Margin = new Padding(0, index > 0 ? 10 : 0, 0, 0),
                        Name = "user_" + reader[0],
                        Padding = new Padding(5),
                        Size = new Size(790, 50),
                        TabIndex = 2 + index,
                    };

                    Label currentUsername = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Image = index == 0 ? Resources.medalGold : index == 1 ? Resources.medalSilver : index == 2 ? Resources.medalBronze : Resources.user,
                        ImageAlign = ContentAlignment.MiddleLeft,
                        Location = new Point(10, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelUsername_" + reader[0],
                        Size = new Size(110, 40),
                        TabIndex = index,
                        Text = "       " + reader[0],
                        TextAlign = ContentAlignment.MiddleLeft,
                    };

                    Label currentScore = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Location = new Point(135, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelScore_" + reader[0],
                        Size = new Size(120, 40),
                        TabIndex = index,
                        Text = reader[6].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label currentMoves = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Location = new Point(260, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelMoves_" + reader[0],
                        Size = new Size(120, 40),
                        TabIndex = index,
                        Text = reader[4].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label currentShows = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Location = new Point(385, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelShows_" + reader[0],
                        Size = new Size(120, 40),
                        TabIndex = index,
                        Text = reader[2].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label currentHints = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Location = new Point(410, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelHints_" + reader[0],
                        Size = new Size(120, 40),
                        TabIndex = index,
                        Text = reader[2].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };

                    Label currentTime = new Label()
                    {
                        FlatStyle = FlatStyle.Flat,
                        Font = new Font("Tw Cen MT Condensed", 16F, FontStyle.Bold),
                        ForeColor = Color.Gainsboro,
                        Location = new Point(535, 5),
                        Margin = new Padding(5, 0, 5, 0),
                        Name = "labelTime_" + reader[0],
                        Size = new Size(120, 40),
                        TabIndex = index,
                        Text = reader[5].ToString(),
                        TextAlign = ContentAlignment.MiddleCenter,
                    };
                    
                    currentRecord.Controls.Add(currentUsername);
                    currentRecord.Controls.Add(currentScore);
                    currentRecord.Controls.Add(currentMoves);
                    currentRecord.Controls.Add(currentShows);
                    currentRecord.Controls.Add(currentHints);
                    currentRecord.Controls.Add(currentTime);

                    dataContainer.Controls.Add(currentRecord);
                    
                    index++;
                    locationY += 60;
                }
            }
        }
    }
}
