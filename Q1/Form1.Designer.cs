﻿namespace Q1
{
	partial class Exec2_TextBox_Q1
	{
		/// <summary>
		/// 設計工具所需的變數。
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// 清除任何使用中的資源。
		/// </summary>
		/// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form 設計工具產生的程式碼

		/// <summary>
		/// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
		/// 這個方法的內容。
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.numberTextBox = new System.Windows.Forms.TextBox();
			this.numberButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(69, 40);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(89, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入1~99的數";
			// 
			// numberTextBox
			// 
			this.numberTextBox.Location = new System.Drawing.Point(71, 55);
			this.numberTextBox.Name = "numberTextBox";
			this.numberTextBox.Size = new System.Drawing.Size(100, 22);
			this.numberTextBox.TabIndex = 1;
			// 
			// numberButton
			// 
			this.numberButton.Location = new System.Drawing.Point(177, 55);
			this.numberButton.Name = "numberButton";
			this.numberButton.Size = new System.Drawing.Size(75, 23);
			this.numberButton.TabIndex = 2;
			this.numberButton.Text = "確認";
			this.numberButton.UseVisualStyleBackColor = true;
			this.numberButton.Click += new System.EventHandler(this.numberButton_Click);
			// 
			// Exec2_TextBox_Q1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(318, 131);
			this.Controls.Add(this.numberButton);
			this.Controls.Add(this.numberTextBox);
			this.Controls.Add(this.label1);
			this.Name = "Exec2_TextBox_Q1";
			this.Text = "Exec2_TextBox_Q1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox numberTextBox;
		private System.Windows.Forms.Button numberButton;
	}
}

