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
			this.label1 = new System.Windows.Forms.Label();
			this.FileLocationTextBox = new System.Windows.Forms.TextBox();
			this.BrowseButton = new System.Windows.Forms.Button();
			this.label2 = new System.Windows.Forms.Label();
			this.HashValueTextBox = new System.Windows.Forms.TextBox();
			this.CopyHashValueButton = new System.Windows.Forms.Button();
			this.HashButton = new System.Windows.Forms.Button();
			this.CancelHashButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.HashFunctionListComboBox = new System.Windows.Forms.ComboBox();
			this.SaveHashValueButton = new System.Windows.Forms.Button();
			this.label4 = new System.Windows.Forms.Label();
			this.HashProgressBar = new System.Windows.Forms.ProgressBar();
			this.label5 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(20, 20);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(130, 30);
			this.label1.TabIndex = 0;
			this.label1.Text = "File location";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// FileLocationTextBox
			// 
			this.FileLocationTextBox.AllowDrop = true;
			this.FileLocationTextBox.Font = new System.Drawing.Font("Consolas", 14.25F);
			this.FileLocationTextBox.Location = new System.Drawing.Point(160, 20);
			this.FileLocationTextBox.Name = "FileLocationTextBox";
			this.FileLocationTextBox.Size = new System.Drawing.Size(320, 30);
			this.FileLocationTextBox.TabIndex = 1;
			this.FileLocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.FileLocationTextBox_DragDrop);
			this.FileLocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.FileLocationTextBox_DragEnter);
			// 
			// BrowseButton
			// 
			this.BrowseButton.Location = new System.Drawing.Point(500, 20);
			this.BrowseButton.Name = "BrowseButton";
			this.BrowseButton.Size = new System.Drawing.Size(100, 30);
			this.BrowseButton.TabIndex = 2;
			this.BrowseButton.Text = "Browse";
			this.BrowseButton.UseVisualStyleBackColor = true;
			this.BrowseButton.Click += new System.EventHandler(this.BrowseButton_Click);
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(20, 60);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(130, 30);
			this.label2.TabIndex = 3;
			this.label2.Text = "Hash function";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashValueTextBox
			// 
			this.HashValueTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.HashValueTextBox.Location = new System.Drawing.Point(160, 100);
			this.HashValueTextBox.MaxLength = 550;
			this.HashValueTextBox.Multiline = true;
			this.HashValueTextBox.Name = "HashValueTextBox";
			this.HashValueTextBox.ReadOnly = true;
			this.HashValueTextBox.Size = new System.Drawing.Size(320, 78);
			this.HashValueTextBox.TabIndex = 4;
			// 
			// CopyHashValueButton
			// 
			this.CopyHashValueButton.Location = new System.Drawing.Point(500, 100);
			this.CopyHashValueButton.Name = "CopyHashValueButton";
			this.CopyHashValueButton.Size = new System.Drawing.Size(100, 30);
			this.CopyHashValueButton.TabIndex = 5;
			this.CopyHashValueButton.Text = "Copy";
			this.CopyHashValueButton.UseVisualStyleBackColor = true;
			this.CopyHashValueButton.Click += new System.EventHandler(this.CopyButton_Click);
			// 
			// HashButton
			// 
			this.HashButton.Location = new System.Drawing.Point(500, 190);
			this.HashButton.Name = "HashButton";
			this.HashButton.Size = new System.Drawing.Size(100, 30);
			this.HashButton.TabIndex = 6;
			this.HashButton.Text = "Hash";
			this.HashButton.UseVisualStyleBackColor = true;
			this.HashButton.Click += new System.EventHandler(this.HashButton_Click);
			// 
			// CancelHashButton
			// 
			this.CancelHashButton.Location = new System.Drawing.Point(500, 230);
			this.CancelHashButton.Name = "CancelHashButton";
			this.CancelHashButton.Size = new System.Drawing.Size(100, 30);
			this.CancelHashButton.TabIndex = 7;
			this.CancelHashButton.Text = "Cancel";
			this.CancelHashButton.UseVisualStyleBackColor = true;
			this.CancelHashButton.Click += new System.EventHandler(this.CancelHashButton_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(0, 0);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(100, 23);
			this.label3.TabIndex = 9;
			// 
			// HashFunctionListComboBox
			// 
			this.HashFunctionListComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HashFunctionListComboBox.Font = new System.Drawing.Font("Consolas", 14F);
			this.HashFunctionListComboBox.FormattingEnabled = true;
			this.HashFunctionListComboBox.Location = new System.Drawing.Point(160, 60);
			this.HashFunctionListComboBox.Name = "HashFunctionListComboBox";
			this.HashFunctionListComboBox.Size = new System.Drawing.Size(190, 30);
			this.HashFunctionListComboBox.TabIndex = 8;
			// 
			// SaveHashValueButton
			// 
			this.SaveHashValueButton.Location = new System.Drawing.Point(500, 150);
			this.SaveHashValueButton.Name = "SaveHashValueButton";
			this.SaveHashValueButton.Size = new System.Drawing.Size(100, 30);
			this.SaveHashValueButton.TabIndex = 5;
			this.SaveHashValueButton.Text = "Save";
			this.SaveHashValueButton.UseVisualStyleBackColor = true;
			this.SaveHashValueButton.Click += new System.EventHandler(this.SaveButton_Click);
			// 
			// label4
			// 
			this.label4.Location = new System.Drawing.Point(20, 100);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(130, 30);
			this.label4.TabIndex = 3;
			this.label4.Text = "Hash value";
			this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashProgressBar
			// 
			this.HashProgressBar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
			this.HashProgressBar.Location = new System.Drawing.Point(160, 190);
			this.HashProgressBar.Name = "HashProgressBar";
			this.HashProgressBar.Size = new System.Drawing.Size(320, 30);
			this.HashProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
			this.HashProgressBar.TabIndex = 10;
			// 
			// label5
			// 
			this.label5.Location = new System.Drawing.Point(20, 190);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(100, 30);
			this.label5.TabIndex = 11;
			this.label5.Text = "Progress";
			this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashFileControl
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.label5);
			this.Controls.Add(this.HashProgressBar);
			this.Controls.Add(this.HashFunctionListComboBox);
			this.Controls.Add(this.CancelHashButton);
			this.Controls.Add(this.HashButton);
			this.Controls.Add(this.SaveHashValueButton);
			this.Controls.Add(this.CopyHashValueButton);
			this.Controls.Add(this.HashValueTextBox);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label4);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.BrowseButton);
			this.Controls.Add(this.FileLocationTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 12F);
			this.Name = "HashFileControl";
			this.Size = new System.Drawing.Size(634, 281);
			this.Load += new System.EventHandler(this.HashFileControl_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.HashFileControl_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.HashFileControl_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox FileLocationTextBox;
		private System.Windows.Forms.Button BrowseButton;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.TextBox HashValueTextBox;
		private System.Windows.Forms.Button CopyHashValueButton;
		private System.Windows.Forms.Button HashButton;
		private System.Windows.Forms.Button CancelHashButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.ComboBox HashFunctionListComboBox;
		private System.Windows.Forms.Button SaveHashValueButton;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ProgressBar HashProgressBar;
		private System.Windows.Forms.Label label5;
	}
}
