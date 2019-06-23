namespace Allowance
{
	partial class Game
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Game));
			this.label1 = new System.Windows.Forms.Label();
			this.player = new System.Windows.Forms.PictureBox();
			this.Bank = new System.Windows.Forms.PictureBox();
			this.House = new System.Windows.Forms.PictureBox();
			this.Money = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.Bank)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(744, 97);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(46, 17);
			this.label1.TabIndex = 2;
			this.label1.Text = "label1";
			// 
			// player
			// 
			this.player.Image = global::Allowance.Properties.Resources.Player;
			this.player.InitialImage = ((System.Drawing.Image)(resources.GetObject("player.InitialImage")));
			this.player.Location = new System.Drawing.Point(45, 301);
			this.player.Name = "player";
			this.player.Size = new System.Drawing.Size(114, 187);
			this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.player.TabIndex = 0;
			this.player.TabStop = false;
			// 
			// Bank
			// 
			this.Bank.BackColor = System.Drawing.Color.Transparent;
			this.Bank.Location = new System.Drawing.Point(385, 46);
			this.Bank.Name = "Bank";
			this.Bank.Size = new System.Drawing.Size(230, 233);
			this.Bank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.Bank.TabIndex = 1;
			this.Bank.TabStop = false;
			// 
			// House
			// 
			this.House.BackColor = System.Drawing.Color.Transparent;
			this.House.Location = new System.Drawing.Point(45, 46);
			this.House.Name = "House";
			this.House.Size = new System.Drawing.Size(178, 233);
			this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.House.TabIndex = 3;
			this.House.TabStop = false;
			// 
			// Money
			// 
			this.Money.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Money.BackColor = System.Drawing.Color.Transparent;
			this.Money.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Money.Location = new System.Drawing.Point(555, 9);
			this.Money.Name = "Money";
			this.Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.Money.Size = new System.Drawing.Size(527, 61);
			this.Money.TabIndex = 4;
			this.Money.Text = "0$";
			this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// Game
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackgroundImage = global::Allowance.Properties.Resources.background;
			this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
			this.ClientSize = new System.Drawing.Size(1083, 500);
			this.Controls.Add(this.Money);
			this.Controls.Add(this.player);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.Bank);
			this.Controls.Add(this.House);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Game";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Game";
			this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
			((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.Bank)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.PictureBox player;
		private System.Windows.Forms.PictureBox Bank;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox House;
		private System.Windows.Forms.Label Money;
	}
}