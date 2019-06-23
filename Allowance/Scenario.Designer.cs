namespace Allowance
{
	partial class Scenario
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
			this.D = new System.Windows.Forms.Button();
			this.C = new System.Windows.Forms.Button();
			this.A = new System.Windows.Forms.Button();
			this.B = new System.Windows.Forms.Button();
			this.Question = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// D
			// 
			this.D.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.D.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.D.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.D.Location = new System.Drawing.Point(820, 331);
			this.D.Name = "D";
			this.D.Size = new System.Drawing.Size(216, 125);
			this.D.TabIndex = 2;
			this.D.Text = "D";
			this.D.UseVisualStyleBackColor = false;
			this.D.Click += new System.EventHandler(this.D_Click);
			// 
			// C
			// 
			this.C.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.C.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.C.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.C.Location = new System.Drawing.Point(565, 331);
			this.C.Name = "C";
			this.C.Size = new System.Drawing.Size(216, 125);
			this.C.TabIndex = 3;
			this.C.Text = "C";
			this.C.UseVisualStyleBackColor = false;
			this.C.Click += new System.EventHandler(this.C_Click);
			// 
			// A
			// 
			this.A.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.A.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.A.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.A.Location = new System.Drawing.Point(46, 331);
			this.A.Name = "A";
			this.A.Size = new System.Drawing.Size(216, 125);
			this.A.TabIndex = 5;
			this.A.Text = "A";
			this.A.UseVisualStyleBackColor = false;
			this.A.Click += new System.EventHandler(this.A_Click);
			// 
			// B
			// 
			this.B.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.B.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.B.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.B.Location = new System.Drawing.Point(307, 331);
			this.B.Name = "B";
			this.B.Size = new System.Drawing.Size(216, 125);
			this.B.TabIndex = 4;
			this.B.Text = "B";
			this.B.UseVisualStyleBackColor = false;
			this.B.Click += new System.EventHandler(this.B_Click);
			// 
			// Question
			// 
			this.Question.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
			this.Question.Font = new System.Drawing.Font("Microsoft YaHei", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Question.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.Question.Location = new System.Drawing.Point(46, 40);
			this.Question.Multiline = true;
			this.Question.Name = "Question";
			this.Question.Size = new System.Drawing.Size(990, 249);
			this.Question.TabIndex = 6;
			// 
			// Scenario
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
			this.ClientSize = new System.Drawing.Size(1083, 500);
			this.Controls.Add(this.Question);
			this.Controls.Add(this.A);
			this.Controls.Add(this.B);
			this.Controls.Add(this.C);
			this.Controls.Add(this.D);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Scenario";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "Scenatio";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button D;
		private System.Windows.Forms.Button C;
		private System.Windows.Forms.Button A;
		private System.Windows.Forms.Button B;
		private System.Windows.Forms.TextBox Question;
	}
}