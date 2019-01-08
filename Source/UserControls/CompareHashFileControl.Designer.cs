namespace CSharpChecksum.UserControls
{
	partial class CompareHashFileControl
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
			this.HashValueTextBox = new System.Windows.Forms.TextBox();
			this.CompareButton = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.HashFunctionComboBox = new System.Windows.Forms.ComboBox();
			this.OpenFileButton = new System.Windows.Forms.Button();
			this.LocationTextBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.CompareResultLabel = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// HashValueTextBox
			// 
			this.HashValueTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashValueTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.HashValueTextBox.Location = new System.Drawing.Point(147, 90);
			this.HashValueTextBox.Multiline = true;
			this.HashValueTextBox.Name = "HashValueTextBox";
			this.HashValueTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.HashValueTextBox.Size = new System.Drawing.Size(410, 72);
			this.HashValueTextBox.TabIndex = 3;
			// 
			// CompareButton
			// 
			this.CompareButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.CompareButton.Location = new System.Drawing.Point(460, 190);
			this.CompareButton.Name = "CompareButton";
			this.CompareButton.Size = new System.Drawing.Size(160, 30);
			this.CompareButton.TabIndex = 5;
			this.CompareButton.Text = "Compare";
			this.CompareButton.UseVisualStyleBackColor = true;
			this.CompareButton.Click += new System.EventHandler(this.CompareButton_Click);
			// 
			// label3
			// 
			this.label3.Location = new System.Drawing.Point(27, 90);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(120, 30);
			this.label3.TabIndex = 23;
			this.label3.Text = "Hash Value";
			this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// label2
			// 
			this.label2.Location = new System.Drawing.Point(27, 190);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(100, 30);
			this.label2.TabIndex = 24;
			this.label2.Text = "Hash";
			this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// HashFunctionComboBox
			// 
			this.HashFunctionComboBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.HashFunctionComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.HashFunctionComboBox.FormattingEnabled = true;
			this.HashFunctionComboBox.Location = new System.Drawing.Point(147, 190);
			this.HashFunctionComboBox.Name = "HashFunctionComboBox";
			this.HashFunctionComboBox.Size = new System.Drawing.Size(290, 30);
			this.HashFunctionComboBox.TabIndex = 4;
			// 
			// OpenFileButton
			// 
			this.OpenFileButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
			this.OpenFileButton.Image = global::CSharpChecksum.Properties.Resources.icons8_opened_folder_filled_32;
			this.OpenFileButton.Location = new System.Drawing.Point(567, 29);
			this.OpenFileButton.Name = "OpenFileButton";
			this.OpenFileButton.Size = new System.Drawing.Size(40, 32);
			this.OpenFileButton.TabIndex = 2;
			this.OpenFileButton.UseVisualStyleBackColor = true;
			this.OpenFileButton.Click += new System.EventHandler(this.OpenFileButton_Click);
			// 
			// LocationTextBox
			// 
			this.LocationTextBox.AllowDrop = true;
			this.LocationTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
			this.LocationTextBox.BackColor = System.Drawing.SystemColors.Window;
			this.LocationTextBox.Location = new System.Drawing.Point(147, 30);
			this.LocationTextBox.Name = "LocationTextBox";
			this.LocationTextBox.ReadOnly = true;
			this.LocationTextBox.Size = new System.Drawing.Size(415, 30);
			this.LocationTextBox.TabIndex = 1;
			this.LocationTextBox.DragDrop += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragDrop);
			this.LocationTextBox.DragEnter += new System.Windows.Forms.DragEventHandler(this.LocationTextBox_DragEnter);
			// 
			// label1
			// 
			this.label1.Location = new System.Drawing.Point(27, 30);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(100, 30);
			this.label1.TabIndex = 18;
			this.label1.Text = "Location";
			this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
			// 
			// CompareResultLabel
			// 
			this.CompareResultLabel.ForeColor = System.Drawing.Color.Red;
			this.CompareResultLabel.Location = new System.Drawing.Point(167, 230);
			this.CompareResultLabel.Name = "CompareResultLabel";
			this.CompareResultLabel.Size = new System.Drawing.Size(300, 30);
			this.CompareResultLabel.TabIndex = 25;
			this.CompareResultLabel.Text = "Result";
			this.CompareResultLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			this.CompareResultLabel.Visible = false;
			// 
			// CompareHashFileControl
			// 
			this.AllowDrop = true;
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
			this.Controls.Add(this.CompareResultLabel);
			this.Controls.Add(this.HashValueTextBox);
			this.Controls.Add(this.CompareButton);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.HashFunctionComboBox);
			this.Controls.Add(this.OpenFileButton);
			this.Controls.Add(this.LocationTextBox);
			this.Controls.Add(this.label1);
			this.Font = new System.Drawing.Font("Consolas", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Name = "CompareHashFileControl";
			this.Size = new System.Drawing.Size(634, 281);
			this.Load += new System.EventHandler(this.CompareHashFileControl_Load);
			this.DragDrop += new System.Windows.Forms.DragEventHandler(this.CompareHashFileControl_DragDrop);
			this.DragEnter += new System.Windows.Forms.DragEventHandler(this.CompareHashFileControl_DragEnter);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox HashValueTextBox;
		private System.Windows.Forms.Button CompareButton;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.ComboBox HashFunctionComboBox;
		private System.Windows.Forms.Button OpenFileButton;
		private System.Windows.Forms.TextBox LocationTextBox;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label CompareResultLabel;
	}
}
