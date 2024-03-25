namespace Uygulama.UI
{
	partial class Anasafa
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
			lstbox = new ListBox();
			SuspendLayout();
			// 
			// lstbox
			// 
			lstbox.FormattingEnabled = true;
			lstbox.ItemHeight = 15;
			lstbox.Location = new Point(68, 156);
			lstbox.Name = "lstbox";
			lstbox.Size = new Size(603, 154);
			lstbox.TabIndex = 0;
			// 
			// Anasafa
			// 
			AutoScaleDimensions = new SizeF(7F, 15F);
			AutoScaleMode = AutoScaleMode.Font;
			ClientSize = new Size(800, 450);
			Controls.Add(lstbox);
			Name = "Anasafa";
			Text = "Anasafa";
			ResumeLayout(false);
		}

		#endregion

		private ListBox lstbox;
	}
}