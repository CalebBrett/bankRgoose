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
            this.SuspendLayout();
            // 
            // backBtn
            // 
            this.backBtn.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backBtn.Location = new System.Drawing.Point(50, 653);
            this.backBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.backBtn.Name = "backBtn";
            this.backBtn.Size = new System.Drawing.Size(216, 86);
            this.backBtn.TabIndex = 0;
            this.backBtn.Text = "Back";
            this.backBtn.UseVisualStyleBackColor = true;
            this.backBtn.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // TaskInput
            // 
            this.TaskInput.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TaskInput.Location = new System.Drawing.Point(105, 108);
            this.TaskInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.TaskInput.Multiline = true;
            this.TaskInput.Name = "TaskInput";
            this.TaskInput.Size = new System.Drawing.Size(828, 56);
            this.TaskInput.TabIndex = 1;
            // 
            // AmountInput
            // 
            this.AmountInput.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.AmountInput.Location = new System.Drawing.Point(1050, 108);
            this.AmountInput.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.AmountInput.Multiline = true;
            this.AmountInput.Name = "AmountInput";
            this.AmountInput.Size = new System.Drawing.Size(198, 56);
            this.AmountInput.TabIndex = 2;
            // 
            // Task
            // 
            this.Task.AutoSize = true;
            this.Task.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Task.Location = new System.Drawing.Point(1041, 39);
            this.Task.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Task.Name = "Task";
            this.Task.Size = new System.Drawing.Size(215, 50);
            this.Task.TabIndex = 3;
            this.Task.Text = "Amount: ($)";
            // 
            // DoneBtn
            // 
            this.DoneBtn.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.DoneBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DoneBtn.Font = new System.Drawing.Font("Nirmala UI", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DoneBtn.Location = new System.Drawing.Point(1318, 108);
            this.DoneBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.DoneBtn.Name = "DoneBtn";
            this.DoneBtn.Size = new System.Drawing.Size(156, 58);
            this.DoneBtn.TabIndex = 4;
            this.DoneBtn.Text = "DONE";
            this.DoneBtn.UseVisualStyleBackColor = false;
            this.DoneBtn.Click += new System.EventHandler(this.DoneBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(96, 39);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 50);
            this.label1.TabIndex = 5;
            this.label1.Text = "Task:";
            // 
            // OutputTask
            // 
            this.OutputTask.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputTask.Location = new System.Drawing.Point(105, 255);
            this.OutputTask.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputTask.Multiline = true;
            this.OutputTask.Name = "OutputTask";
            this.OutputTask.Size = new System.Drawing.Size(828, 356);
            this.OutputTask.TabIndex = 6;
            // 
            // OutputAmount
            // 
            this.OutputAmount.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OutputAmount.Location = new System.Drawing.Point(1050, 255);
            this.OutputAmount.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.OutputAmount.Multiline = true;
            this.OutputAmount.Name = "OutputAmount";
            this.OutputAmount.Size = new System.Drawing.Size(198, 356);
            this.OutputAmount.TabIndex = 7;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.Location = new System.Drawing.Point(1318, 256);
            this.checkBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(213, 54);
            this.checkBox1.TabIndex = 8;
            this.checkBox1.Text = "Complete";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(96, 186);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 50);
            this.label2.TabIndex = 9;
            this.label2.Text = "Log:";
            // 
            // ParentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(1624, 781);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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
	}
}