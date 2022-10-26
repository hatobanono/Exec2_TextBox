namespace Q3
{
	partial class Form1
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
			this.birthdayButton = new System.Windows.Forms.Button();
			this.birthdayTextBox = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(49, 21);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(142, 12);
			this.label1.TabIndex = 0;
			this.label1.Text = "請輸入生日 (例2026/10/26)";
			// 
			// birthdayButton
			// 
			this.birthdayButton.Location = new System.Drawing.Point(157, 34);
			this.birthdayButton.Name = "birthdayButton";
			this.birthdayButton.Size = new System.Drawing.Size(75, 23);
			this.birthdayButton.TabIndex = 1;
			this.birthdayButton.Text = "檢查";
			this.birthdayButton.UseVisualStyleBackColor = true;
			this.birthdayButton.Click += new System.EventHandler(this.birthdayButton_Click);
			// 
			// birthdayTextBox
			// 
			this.birthdayTextBox.Location = new System.Drawing.Point(51, 36);
			this.birthdayTextBox.Name = "birthdayTextBox";
			this.birthdayTextBox.Size = new System.Drawing.Size(100, 22);
			this.birthdayTextBox.TabIndex = 2;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(325, 106);
			this.Controls.Add(this.birthdayTextBox);
			this.Controls.Add(this.birthdayButton);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button birthdayButton;
		private System.Windows.Forms.TextBox birthdayTextBox;
	}
}

