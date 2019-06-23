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
	public partial class ParentScreen : Form
	{
		public ParentScreen()
		{
			InitializeComponent();
		}

		private void backBtn_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void DoneBtn_Click(object sender, EventArgs e)
		{
			string task = TaskInput.Text + " \r\n";
			string amount = AmountInput.Text + " \r\n";
            Global.Tasks += task + amount;
            OutputTask.Text += task;
			OutputAmount.Text += amount;
			TaskInput.Text = String.Empty;
			AmountInput.Text = String.Empty;
		}

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            OutputTask.Text = "";
            OutputAmount.Text = "";
            Global.Tasks = "";
        }
    }
}
