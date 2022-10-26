using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Q4
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
			resultLabel.Text = "";
		}

		private void resultButton_Click(object sender, EventArgs e)
		{
			string inputPeople = peopleTextBox.Text;
			string inputcars = carsTextBox.Text;
			try
			{
				int people = GetInt(inputPeople);
				int cars = GetInt(inputcars);
				string fee = CalcFee(people, cars);
				resultLabel.Text = fee;

			}
			catch(Exception ex)
			{
				MessageBox.Show(ex.Message);
				return;
			}
		}

		private string CalcFee(int people, int cars)
		{
			if (people <= 0 || cars < 0)
			{
				throw new Exception("請輸入正整數");
			}
			int peopleFee = people * 60;
			int carsFee = cars * 200;
			string result = $"車輛共 {carsFee} 元\r\n人數共 {peopleFee} 元\r\n";
			if(peopleFee < carsFee)
			{
				result += "按人頭計費";
			}
			else
			{
				result += "按車輛計費";
			}
			return result;
		}

		private int GetInt(string input)
		{
			bool isInt = int.TryParse(input, out int result);
			return isInt ? result : throw new Exception("請輸入數字");
		}
	}
}
