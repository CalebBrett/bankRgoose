namespace Allowance
{
	partial class ParentScreen
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
			this.TaskInput = new System.Windows.Forms.TextBox();
			this.AmountInput = new System.Windows.Forms.TextBox();
			this.Task = new System.Windows.Forms.Label();
			this.DoneBtn = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.OutputTask = new System.Windows.Forms.TextBox();
			this.OutputAmount = new System.Windows.Forms.TextBox();
			this.checkBox1 = new System.Windows.Forms.CheckBox();
			this.label2 = new System.Windows.Forms.Label();
			this.checkBox2 = new System.Windows.Forms.CheckBox();
			this.checkBox3 = new System.Windows.Forms.CheckBox();
			this.checkBox4 = new System.Windows.Forms.CheckBox();
			this.checkBox5 = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// backBtn
			// 
			this.backBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.backBtn.Location = new System.Drawing.Point(33, 418);
			this.backBtn.Name = "backBtn";
			this.backBtn.Size = new System.Drawing.Size(144, 55);
			this.backBtn.TabIndex = 0;
			this.backBtn.Text = "Back";
			this.backBtn.UseVisualStyleBackColor = true;
			this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
			// 
			// TaskInput
			// 
			this.TaskInput.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.TaskInput.Location = new System.Drawing.Point(70, 69);
			this.TaskInput.Multiline = true;
			this.TaskInput.Name = "TaskInput";
			this.TaskInput.Size = new System.Drawing.Size(553, 37);
			this.TaskInput.TabIndex = 1;
			// 
			// AmountInput
			// 
			this.AmountInput.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.AmountInput.Location = new System.Drawing.Point(700, 69);
			this.AmountInput.Multiline = true;
			this.AmountInput.Name = "AmountInput";
			this.AmountInput.Size = new System.Drawing.Size(133, 37);
			this.AmountInput.TabIndex = 2;
			// 
			// Task
			// 
			this.Task.AutoSize = true;
			this.Task.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Task.Location = new System.Drawing.Point(694, 25);
			this.Task.Name = "Task";
			this.Task.Size = new System.Drawing.Size(140, 32);
			this.Task.TabIndex = 3;
			this.Task.Text = "Amount: ($)";
			// 
			// DoneBtn
			// 
			this.DoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
			this.DoneBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DoneBtn.Location = new System.Drawing.Point(879, 69);
			this.DoneBtn.Name = "DoneBtn";
			this.DoneBtn.Size = new System.Drawing.Size(104, 37);
			this.DoneBtn.TabIndex = 4;
			this.DoneBtn.Text = "DONE";
			this.DoneBtn.UseVisualStyleBackColor = true;
			this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(64, 25);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 32);
			this.label1.TabIndex = 5;
			this.label1.Text = "Task:";
			// 
			// OutputTask
			// 
			this.OutputTask.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputTask.Location = new System.Drawing.Point(70, 163);
			this.OutputTask.Multiline = true;
			this.OutputTask.Name = "OutputTask";
			this.OutputTask.Size = new System.Drawing.Size(553, 229);
			this.OutputTask.TabIndex = 6;
			// 
			// OutputAmount
			// 
			this.OutputAmount.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.OutputAmount.Location = new System.Drawing.Point(700, 163);
			this.OutputAmount.Multiline = true;
			this.OutputAmount.Name = "OutputAmount";
			this.OutputAmount.Size = new System.Drawing.Size(133, 229);
			this.OutputAmount.TabIndex = 7;
			// 
			// checkBox1
			// 
			this.checkBox1.AutoSize = true;
			this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox1.Location = new System.Drawing.Point(879, 164);
			this.checkBox1.Name = "checkBox1";
			this.checkBox1.Size = new System.Drawing.Size(141, 36);
			this.checkBox1.TabIndex = 8;
			this.checkBox1.Text = "Complete";
			this.checkBox1.UseVisualStyleBackColor = true;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(64, 119);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(59, 32);
			this.label2.TabIndex = 9;
			this.label2.Text = "Log:";
			// 
			// checkBox2
			// 
			this.checkBox2.AutoSize = true;
			this.checkBox2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox2.Location = new System.Drawing.Point(879, 206);
			this.checkBox2.Name = "checkBox2";
			this.checkBox2.Size = new System.Drawing.Size(141, 36);
			this.checkBox2.TabIndex = 10;
			this.checkBox2.Text = "Complete";
			this.checkBox2.UseVisualStyleBackColor = true;
			// 
			// checkBox3
			// 
			this.checkBox3.AutoSize = true;
			this.checkBox3.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox3.Location = new System.Drawing.Point(879, 248);
			this.checkBox3.Name = "checkBox3";
			this.checkBox3.Size = new System.Drawing.Size(141, 36);
			this.checkBox3.TabIndex = 11;
			this.checkBox3.Text = "Complete";
			this.checkBox3.UseVisualStyleBackColor = true;
			// 
			// checkBox4
			// 
			this.checkBox4.AutoSize = true;
			this.checkBox4.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox4.Location = new System.Drawing.Point(879, 290);
			this.checkBox4.Name = "checkBox4";
			this.checkBox4.Size = new System.Drawing.Size(141, 36);
			this.checkBox4.TabIndex = 12;
			this.checkBox4.Text = "Complete";
			this.checkBox4.UseVisualStyleBackColor = true;
			// 
			// checkBox5
			// 
			this.checkBox5.AutoSize = true;
			this.checkBox5.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.checkBox5.Location = new System.Drawing.Point(879, 332);
			this.checkBox5.Name = "checkBox5";
			this.checkBox5.Size = new System.Drawing.Size(141, 36);
			this.checkBox5.TabIndex = 13;
			this.checkBox5.Text = "Complete";
			this.checkBox5.UseVisualStyleBackColor = true;
			// 
			// ParentScreen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.ClientSize = new System.Drawing.Size(1083, 500);
			this.Controls.Add(this.checkBox5);
			this.Controls.Add(this.checkBox4);
			this.Controls.Add(this.checkBox3);
			this.Controls.Add(this.checkBox2);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.checkBox1);
			this.Controls.Add(this.OutputAmount);
			this.Controls.Add(this.OutputTask);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.DoneBtn);
			this.Controls.Add(this.Task);
			this.Controls.Add(this.AmountInput);
			this.Controls.Add(this.TaskInput);
			this.Controls.Add(this.backBtn);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Name = "ParentScreen";
			this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
			this.Text = "ParentScreen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button backBtn;
		private System.Windows.Forms.TextBox TaskInput;
		private System.Windows.Forms.TextBox AmountInput;
		private System.Windows.Forms.Label Task;
		private System.Windows.Forms.Button DoneBtn;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox OutputTask;
		private System.Windows.Forms.TextBox OutputAmount;
		private System.Windows.Forms.CheckBox checkBox1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.CheckBox checkBox2;
		private System.Windows.Forms.CheckBox checkBox3;
		private System.Windows.Forms.CheckBox checkBox4;
		private System.Windows.Forms.CheckBox checkBox5;
	}
}