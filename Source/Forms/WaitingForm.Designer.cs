namespace CSharpChecksum.Forms
{
	partial class WaitingForm
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
			this.WaitingLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// WaitingLabel
			// 
			this.WaitingLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.WaitingLabel.BackColor = System.Drawing.Color.Transparent;
			this.WaitingLabel.Location = new System.Drawing.Point(0, 25);
			this.WaitingLabel.Name = "WaitingLabel";
			this.WaitingLabel.Size = new System.Drawing.Size(200, 50);
			this.WaitingLabel.TabIndex = 1;
			this.WaitingLabel.Text = "Processing";
			this.WaitingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// WaitingForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(200, 100);
			this.ControlBox = false;
			this.Controls.Add(this.WaitingLabel);
			this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
			this.Margin = new System.Windows.Forms.Padding(5);
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "WaitingForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
			this.Text = "WaitingForm";
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label WaitingLabel;
	}
}