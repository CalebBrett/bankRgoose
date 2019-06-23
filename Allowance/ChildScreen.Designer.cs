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
            this.chores = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
            this.backBtn.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.backBtn.Location = new System.Drawing.Point(69, 525);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(382, 195);
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
            this.playBtn.Location = new System.Drawing.Point(556, 525);
            this.playBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.playBtn.Name = "playBtn";
            this.playBtn.Size = new System.Drawing.Size(986, 195);
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
            this.Money.Location = new System.Drawing.Point(738, 14);
            this.Money.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Money.Name = "Money";
            this.Money.Size = new System.Drawing.Size(801, 97);
            this.Money.TabIndex = 2;
            this.Money.Text = "0$";
            this.Money.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // chores
            // 
            this.chores.BackColor = System.Drawing.Color.Black;
            this.chores.Font = new System.Drawing.Font("Microsoft YaHei", 19.875F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chores.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.chores.Location = new System.Drawing.Point(69, 196);
            this.chores.Multiline = true;
            this.chores.Name = "chores";
            this.chores.Size = new System.Drawing.Size(707, 264);
            this.chores.TabIndex = 3;
            this.chores.Text = "\r\n";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft YaHei", 22.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.label1.Location = new System.Drawing.Point(68, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(444, 78);
            this.label1.TabIndex = 4;
            this.label1.Text = "Chores To-Do";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
            this.label2.Location = new System.Drawing.Point(1166, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(376, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Money Earned";
            // 
            // ChildScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
            this.ClientSize = new System.Drawing.Size(1620, 781);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chores);
            this.Controls.Add(this.Money);
            this.Controls.Add(this.playBtn);
            this.Controls.Add(this.backBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ChildScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "ChildScreen";
            this.ResumeLayout(false);
            this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.Button playBtn;
		private System.Windows.Forms.Label Money;
        private System.Windows.Forms.TextBox chores;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}