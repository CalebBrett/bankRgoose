﻿using System;
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
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void childBtn_Click(object sender, EventArgs e)
		{
			ChildScreen childScreen = new ChildScreen();
			childScreen.Location = this.Location;
            childScreen.Size = this.Size;
            childScreen.Show();
		}
		private void parentBtn_Click(object sender, EventArgs e)
		{
			ParentScreen parentScreen = new ParentScreen();
			parentScreen.Location = this.Location;
            parentScreen.Size = this.Size;
            parentScreen.Show();
		}
	}
}
