namespace CSharpChecksum.UserControls
{
	partial class HashFileControl
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
			this.SaveButton = new System.Windows.Forms.Button();
			this.CopyButton = new System.Windows.Forms.Button();
			this.HashValueTextBox = new System.Windows.Forms.TextBox();
			this.HashFileButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.HashFunctionComboBox = new System.Windows.Forms.ComboBox();
			this.OpenFileButton = new System.Windows.Forms.Button();
			this.LocationTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// SaveButton
			// 
			this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.SaveButton.Location = new System.Drawing.Point(231, 221);
			this.SaveButton.Name = "SaveButton";
			this.SaveButton.Size = new System.Drawing.Size(160, 30);
			this.SaveButton.TabIndex = 19;
			this.SaveButton.Text = "Save ";
			this.SaveButton.UseVisualStyleBackColor = true;
			this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// CopyButton
			// 
			this.CopyButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
			this.CopyButton.Location = new System.Drawing.Point(397, 221);
			this.CopyButton.Name = "CopyButton";
			this.CopyButton.Size = new System.Drawing.Size(160, 30);
			this.CopyButton.TabIndex = 18;
			this.CopyButton.Text = "Copy";
			this.CopyButton.UseVisualStyleBackColor = true;
			this.CopyButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// HashValueTextBox
			// 
			this.HashValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashValueTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.HashValueTextBox.Location = new System.Drawing.Point(147, 141);
			this.HashValueTextBox.Multiline = true;
			this.HashValueTextBox.Name = "HashValueTextBox";
			this.HashValueTextBox.ReadOnly = true;
			this.HashValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.HashValueTextBox.Size = new System.Drawing.Size(410, 72);
			this.HashValueTextBox.TabIndex = 17;
			// 
			// HashFileButton
			// 
			this.HashFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.HashFileButton.Location = new System.Drawing.Point(447, 91);
			this.HashFileButton.Name = "HashFileButton";
			this.HashFileButton.Size = new System.Drawing.Size(160, 30);
			this.HashFileButton.TabIndex = 14;
			this.HashFileButton.Text = "Hash File";
			this.HashFileButton.UseVisualStyleBackColor = true;
			this.HashFileButton.Click += new System.EventHandler(this.HashFileButton_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 162);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 30);
			this.label3.TabIndex = 15;
			this.label3.Text = "Hash Value";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 91);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 16;
			this.label2.Text = "Hash";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashFunctionComboBox
			// 
			this.HashFunctionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HashFunctionComboBox.FormattingEnabled = true;
			this.HashFunctionComboBox.Location = new System.Drawing.Point(147, 91);
			this.HashFunctionComboBox.Name = "HashFunctionComboBox";
			this.HashFunctionComboBox.Size = new System.Drawing.Size(290, 30);
			this.HashFunctionComboBox.TabIndex = 13;
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenFileButton.Image = global::CSharpChecksum.Properties.Resources.icons8_opened_folder_filled_32;
			this.OpenFileButton.Location = new System.Drawing.Point(567, 30);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(40, 32);
			this.OpenFileButton.TabIndex = 12;
			this.OpenFileButton.UseVisualStyleBackColor = true;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// LocationTextBox
			// 
			this.LocationTextBox.AllowDrop = true;
			this.LocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LocationTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.LocationTextBox.Location = new System.Drawing.Point(147, 31);
			this.LocationTextBox.Name = "LocationTextBox";
			this.LocationTextBox.ReadOnly = true;
			this.LocationTextBox.Size = new System.Drawing.Size(415, 29);
			this.LocationTextBox.TabIndex = 11;
			this.LocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragDrop);
			this.LocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragEnter);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 31);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 10;
			this.label1.Text = "Location";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashFileControl
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.SaveButton);
			this.Controls.Add(this.CopyButton);
			this.Controls.Add(this.HashValueTextBox);
			this.Controls.Add(this.HashFileButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HashFunctionComboBox);
			this.Controls.Add(this.OpenFileButton);
			this.Controls.Add(this.LocationTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 14F);
			this.Name = "HashFileControl";
			this.Size = new System.Drawing.Size(634, 281);
			this.Load += new System.EventHandler(this.HashFileControl_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HashFileControl_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HashFileControl_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button SaveButton;
		private System.Windows.Forms.Button CopyButton;
		private System.Windows.Forms.TextBox HashValueTextBox;
		private System.Windows.Forms.Button HashFileButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox HashFunctionComboBox;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.TextBox LocationTextBox;
		private System.Windows.Forms.Label label1;
	}
}
