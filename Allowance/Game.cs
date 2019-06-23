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
	public partial class Game : Form
	{

		const int moveDistance = 20;

		public Game()
		{
			InitializeComponent();
			Money.Text = Global.Money.ToString() + "$";
		}

		private void Game_KeyPress(object sender, KeyPressEventArgs e)
		{
			if(e.KeyChar == 'p')
			{
				this.Close();
			}
			if(e.KeyChar == 'w')
			{
				if (player.Location.Y <= Bank.Location.Y + Bank.Height / 2 && isColliding(Bank))
				{
					Global.Building = "Bank";
					buildingAction();
				}
				else if (player.Location.Y <= House.Location.Y + House.Height / 2 && isColliding(House))
				{
					Global.Building = "House";
					buildingAction();
				}
				if (player.Location.Y > Bank.Location.Y + Bank.Height/2)
					player.Top -= moveDistance;
			}
			else if (e.KeyChar == 'd')
			{
				player.Left += moveDistance;
			}
			else if (e.KeyChar == 'a')
			{
				player.Left -= moveDistance;
			}
			else if (e.KeyChar == 's')
			{
				player.Top += moveDistance;
			}
		}

		private void buildingAction()
		{
			Scenario scenario = new Scenario();
			scenario.Location = this.Location;
			scenario.Show();
		}

		private bool isColliding(PictureBox building)
		{
			if (player.Location.X > building.Location.X && player.Location.X < building.Location.X + building.Width)
				return true;
			if(player.Location.X + player.Width > building.Location.X && player.Location.X + player.Width < building.Location.X + building.Width)
				return true;
			return false;
		}
	}
}
