namespace ScreenShotter
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
			this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
			this.tbSavePath = new System.Windows.Forms.TextBox();
			this.button1 = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.numSeconds = new System.Windows.Forms.NumericUpDown();
			this.label2 = new System.Windows.Forms.Label();
			this.btnStart = new System.Windows.Forms.Button();
			this.btnStop = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.lbTimer = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.tbPrefix = new System.Windows.Forms.TextBox();
			this.label5 = new System.Windows.Forms.Label();
			this.numDigits = new System.Windows.Forms.NumericUpDown();
			this.cbFromLast = new System.Windows.Forms.CheckBox();
			((System.ComponentModel.ISupportInitialize)(this.numSeconds)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.numDigits)).BeginInit();
			this.SuspendLayout();
			// 
			// tbSavePath
			// 
			this.tbSavePath.Location = new System.Drawing.Point(12, 32);
			this.tbSavePath.Name = "tbSavePath";
			this.tbSavePath.ReadOnly = true;
			this.tbSavePath.Size = new System.Drawing.Size(548, 20);
			this.tbSavePath.TabIndex = 0;
			// 
			// button1
			// 
			this.button1.Location = new System.Drawing.Point(12, 59);
			this.button1.Name = "button1";
			this.button1.Size = new System.Drawing.Size(75, 23);
			this.button1.TabIndex = 1;
			this.button1.Text = "Browse";
			this.button1.UseVisualStyleBackColor = true;
			this.button1.Click += new System.EventHandler(this.Button1_Click);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Location = new System.Drawing.Point(12, 13);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(112, 13);
			this.label1.TabIndex = 2;
			this.label1.Text = "Save images to folder:";
			// 
			// numSeconds
			// 
			this.numSeconds.Location = new System.Drawing.Point(15, 109);
			this.numSeconds.Name = "numSeconds";
			this.numSeconds.Size = new System.Drawing.Size(75, 20);
			this.numSeconds.TabIndex = 3;
			this.numSeconds.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Location = new System.Drawing.Point(96, 111);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(135, 13);
			this.label2.TabIndex = 4;
			this.label2.Text = "Capture interval in seconds";
			// 
			// btnStart
			// 
			this.btnStart.Location = new System.Drawing.Point(484, 163);
			this.btnStart.Name = "btnStart";
			this.btnStart.Size = new System.Drawing.Size(75, 23);
			this.btnStart.TabIndex = 5;
			this.btnStart.Text = "Start";
			this.btnStart.UseVisualStyleBackColor = true;
			this.btnStart.Click += new System.EventHandler(this.BtnStart_Click);
			// 
			// btnStop
			// 
			this.btnStop.Location = new System.Drawing.Point(484, 204);
			this.btnStop.Name = "btnStop";
			this.btnStop.Size = new System.Drawing.Size(75, 23);
			this.btnStop.TabIndex = 6;
			this.btnStop.Text = "Stop";
			this.btnStop.UseVisualStyleBackColor = true;
			this.btnStop.Click += new System.EventHandler(this.BtnStop_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Location = new System.Drawing.Point(96, 173);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(36, 13);
			this.label3.TabIndex = 7;
			this.label3.Text = "Timer:";
			// 
			// lbTimer
			// 
			this.lbTimer.AutoSize = true;
			this.lbTimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbTimer.Location = new System.Drawing.Point(135, 173);
			this.lbTimer.Name = "lbTimer";
			this.lbTimer.Size = new System.Drawing.Size(0, 20);
			this.lbTimer.TabIndex = 8;
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(380, 64);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(81, 23);
			this.label4.TabIndex = 9;
			this.label4.Text = "Filename prefix: ";
			// 
			// tbPrefix
			// 
			this.tbPrefix.Location = new System.Drawing.Point(467, 61);
			this.tbPrefix.Name = "tbPrefix";
			this.tbPrefix.Size = new System.Drawing.Size(93, 20);
			this.tbPrefix.TabIndex = 10;
			this.tbPrefix.Text = "image-";
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(380, 87);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(81, 23);
			this.label5.TabIndex = 11;
			this.label5.Text = "Number digits: ";
			// 
			// numDigits
			// 
			this.numDigits.Location = new System.Drawing.Point(467, 85);
			this.numDigits.Name = "numDigits";
			this.numDigits.Size = new System.Drawing.Size(48, 20);
			this.numDigits.TabIndex = 12;
			this.numDigits.Value = new decimal(new int[] {
            6,
            0,
            0,
            0});
			// 
			// cbFromLast
			// 
			this.cbFromLast.AutoSize = true;
			this.cbFromLast.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
			this.cbFromLast.Checked = true;
			this.cbFromLast.CheckState = System.Windows.Forms.CheckState.Checked;
			this.cbFromLast.Location = new System.Drawing.Point(362, 111);
			this.cbFromLast.Name = "cbFromLast";
			this.cbFromLast.Size = new System.Drawing.Size(153, 17);
			this.cbFromLast.TabIndex = 14;
			this.cbFromLast.Text = "Increment number from last";
			this.cbFromLast.UseVisualStyleBackColor = true;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(583, 257);
			this.Controls.Add(this.cbFromLast);
			this.Controls.Add(this.numDigits);
			this.Controls.Add(this.label5);
			this.Controls.Add(this.tbPrefix);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.lbTimer);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btnStop);
			this.Controls.Add(this.btnStart);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.numSeconds);
			this.Controls.Add(this.label1);
			this.Controls.Add(this.button1);
			this.Controls.Add(this.tbSavePath);
			this.Name = "Form1";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ScreenShotter by fergicide@gmail.com";
			((System.ComponentModel.ISupportInitialize)(this.numSeconds)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.numDigits)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
		private System.Windows.Forms.TextBox tbSavePath;
		private System.Windows.Forms.Button button1;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.NumericUpDown numSeconds;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btnStart;
		private System.Windows.Forms.Button btnStop;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label lbTimer;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.TextBox tbPrefix;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.NumericUpDown numDigits;
		private System.Windows.Forms.CheckBox cbFromLast;
	}
}

