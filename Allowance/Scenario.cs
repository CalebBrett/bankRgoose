using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Allowance
{
	public partial class Scenario : Form
	{
		bool answered = false;

        public Scenario()
		{
			InitializeComponent();
			if(Global.Building == "House")          //QUESTION BELOW
            {
                Question.Text = "You ran out of snacks! Where will you go to buy some more?\r\nA) Caleb's food emporium : $7\r\nB) Juliette's Convenience : $8\r\nC) James' Store : $5\r\nD) Costco : $30\r\n";
            }
            if (Global.Building == "Bank")
            {
                Question.Text = "Your friends ask you to go shopping and you need spending money; What do you decide?\r\nA) Take 50$ and spend it all.\r\nB) Take $20 and spend it all.\r\nC) Save your money and spend it later on something you want.\r\nD) Take $50 and split it between this week and next week.\r\n";
            }
            if (Global.Building == "Store")
            {
                Question.Text = "The video game you want just went on sale, but Mother's day is coming up.\r\nA)Buy the video game.\r\nB) Buy your Mother an extravagant gift.\r\nC)Without spending money, show appreciation in other ways.\r\nD)Take her out for brunch.\r\n";
            }
        }

		private void A_Click(object sender, EventArgs e)
		{
            if(!answered)
                Global.Money -= 10;
            answer();
		}

		private void B_Click(object sender, EventArgs e)
		{
            if (!answered)
                Global.Money -= 10;
            answer();
		}

		private void C_Click(object sender, EventArgs e)
		{
            if (!answered)
                Global.Money += 10;
            answer();
		}

		private void D_Click(object sender, EventArgs e)
		{
            if (!answered)
                Global.Money -= 10;
            answer();
		}

		private void answer()
		{
            if (answered)
	    		this.Close();
            C.BackColor = Color.Lime;
            A.BackColor = Color.DarkRed;
            B.BackColor = Color.DarkRed;
            D.BackColor = Color.DarkRed;

            answered = true;
		}
	}
}
