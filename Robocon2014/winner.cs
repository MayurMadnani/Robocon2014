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
    public partial class winner : Form
    {
        string s1, s2,s3,t1,t2;
        int flag;
        public winner(string winner,int fg)
        {
            InitializeComponent();
            txtwinner.Text = winner;
            txtwinner2.Text = winner;
            flag = fg;
            if(flag==0)
            {
                lblwinner.Text = "WINNER!";
            }
            else if(flag==1)
            {
                lblwinner.Text = "WINNER Of International Robocon 2014";
                
            }
        }

        private void winner_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form game = new game(s1, s2, s3,t1,t2,flag);
            game.Close();
            this.Close();

        }

        private void txtwinner_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            txtwinner2.Visible = txtwinner2.Visible == true ? false : true;
        }

       
    }
}
