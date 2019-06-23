namespace Allowance
{
	partial class Form1
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
			this.Title = new System.Windows.Forms.Label();
			this.childBtn = new System.Windows.Forms.Button();
			this.parentBtn = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// Title
			// 
			this.Title.AutoSize = true;
			this.Title.Font = new System.Drawing.Font("Microsoft YaHei", 24F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Title.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.Title.Location = new System.Drawing.Point(53, 43);
			this.Title.Name = "Title";
			this.Title.Size = new System.Drawing.Size(452, 52);
			this.Title.TabIndex = 6;
			this.Title.Text = "Allowance Game WIP";
			this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// childBtn
			// 
			this.childBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.childBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.childBtn.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.childBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.childBtn.Location = new System.Drawing.Point(55, 160);
			this.childBtn.Name = "childBtn";
			this.childBtn.Size = new System.Drawing.Size(450, 300);
			this.childBtn.TabIndex = 7;
			this.childBtn.Text = "Player";
			this.childBtn.UseVisualStyleBackColor = false;
			this.childBtn.Click += new System.EventHandler(this.childBtn_Click);
			// 
			// parentBtn
			// 
			this.parentBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(216)))), ((int)(((byte)(30)))), ((int)(((byte)(90)))));
			this.parentBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.parentBtn.Font = new System.Drawing.Font("Microsoft YaHei", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.parentBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(253)))), ((int)(((byte)(240)))), ((int)(((byte)(213)))));
			this.parentBtn.Location = new System.Drawing.Point(574, 160);
			this.parentBtn.Name = "parentBtn";
			this.parentBtn.Size = new System.Drawing.Size(450, 300);
			this.parentBtn.TabIndex = 8;
			this.parentBtn.Text = "Parent";
			this.parentBtn.UseVisualStyleBackColor = false;
			this.parentBtn.Click += new System.EventHandler(this.parentBtn_Click);
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(25)))), ((int)(((byte)(114)))), ((int)(((byte)(120)))));
			this.ClientSize = new System.Drawing.Size(1083, 500);
			this.Controls.Add(this.parentBtn);
			this.Controls.Add(this.childBtn);
			this.Controls.Add(this.Title);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label Title;
		private System.Windows.Forms.Button childBtn;
		private System.Windows.Forms.Button parentBtn;
	}
}

