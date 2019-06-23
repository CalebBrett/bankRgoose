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

		const int moveDistance = 50;

		public Game()
		{
			InitializeComponent();
			Money.Text = Global.Money.ToString() + "$";
        }

		private void Game_KeyPress(object sender, KeyPressEventArgs e)
		{
            Money.Text = Global.Money.ToString() + "$";

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
                else if (player.Location.Y <= Store.Location.Y + Store.Height / 2 && isColliding(Store))
                {
                    Global.Building = "Store";
                    buildingAction();
                }
                if (player.Location.Y > Bank.Location.Y + Bank.Height/2)
					player.Top -= moveDistance;
			}
			else if (e.KeyChar == 'd')
			{
                player.BackgroundImage = Allowance.Properties.Resources.goose_forward;
                player.Left += moveDistance;
			}
			else if (e.KeyChar == 'a')
			{
                player.BackgroundImage = Allowance.Properties.Resources.goose_backwards;
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
            scenario.Size = this.Size;
            scenario.Show();
            Money.Text = Global.Money.ToString() + "$";
            this.Close();
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
