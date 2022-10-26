using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q1
{
	public partial class Exec2_TextBox_Q1 : Form
	{
		public Exec2_TextBox_Q1()
		{
			InitializeComponent();
		}

		private void numberButton_Click(object sender, EventArgs e)
		{
			string input = numberTextBox.Text;
			bool isInt = int.TryParse(input, out int value);
			if (isInt == false) 
			{
				MessageBox.Show("請輸入數字");
				return;
			}else if(value <1 || value > 99)
			{
				MessageBox.Show("請輸入介於1~99的數值");
				return;
			}else
			{
				MessageBox.Show($"{value} 介於1~99");
				return;
			}

			
		}
	}
}
