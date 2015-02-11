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
    public partial class Form1 : Form
    {

        String redt, bluet,team1="",team2="";
        String status=null;
        int flag=0;
            public Form1()
        {
            InitializeComponent();
            FillCombo();
           
        }

        void FillCombo()
        {

            string constring = "Data Source=MAC;Initial Catalog=RoboconDB;Persist Security Info=True;User ID=sa;Password=123";
            string Query = "select CountryName from RoboconTeamTable;" ;
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
           
            try
            {
                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
               
                
                while (myReader.Read())
                {
                    RedTeam.Items.Add(myReader[0]);
                    BlueTeam.Items.Add(myReader[0]);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }

        }

        private void registerTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerTeamToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form register = new register();
            register.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'roboconDBDataSet.RoboconTeamTable' table. You can move, or remove it, as needed.
           // this.roboconTeamTableTableAdapter.Fill(this.roboconDBDataSet.RoboconTeamTable);

        }

        private void Start_Click(object sender, EventArgs e)
        {
            label1.Text= RedTeam.Text;
            redt = label1.Text;
            label2.Text = BlueTeam.Text;                       
            bluet = label2.Text;

            team1 = txtAred.Text;
            team2 = txtAblue.Text;
            RedTeam.Text = "";
            BlueTeam.Text = "";

            Form game = new game (redt, bluet,status,team1,team2,flag);
            game.Show();
            team2 = null;
            team1 = null;

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            status = "Preliminary Match";
            flag = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            status = "Semi-Final";
            flag = 0;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            status = "Final";
            flag = 1;
        }

        private void quaterfin_Click(object sender, EventArgs e)
        {
            status = "Quarter Final";
            flag = 0;
        }
    }
}
