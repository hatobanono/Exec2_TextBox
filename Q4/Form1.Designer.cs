namespace Q4
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
			this.peopleTextBox = new System.Windows.Forms.TextBox();
			this.label2 = new System.Windows.Forms.Label();
			this.carsTextBox = new System.Windows.Forms.TextBox();
			this.resultButton = new System.Windows.Forms.Button();
			this.resultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label1.Location = new System.Drawing.Point(13, 15);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(34, 17);
			this.label1.TabIndex = 0;
			this.label1.Text = "人數";
			// 
			// peopleTextBox
			// 
			this.peopleTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.peopleTextBox.Location = new System.Drawing.Point(52, 12);
			this.peopleTextBox.Name = "peopleTextBox";
			this.peopleTextBox.Size = new System.Drawing.Size(100, 25);
			this.peopleTextBox.TabIndex = 1;
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.label2.Location = new System.Drawing.Point(13, 43);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(34, 17);
			this.label2.TabIndex = 0;
			this.label2.Text = "車數";
			// 
			// carsTextBox
			// 
			this.carsTextBox.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.carsTextBox.Location = new System.Drawing.Point(52, 40);
			this.carsTextBox.Name = "carsTextBox";
			this.carsTextBox.Size = new System.Drawing.Size(100, 25);
			this.carsTextBox.TabIndex = 1;
			// 
			// resultButton
			// 
			this.resultButton.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultButton.Location = new System.Drawing.Point(158, 12);
			this.resultButton.Name = "resultButton";
			this.resultButton.Size = new System.Drawing.Size(69, 77);
			this.resultButton.TabIndex = 3;
			this.resultButton.Text = "確認費用";
			this.resultButton.UseVisualStyleBackColor = true;
			this.resultButton.Click += new System.EventHandler(this.resultButton_Click);
			// 
			// resultLabel
			// 
			this.resultLabel.Font = new System.Drawing.Font("微軟正黑體", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(136)));
			this.resultLabel.Location = new System.Drawing.Point(15, 68);
			this.resultLabel.Name = "resultLabel";
			this.resultLabel.Size = new System.Drawing.Size(137, 63);
			this.resultLabel.TabIndex = 4;
			this.resultLabel.Text = "resultLabel";
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(245, 182);
			this.Controls.Add(this.resultLabel);
			this.Controls.Add(this.resultButton);
			this.Controls.Add(this.carsTextBox);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.peopleTextBox);
			this.Controls.Add(this.label1);
			this.Name = "Form1";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox peopleTextBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox carsTextBox;
		private System.Windows.Forms.Button resultButton;
		private System.Windows.Forms.Label resultLabel;
	}
}

