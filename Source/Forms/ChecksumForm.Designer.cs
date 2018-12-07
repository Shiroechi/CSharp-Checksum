namespace CSharpChecksum.Forms
{
	partial class ChecksumForm
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
			this.label1 = new System.Windows.Forms.Label();
			this.LocationTextBox = new System.Windows.Forms.TextBox();
			this.OpenFileButton = new System.Windows.Forms.Button();
			this.HashFunctionComboBox = new System.Windows.Forms.ComboBox();
			this.label2 = new System.Windows.Forms.Label();
			this.HashFileButton = new System.Windows.Forms.Button();
			this.HashValueTextBox = new System.Windows.Forms.TextBox();
			this.CopyButton = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(30, 60);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "Location";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// LocationTextBox
			// 
			this.LocationTextBox.AllowDrop = true;
			this.LocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LocationTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.LocationTextBox.Location = new System.Drawing.Point(150, 60);
			this.LocationTextBox.Name = "LocationTextBox";
			this.LocationTextBox.ReadOnly = true;
			this.LocationTextBox.Size = new System.Drawing.Size(365, 30);
			this.LocationTextBox.TabIndex = 1;
			this.LocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragDrop);
			this.LocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragEnter);
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenFileButton.Image = global::CSharpChecksum.Properties.Resources.icons8_opened_folder_filled_32;
			this.OpenFileButton.Location = new System.Drawing.Point(520, 59);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(40, 32);
			this.OpenFileButton.TabIndex = 2;
			this.OpenFileButton.UseVisualStyleBackColor = true;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// HashFunctionComboBox
			// 
			this.HashFunctionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HashFunctionComboBox.FormattingEnabled = true;
			this.HashFunctionComboBox.Location = new System.Drawing.Point(150, 120);
			this.HashFunctionComboBox.Name = "HashFunctionComboBox";
			this.HashFunctionComboBox.Size = new System.Drawing.Size(240, 30);
			this.HashFunctionComboBox.TabIndex = 3;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(30, 120);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 4;
			this.label2.Text = "Hash";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashFileButton
			// 
			this.HashFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HashFileButton.Location = new System.Drawing.Point(400, 119);
			this.HashFileButton.Name = "HashFileButton";
			this.HashFileButton.Size = new System.Drawing.Size(160, 30);
			this.HashFileButton.TabIndex = 4;
			this.HashFileButton.Text = "Hash File";
			this.HashFileButton.UseVisualStyleBackColor = true;
			this.HashFileButton.Click += new System.EventHandler(this.HashFileButton_Click);
			// 
			// HashValueTextBox
			// 
			this.HashValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashValueTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.HashValueTextBox.Location = new System.Drawing.Point(30, 170);
			this.HashValueTextBox.Multiline = true;
			this.HashValueTextBox.Name = "HashValueTextBox";
			this.HashValueTextBox.ReadOnly = true;
			this.HashValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.HashValueTextBox.Size = new System.Drawing.Size(360, 72);
			this.HashValueTextBox.TabIndex = 5;
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Location = new System.Drawing.Point(400, 212);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(160, 30);
			this.CopyButton.TabIndex = 6;
			this.CopyButton.Text = "Copy";
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// ChecksumForm
			// 
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.ClientSize = new System.Drawing.Size(584, 261);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.HashValueTextBox);
			this.Controls.Add(this.HashFileButton);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HashFunctionComboBox);
			this.Controls.Add(this.OpenFileButton);
			this.Controls.Add(this.LocationTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
			this.MinimumSize = new System.Drawing.Size(600, 300);
			this.Name = "ChecksumForm";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "ChecksumForm";
			this.Load += new System.EventHandler(this.ChecksumForm_Load);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox LocationTextBox;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.ComboBox HashFunctionComboBox;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button HashFileButton;
		private System.Windows.Forms.TextBox HashValueTextBox;
		private System.Windows.Forms.Button CopyButton;
	}
}