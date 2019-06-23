namespace Allowance
{
	partial class ChildScreen
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
			this.backBtn = new System.Windows.Forms.Button();
			this.playBtn = new System.Windows.Forms.Button();
			this.Money = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// backBtn
			// 
			this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.backBtn.Location = new System.Drawing.Point(46, 336);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(255, 125);
			this.backBtn.TabIndex = 0;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = false;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// playBtn
			// 
			this.playBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.playBtn.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.playBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.playBtn.Location = new System.Drawing.Point(371, 336);
			this.playBtn.Name = "playBtn";
			this.playBtn.Size = new System.Drawing.Size(657, 125);
			this.playBtn.TabIndex = 1;
			this.playBtn.Text = "Play";
			this.playBtn.UseVisualStyleBackColor = false;
			this.playBtn.Click += new System.EventHandler(this.playBtn_Click);
			// 
			// Money
			// 
			this.Money.Anchor = System.Windows.Forms.AnchorStyles.Right;
			this.Money.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Money.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.Money.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.Money.Location = new System.Drawing.Point(492, 9);
			this.Money.Name = "Money";
			this.Money.Size = new System.Drawing.Size(534, 62);
			this.Money.TabIndex = 2;
			this.Money.Text = "0$";
			this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
			// 
			// ChildScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
			this.ClientSize = new System.Drawing.Size(1080, 500);
			this.Controls.Add(this.Money);
			this.Controls.Add(this.playBtn);
			this.Controls.Add(this.backBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ChildScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ChildScreen";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Button playBtn;
		private System.Windows.Forms.Label Money;
	}
}