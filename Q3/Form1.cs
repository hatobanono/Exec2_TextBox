using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q3
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void birthdayButton_Click(object sender, EventArgs e)
		{
			
			string input = birthdayTextBox.Text;
			try
			{
				DateTime birthday = GetBirthday(input);
				string msg = GetYearsOld(birthday);
				MessageBox.Show(msg);
	
			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private string GetYearsOld(DateTime birthday)
		{
			DateTime now = DateTime.Now;
			if (birthday > now)
			{
				throw new Exception("生日不可大於今天");
			}
			TimeSpan timeSpan = now - birthday.AddYears(13);
			double years = timeSpan.TotalDays;
			return years < 0 ? "還未滿13歲" : "已經13歲了";
		}

		private DateTime GetBirthday(string input)
		{
			string[] strings = input.Split('/');
			if(strings.Length != 3)
			{
				throw new Exception("請輸入正確的生日");
			}
			int[] ints = new int[strings.Length];
			for(int i=0; i< strings.Length; i++)
			{
				bool isInt = int.TryParse(strings[i], out ints[i]);
				if (isInt == false) 
				{
					throw new Exception("請輸入數字");
				}

			}
			return new DateTime(ints[0], ints[1], ints[2]);
		}
	}
}
