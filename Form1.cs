using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SquareCalculatorApp
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void bnt_calculate_Click(object sender, EventArgs e)
		{
			int lowerLimit = 0;
			int upperLimit = 10;
			int countBy = 1;

			listBox1.Items.Clear();

			try
			{
				lowerLimit = int.Parse(txt_lowerLimit.Text);
				upperLimit = int.Parse(txt_upperLimit.Text);
				countBy = int.Parse(txt_countBy.Text);

				if (lowerLimit > upperLimit)
				{
					//swap
					int temp = lowerLimit;
					lowerLimit = upperLimit;
					upperLimit = temp;
				}
			

			for (int i = lowerLimit; i <= upperLimit; i = i + countBy)
			{
				listBox1.Items.Add($"Number: {i} Squared: {i * i}");
			}
			}
			catch
			{ 

			}
			
		}
	}
}
