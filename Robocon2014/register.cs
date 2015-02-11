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
    public partial class register : Form
    {
        string imagename;


        public register()
        {
            InitializeComponent();
        }
   

        private void register_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string constring = "Data Source=MAC;Initial Catalog=RoboconDB;Persist Security Info=True;User ID=sa;Password=123";
            string Query = "delete from RoboconTeamTable where TeamId='" + this.txtId.Text + "';";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {

                conDataBase.Open();
                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Item's Deleted from the table.");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txtId.Text = "";
            txtCountryName.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            byte[] imageBt = null;
            FileStream fstream = new FileStream(@imagename, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fstream);
            imageBt = br.ReadBytes((int)fstream.Length);



            string constring = "Data Source=MAC;Initial Catalog=RoboconDB;Persist Security Info=True;User ID=sa;Password=123";
            string Query = "insert into RoboconTeamTable(TeamId,CountryName,Image) values('" + this.txtId.Text + "','" + this.txtCountryName.Text + "',@IMG) ;";
            SqlConnection conDataBase = new SqlConnection(constring);
            SqlCommand cmdDataBase = new SqlCommand(Query, conDataBase);
            SqlDataReader myReader;
            try
            {

                conDataBase.Open();
                cmdDataBase.Parameters.Add(new SqlParameter("@IMG", imageBt));

                myReader = cmdDataBase.ExecuteReader();
                MessageBox.Show("Team has been Successfully Registered");
                while (myReader.Read())
                {

                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            txtId.Text = "";
            txtCountryName.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                FileDialog fldlg = new OpenFileDialog();

                fldlg.InitialDirectory = @":C\";

                fldlg.Filter = "Image File (*.jpg;*.bmp;*.gif;*.png)|*.jpg;*.bmp;*.gif;*.png";

                if (fldlg.ShowDialog() == DialogResult.OK)
                {

                    imagename = fldlg.FileName;

                    Bitmap newimg = new Bitmap(imagename);

                    imagePictureBox.SizeMode = PictureBoxSizeMode.StretchImage;


                    imagePictureBox.Image = (Image)newimg;

                }

                fldlg = null;

            }

            catch (System.ArgumentException ae)
            {

                imagename = " ";

                MessageBox.Show(ae.Message.ToString());

            }

            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString());

            }
        }



    }
}

