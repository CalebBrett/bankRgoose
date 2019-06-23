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
		int qNum = 0;

		public Scenario()
		{
			InitializeComponent();
			if(Global.Building == "House")
				Question.Text = "You need food to eat for the week, which option would you choose?\r\nA) Eat out every day\r\nB) Just buy groceries and make your own food\r\nC) Eat out half of the week and buy groceries for the rest\r\n";
			if (Global.Building == "Bank")
				Question.Text = "Bank Question";
		}

		private void A_Click(object sender, EventArgs e)
		{
			if (qNum == 2)
				Global.Money++;
			answer();
		}

		private void B_Click(object sender, EventArgs e)
		{
			if(qNum == 0)
				Global.Money++;
			answer();
		}

		private void C_Click(object sender, EventArgs e)
		{
			answer();
		}

		private void D_Click(object sender, EventArgs e)
		{
			if (qNum == 1)
				Global.Money++;
			answer();
		}

		private void answer()
		{
			if (answered)
			{
				if (qNum > 1)
					this.Close();
				A.BackColor = C.BackColor;
				B.BackColor = C.BackColor;
				D.BackColor = C.BackColor;
				switch (qNum)
				{
					case 0:
						Question.Text = "QUESTION 2";
						break;
					case 1:
						Question.Text = "QUestion 3";
						break;
					default:
						break;
				}
				answered = false;
				qNum++;
			}
			else
			{
				switch (qNum)
				{
					case 0:
						B.BackColor = Color.Lime;
						Question.Text += "Answer: To save the most money you should just buy groceries and make your own food because eating out is expensive";
						break;
					case 1:
						D.BackColor = Color.Lime;
						Question.Text += "ANSwREDDD HERERE! OR EXPLINATION";
						break;
					case 2:
						A.BackColor = Color.Lime;
						Question.Text += "ANSwRE HEREREAAA OR EXPLINATION";
						break;
					default:
						break;
				}
				answered = true;
			}
		}
	}
}
