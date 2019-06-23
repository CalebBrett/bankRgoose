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
                switch (Global.HouseCount)
                {
                    case 0:
                        Question.Text = "You ran out of snacks! Where will you go to buy some more?\r\nA) Caleb's food emporium : $7\r\nB) Juliette's Convenience : $8\r\nC) James' Convenience : $5\r\nD) I don't know\r\n";
                        break;
                    case 1:
                        Question.Text = "You're hungry for some candy, what will you choose?\r\nA) 1 for $3\r\nB) 2 for $4\r\nC) 3 for $5\r\nD) I don't know\r\n";
                        break;
                    case 2:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Eat out half of the week and buy groceries for the rest\r\nC) Just buy groceries and make your own food\r\nD) I don't know\r\n";
                        break;
                    default:
                        break;
                }
                Global.HouseCount++;
            }
            if (Global.Building == "Bank")
            {
                switch (Global.BankCount)
                {
                    case 0:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    case 1:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    case 2:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    default:
                        break;
                }
                Global.BankCount++;
            }
            if (Global.Building == "Store")
            {
                switch (Global.StoreCount)
                {
                    case 0:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    case 1:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    case 2:
                        Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\nD) I don't know\r\n";
                        break;
                    default:
                        break;
                }
                Global.StoreCount++;
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

		private void answer()                                   //ANSWERES BELOW
		{
            if (answered)
	    		this.Close();
            C.BackColor = Color.Lime;
            if (Global.Building == "House")
            {
                switch (Global.HouseCount)
                {
                    case 0:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    case 1:
                        Question.Text += " 3 for $5\r\n";
                        break;
                    case 2:
                        Question.Text += " Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    default:
                        break;
                }
            }
            if (Global.Building == "Bank")
            {
                switch (Global.BankCount)
                {
                    case 0:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    case 1:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    case 2:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    default:
                        break;
                }
            }
            if (Global.Building == "Shop")
            {
                switch (Global.StoreCount)
                {
                    case 0:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    case 1:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    case 2:
                        Question.Text += "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
                        break;
                    default:
                        break;
                }
            }
            answered = true;
		}
	}
}
