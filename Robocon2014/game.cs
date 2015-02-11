using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Robocon2014
{
    public partial class game : Form
    {
        string redt, bluet,sh,win,team1,team2;
        int flag;
        public game(string r1, string b1,string status,string t1,string t2,int fg)
        {
            InitializeComponent();
            redt = r1;
            bluet = b1;
            team1 = t1;
            team2 = t2;
            flag = fg;
            FillScore();
            gameStatus.Text = status;


        }

        void FillScore()
        {

            lblRedScore.Text = txtRedScore.Text;
            lblBlueScore.Text = txtBlueScore.Text;

        }


        private void game_Load(object sender, EventArgs e)
        {
            txtRedTeam.Text = redt;
            txtBlueTeam.Text = bluet;
            lblRedScore.Text = "0";
            lblBlueScore.Text = "0";
            if (team1 != "" || team2!="")
            {
                matchno.Text = " " + team1 + " VS " + team2 + " ";
            }
            string constring = "Data Source=MAC;Initial Catalog=RoboconDB;Persist Security Info=True;User ID=sa;Password=123";
            string Query = "select * from RoboconTeamTable where CountryName='" + this.txtRedTeam.Text + "';";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                while (myReader.Read())
                {
                    byte[] imgg = (byte[])(myReader["Image"]);
                    if (imgg == null)
                    {
                        RedTeamImage.Image = null;
                    }
                    else
                    {
                        MemoryStream mstream = new MemoryStream(imgg);
                        RedTeamImage.Image = System.Drawing.Image.FromStream(mstream);

                    }
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            //----------------------------------------------------2---------------------------------------
            string Query2 = "select * from RoboconTeamTable where CountryName='" + this.txtBlueTeam.Text + "';";
            SqlConnection conDataBase2 = new SqlConnection(constring);
            SqlCommand cmdDataBase2 = new SqlCommand(Query2, conDataBase2);
            SqlDataReader myReader2;
            try
            {

                conDataBase2.Open();
                myReader2 = cmdDataBase2.ExecuteReader();
                while (myReader2.Read())
                {
                    byte[] imgg2 = (byte[])(myReader2["Image"]);
                    if (imgg2 == null)
                    {
                        BlueTeamImage = null;
                    }
                    else
                    {
                        MemoryStream mstream2 = new MemoryStream(imgg2);
                        BlueTeamImage.Image = System.Drawing.Image.FromStream(mstream2);

                    }
                }
            }

            catch (Exception ex1)
            {
                MessageBox.Show(ex1.Message);

            }


        }

        private void Score_Click(object sender, EventArgs e)
        {
            lblRedScore.Text = "";
            lblRedScore.Text = txtRedScore.Text;
            lblBlueScore.Text = "";
            lblBlueScore.Text = txtBlueScore.Text;
        }

        private void RedSh_Click(object sender, EventArgs e)
        {
            sh = txtRedTeam.Text;            
            Form shabaash = new shabaash(sh,flag);
            shabaash.Show();
            lblRedScore.Visible = false;
            lblshared.Visible = true;
            lblshared.Text = "SHABAASH!";
        }

        private void BlueSh_Click(object sender, EventArgs e)
        {
            sh = txtBlueTeam.Text;
            Form shabaash = new shabaash(sh,flag);
            shabaash.Show();
            lblBlueScore.Visible = false;
            lblshablue.Visible = true;
            lblshablue.Text = "SHABAASH!";
            
        }

        private void butRedWin_Click(object sender, EventArgs e)
        {
            win = txtRedTeam.Text;
            Form winner = new winner(win,flag);
            winner.Show();
            this.Close();
        }

        private void butBlueWin_Click(object sender, EventArgs e)
        {
            win = txtBlueTeam.Text;
            Form winner = new winner(win,flag);
            winner.Show();
            this.Close();
        }

        private void Close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
