using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Robocon2014
{
    public partial class shabaash : Form
    {
        string win,s1,s2,s3,t1,t2;
        int flag;
        public shabaash(string sh,int fg)
        {
            InitializeComponent();
            textBox2.Text = sh;
            flag = fg;
        }

        private void shabaash_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            win = textBox2.Text;
            Form winner = new winner(win,flag);
            winner.Show();
            this.Close();
        }

        private void Finish_Click(object sender, EventArgs e)
        {
            Form game = new game(s1, s2, s3, t1, t2,flag);
            game.Close();
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtShabaash_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblShabaash.Visible = lblShabaash.Visible == true ? false : true;
        }
    }
}
