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
            this.Money = new System.Windows.Forms.Label();
            this.player = new System.Windows.Forms.PictureBox();
            this.Bank = new System.Windows.Forms.PictureBox();
            this.House = new System.Windows.Forms.PictureBox();
            this.Store = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store)).BeginInit();
            this.SuspendLayout();
            // 
            // Money
            // 
            this.Money.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.Money.BackColor = System.Drawing.Color.Transparent;
            this.Money.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Money.Location = new System.Drawing.Point(1007, 643);
            this.Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Money.Name = "Money";
            this.Money.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.Money.Size = new System.Drawing.Size(465, 95);
            this.Money.TabIndex = 4;
            this.Money.Text = "0$";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("player.BackgroundImage")));
            this.player.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.player.Location = new System.Drawing.Point(68, 479);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(233, 247);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.player.TabIndex = 5;
            this.player.TabStop = false;
            // 
            // Bank
            // 
            this.Bank.BackColor = System.Drawing.Color.Transparent;
            this.Bank.Location = new System.Drawing.Point(578, 72);
            this.Bank.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Bank.Name = "Bank";
            this.Bank.Size = new System.Drawing.Size(345, 364);
            this.Bank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Bank.TabIndex = 1;
            this.Bank.TabStop = false;
            // 
            // House
            // 
            this.House.BackColor = System.Drawing.Color.Transparent;
            this.House.Location = new System.Drawing.Point(114, 72);
            this.House.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.House.Name = "House";
            this.House.Size = new System.Drawing.Size(267, 364);
            this.House.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.House.TabIndex = 3;
            this.House.TabStop = false;
            // 
            // Store
            // 
            this.Store.BackColor = System.Drawing.Color.Transparent;
            this.Store.Location = new System.Drawing.Point(1166, 141);
            this.Store.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Store.Name = "Store";
            this.Store.Size = new System.Drawing.Size(277, 295);
            this.Store.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.Store.TabIndex = 6;
            this.Store.TabStop = false;
            // 
            // Game
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(192F, 192F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImage = global::Allowance.Properties.Resources.background;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1624, 781);
            this.Controls.Add(this.player);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.House);
            this.Controls.Add(this.Bank);
            this.Controls.Add(this.Store);
            this.ForeColor = System.Drawing.Color.CornflowerBlue;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "Game";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Game";
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Game_KeyPress);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Bank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.House)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Store)).EndInit();
            this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.PictureBox Bank;
		private System.Windows.Forms.PictureBox House;
		private System.Windows.Forms.Label Money;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox Store;
    }
}