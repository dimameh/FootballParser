namespace FootballParser
{
	partial class FootballParser
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.InfoListBox = new System.Windows.Forms.ListBox();
			this.team1 = new System.Windows.Forms.TextBox();
			this.buttonStart = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.team2 = new System.Windows.Forms.TextBox();
			this.buttonStop = new System.Windows.Forms.Button();
			this.testbox = new System.Windows.Forms.RichTextBox();
			this.SuspendLayout();
			// 
			// InfoListBox
			// 
			this.InfoListBox.FormattingEnabled = true;
			this.InfoListBox.HorizontalScrollbar = true;
			this.InfoListBox.ItemHeight = 16;
			this.InfoListBox.Location = new System.Drawing.Point(12, 12);
			this.InfoListBox.Name = "InfoListBox";
			this.InfoListBox.Size = new System.Drawing.Size(366, 404);
			this.InfoListBox.TabIndex = 0;
			// 
			// team1
			// 
			this.team1.Location = new System.Drawing.Point(399, 37);
			this.team1.Name = "team1";
			this.team1.Size = new System.Drawing.Size(139, 22);
			this.team1.TabIndex = 1;
			// 
			// buttonStart
			// 
			this.buttonStart.Location = new System.Drawing.Point(399, 110);
			this.buttonStart.Name = "buttonStart";
			this.buttonStart.Size = new System.Drawing.Size(139, 34);
			this.buttonStart.TabIndex = 2;
			this.buttonStart.Text = "Начать";
			this.buttonStart.UseVisualStyleBackColor = true;
			this.buttonStart.Click += new System.EventHandler(this.buttonStart_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(399, 17);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(78, 17);
			this.label1.TabIndex = 3;
			this.label1.Text = "Команда 1";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(399, 62);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(78, 17);
			this.label2.TabIndex = 5;
			this.label2.Text = "Команда 2";
			// 
			// team2
			// 
			this.team2.Location = new System.Drawing.Point(399, 82);
			this.team2.Name = "team2";
			this.team2.Size = new System.Drawing.Size(139, 22);
			this.team2.TabIndex = 4;
			// 
			// buttonStop
			// 
			this.buttonStop.Location = new System.Drawing.Point(399, 150);
			this.buttonStop.Name = "buttonStop";
			this.buttonStop.Size = new System.Drawing.Size(139, 34);
			this.buttonStop.TabIndex = 6;
			this.buttonStop.Text = "Стоп";
			this.buttonStop.UseVisualStyleBackColor = true;
			this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
			// 
			// testbox
			// 
			this.testbox.Location = new System.Drawing.Point(577, 12);
			this.testbox.Name = "testbox";
			this.testbox.Size = new System.Drawing.Size(584, 467);
			this.testbox.TabIndex = 7;
			this.testbox.Text = "";
			// 
			// FootballParser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1293, 658);
			this.Controls.Add(this.testbox);
			this.Controls.Add(this.buttonStop);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.team2);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.buttonStart);
			this.Controls.Add(this.team1);
			this.Controls.Add(this.InfoListBox);
			this.Name = "FootballParser";
			this.Text = "Form1";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ListBox InfoListBox;
		private System.Windows.Forms.TextBox team1;
		private System.Windows.Forms.Button buttonStart;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox team2;
		private System.Windows.Forms.Button buttonStop;
		private System.Windows.Forms.RichTextBox testbox;
	}
}

