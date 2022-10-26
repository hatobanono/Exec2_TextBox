using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q2
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void dateButton_Click(object sender, EventArgs e)
		{
			DateTime today = DateTime.Today;
			string input = dateTextBox.Text;
			try
			{
				DateTime date = GetDate(input);
				TimeSpan result = date - today;
				int days = result.Days;
				string msg = days > 0 ? "大於今天" : "小於等於今天";
				MessageBox.Show(input + msg);
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}

			

		}

		private DateTime GetDate(string input)
		{
			string[] strings = input.Split('/');
			if (strings.Length != 3)
			{
				throw new Exception("請填入正確的日期");
			}
			int[] ints = new int[strings.Length];
			for (int i = 0; i < strings.Length; i++)
			{
				bool isInt = int.TryParse(strings[i], out ints[i]);
				if (isInt == false)
				{
					throw new Exception("請填入正確的日期");					
				}
			}
			return new DateTime(ints[0], ints[1], ints[2]);
		}
	}
}
