using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Text;
using System.Windows.Forms;

namespace ScreenShotter
{
	public partial class Form1 : Form
	{
		Timer timer = new Timer();
		string savePath, rootPath, digitFormat, subPath;
		int timerSeconds, captureCount, startingNum;

		public Form1()
		{
			InitializeComponent();

			timer.Tick += new EventHandler(TimerTick);
			timer.Enabled = false;
		}

		private void Button1_Click(object sender, EventArgs e)
		{
			ChooseFolder();
		}

		void ChooseFolder()
		{
			if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
			{
				tbSavePath.Text = folderBrowserDialog1.SelectedPath;
			}
		}

		private void SnapshotScreen()
		{
			if (string.IsNullOrEmpty(savePath)) return;

			//Create a new bitmap.
			Bitmap bmpScreenshot = new Bitmap(Screen.PrimaryScreen.Bounds.Width,
										   Screen.PrimaryScreen.Bounds.Height,
										   PixelFormat.Format32bppArgb);

			// Create a graphics object from the bitmap.
			Graphics gfxScreenshot = Graphics.FromImage(bmpScreenshot);

			// Take the screenshot from the upper left corner to the right bottom corner.
			gfxScreenshot.CopyFromScreen(Screen.PrimaryScreen.Bounds.X,
										Screen.PrimaryScreen.Bounds.Y,
										0,
										0,
										Screen.PrimaryScreen.Bounds.Size,
										CopyPixelOperation.SourceCopy);

			// timestamp
			if (cbOverlayTime.Checked)
			{
				gfxScreenshot.FillRectangle(Brushes.White, 0, 0, 300, 30);
				gfxScreenshot.DrawString(
					DateTime.Now.ToString("s")
					, new Font("Courier New", 18f, FontStyle.Bold)
					, Brushes.Black, 2, 2
				);
			}

			// Save the screenshot to the specified path that the user has chosen.
			bmpScreenshot.Save(
				string.Concat(
					Path.Combine(
						savePath
						, string.Concat(tbPrefix.Text, (startingNum + captureCount).ToString(digitFormat))
					)
					, ".png"
				)
				, ImageFormat.Png
			);

			bmpScreenshot.Dispose();
			gfxScreenshot.Dispose();

		}

		private void TimerTick(Object myObject, EventArgs myEventArgs)
		{
			SnapshotScreen();
			captureCount++;
			timerSeconds += timer.Interval / 1000;
			lbTimer.Text = string.Concat(timerSeconds.ToString(), " seconds ; ", captureCount, " screenshots");
		}

		private void BtnStart_Click(object sender, EventArgs e)
		{
			BtnStop_Click(sender, e);

			if (numSeconds.Value < 1) return;
			if (string.IsNullOrEmpty(folderBrowserDialog1.SelectedPath)) return;

			rootPath = folderBrowserDialog1.SelectedPath;
			subPath = DateTime.Now.ToString("yyMMdd-HHmmss");
			savePath = string.Concat(rootPath, @"\", subPath);
			if (!Directory.Exists(savePath)) Directory.CreateDirectory(savePath);

			startingNum = GetStartingNum();

			digitFormat = string.Concat("D", numDigits.Value);
			if (!timer.Enabled) timer.Enabled = true;
			timer.Interval = (int)numSeconds.Value * 1000;
			timer.Start();
			lbTimer.Text = "RUNNING";
			lbTimer.ForeColor = Color.DarkGreen;
		}

		private void BtnStop_Click(object sender, EventArgs e)
		{
			timer.Stop(); 
			timer.Enabled = false;
			lbTimer.Text = "STOPPED";
			lbTimer.ForeColor = Color.Red;
			timerSeconds = 0;
			captureCount = 0;
		}

		/// <summary>
		/// Parses all subfolders under root and determines the last highest number by file name
		/// </summary>
		/// <returns></returns>
		private int GetStartingNum()
		{
			int result = 0;
			if (!cbFromLast.Checked) return result;

			List<string> files = new List<string>(
				Directory.GetFiles(rootPath,"*.*", SearchOption.AllDirectories)
			);
			foreach (string file in files)
			{
				string fileNoExt = Path.GetFileNameWithoutExtension(file);
				Console.WriteLine(fileNoExt);
				if (
					int.TryParse(
						fileNoExt.Replace(tbPrefix.Text, string.Empty)
						, out int check
					)
				)
				{
					// fileNoExt is a number
					if (check > result) result = check;
				}
			}

			if (result > 0) result++; // increment by 1 over highest found filename number
			return result;
		}
	}
}
