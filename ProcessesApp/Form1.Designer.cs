﻿namespace ProcessesApp
{
	partial class Form1
	{
		/// <summary>
		///  Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		///  Clean up any resources being used.
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
		///  Required method for Designer support - do not modify
		///  the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.textBox1 = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label_id = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label_processor = new System.Windows.Forms.Label();
			this.label_count = new System.Windows.Forms.Label();
			this.label_copy = new System.Windows.Forms.Label();
			this.label_start = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// listBox1
			// 
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 15;
			this.listBox1.Location = new System.Drawing.Point(30, 59);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(783, 379);
			this.listBox1.TabIndex = 0;
			this.listBox1.SelectedIndexChanged += new System.EventHandler(this.listBox1_SelectedIndexChanged);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 5000;
			this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
			// 
			// textBox1
			// 
			this.textBox1.Location = new System.Drawing.Point(5, 12);
			this.textBox1.Name = "textBox1";
			this.textBox1.Size = new System.Drawing.Size(100, 23);
			this.textBox1.TabIndex = 1;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(161, 12);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 2;
			this.button1.Text = "button1";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(880, 61);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(144, 15);
			this.label1.TabIndex = 3;
			this.label1.Text = "информация о процессе";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(836, 112);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(65, 15);
			this.label2.TabIndex = 4;
			this.label2.Text = "Processl_id";
			// 
			// label_id
			// 
			this.label_id.AutoSize = true;
			this.label_id.Location = new System.Drawing.Point(974, 127);
			this.label_id.Name = "label_id";
			this.label_id.Size = new System.Drawing.Size(0, 15);
			this.label_id.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(836, 155);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(58, 15);
			this.label3.TabIndex = 6;
			this.label3.Text = "Start time";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Location = new System.Drawing.Point(836, 200);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(84, 15);
			this.label4.TabIndex = 7;
			this.label4.Text = "ProcessorTime";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Location = new System.Drawing.Point(836, 278);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(75, 15);
			this.label5.TabIndex = 8;
			this.label5.Text = "ProcessCopy";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Location = new System.Drawing.Point(836, 242);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(76, 15);
			this.label6.TabIndex = 9;
			this.label6.Text = "ThreadCount";
			// 
			// label_processor
			// 
			this.label_processor.AutoSize = true;
			this.label_processor.Location = new System.Drawing.Point(940, 200);
			this.label_processor.Name = "label_processor";
			this.label_processor.Size = new System.Drawing.Size(0, 15);
			this.label_processor.TabIndex = 10;
			// 
			// label_count
			// 
			this.label_count.AutoSize = true;
			this.label_count.Location = new System.Drawing.Point(948, 242);
			this.label_count.Name = "label_count";
			this.label_count.Size = new System.Drawing.Size(0, 15);
			this.label_count.TabIndex = 11;
			// 
			// label_copy
			// 
			this.label_copy.AutoSize = true;
			this.label_copy.Location = new System.Drawing.Point(949, 278);
			this.label_copy.Name = "label_copy";
			this.label_copy.Size = new System.Drawing.Size(0, 15);
			this.label_copy.TabIndex = 12;
			// 
			// label_start
			// 
			this.label_start.AutoSize = true;
			this.label_start.Location = new System.Drawing.Point(940, 155);
			this.label_start.Name = "label_start";
			this.label_start.Size = new System.Drawing.Size(0, 15);
			this.label_start.TabIndex = 13;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1067, 450);
			this.Controls.Add(this.label_start);
			this.Controls.Add(this.label_copy);
			this.Controls.Add(this.label_count);
			this.Controls.Add(this.label_processor);
			this.Controls.Add(this.label6);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label_id);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.textBox1);
			this.Controls.Add(this.listBox1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.Form1_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private ListBox listBox1;
		private System.Windows.Forms.Timer timer1;
		private TextBox textBox1;
		private Button button1;
		private Label label1;
		private Label label2;
		private Label label_id;
		private Label label3;
		private Label label4;
		private Label label5;
		private Label label6;
		private Label label_processor;
		private Label label_count;
		private Label label_copy;
		private Label label_start;
	}
}