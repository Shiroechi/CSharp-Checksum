namespace CSharpChecksum.UserControls
{
	partial class SettingsControl
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

		#region Component Designer generated code

		/// <summary> 
		/// Required method for Designer support - do not modify 
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			this.label1 = new System.Windows.Forms.Label();
			this.SaveButton = new System.Windows.Forms.Button();
			this.LimitSizeValue = new System.Windows.Forms.NumericUpDown();
			((System.ComponentModel.ISupportInitialize)(this.LimitSizeValue)).BeginInit();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(200, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Limit size (MB)";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// SaveButton
			// 
			this.SaveButton.Location = new System.Drawing.Point(510, 230);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(100, 30);
			this.SaveButton.TabIndex = 2;
			this.SaveButton.Text = "Save";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// LimitSizeValue
			// 
			this.LimitSizeValue.Font = new System.Drawing.Font("Consolas", 14.25F);
			this.LimitSizeValue.Location = new System.Drawing.Point(250, 30);
			this.LimitSizeValue.Maximum = new decimal(new int[] {
            10000,
            0,
            0,
            0});
			this.LimitSizeValue.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
			this.LimitSizeValue.Name = "LimitSizeValue";
			this.LimitSizeValue.Size = new System.Drawing.Size(120, 30);
			this.LimitSizeValue.TabIndex = 1;
			this.LimitSizeValue.Value = new decimal(new int[] {
            100,
            0,
            0,
            0});
			// 
			// SettingsControl
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.LimitSizeValue);
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 14F);
			this.Name = "SettingsControl";
			this.Size = new System.Drawing.Size(634, 281);
			this.Load += new System.EventHandler(this.SettingsControl_Load);
			((System.ComponentModel.ISupportInitialize)(this.LimitSizeValue)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.NumericUpDown LimitSizeValue;
	}
}
