namespace SquareCalculatorApp
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
			this.bnt_calculate = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.txt_lowerLimit = new System.Windows.Forms.TextBox();
			this.txt_upperLimit = new System.Windows.Forms.TextBox();
			this.listBox1 = new System.Windows.Forms.ListBox();
			this.label3 = new System.Windows.Forms.Label();
			this.txt_countBy = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// bnt_calculate
			// 
			this.bnt_calculate.BackColor = System.Drawing.SystemColors.ActiveCaption;
			this.bnt_calculate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.bnt_calculate.ForeColor = System.Drawing.SystemColors.ControlText;
			this.bnt_calculate.Location = new System.Drawing.Point(24, 20);
			this.bnt_calculate.Name = "bnt_calculate";
			this.bnt_calculate.Size = new System.Drawing.Size(96, 53);
			this.bnt_calculate.TabIndex = 0;
			this.bnt_calculate.Text = "Calculate";
			this.bnt_calculate.UseVisualStyleBackColor = false;
			this.bnt_calculate.Click += new System.EventHandler(this.bnt_calculate_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(127, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(93, 20);
			this.label1.TabIndex = 1;
			this.label1.Text = "Lower Limit:";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(126, 41);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(94, 20);
			this.label2.TabIndex = 2;
			this.label2.Text = "Upper Limit:";
			// 
			// txt_lowerLimit
			// 
			this.txt_lowerLimit.Location = new System.Drawing.Point(236, 20);
			this.txt_lowerLimit.Name = "txt_lowerLimit";
			this.txt_lowerLimit.Size = new System.Drawing.Size(51, 20);
			this.txt_lowerLimit.TabIndex = 3;
			// 
			// txt_upperLimit
			// 
			this.txt_upperLimit.Location = new System.Drawing.Point(236, 41);
			this.txt_upperLimit.Name = "txt_upperLimit";
			this.txt_upperLimit.Size = new System.Drawing.Size(51, 20);
			this.txt_upperLimit.TabIndex = 4;
			// 
			// listBox1
			// 
			this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.listBox1.FormattingEnabled = true;
			this.listBox1.ItemHeight = 20;
			this.listBox1.Location = new System.Drawing.Point(24, 87);
			this.listBox1.Name = "listBox1";
			this.listBox1.Size = new System.Drawing.Size(263, 544);
			this.listBox1.TabIndex = 5;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(126, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(76, 20);
			this.label3.TabIndex = 6;
			this.label3.Text = "Count by:";
			// 
			// txt_countBy
			// 
			this.txt_countBy.Location = new System.Drawing.Point(236, 61);
			this.txt_countBy.Name = "txt_countBy";
			this.txt_countBy.Size = new System.Drawing.Size(51, 20);
			this.txt_countBy.TabIndex = 7;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(310, 686);
			this.Controls.Add(this.txt_countBy);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.listBox1);
			this.Controls.Add(this.txt_upperLimit);
			this.Controls.Add(this.txt_lowerLimit);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.bnt_calculate);
			this.ForeColor = System.Drawing.SystemColors.Desktop;
			this.Name = "Form1";
			this.Text = "Square Calculator";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button bnt_calculate;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox txt_lowerLimit;
		private System.Windows.Forms.TextBox txt_upperLimit;
		private System.Windows.Forms.ListBox listBox1;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.TextBox txt_countBy;
	}
}

