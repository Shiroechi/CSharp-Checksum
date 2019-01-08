using System;
using System.Windows.Forms;

namespace CSharpChecksum.UserControls
{
	public partial class CompareHashFileControl : UserControl
	{
		#region Member

		private long _LimitSize;

		#endregion Member

		public CompareHashFileControl()
		{
			InitializeComponent();

			this._LimitSize = Properties.Settings.Default.LimitSize *
							  Properties.Settings.Default.DefaultMultiplier; //100 MB
		}

		private void CompareHashFileControl_Load(object sender, EventArgs e)
		{
			this.LoadHashList();
			this.CompareButton.Enabled = false;
		}


		#region Private

		private void LoadHashList()
		{
			string[] temp = Entities.HashFunctionList.GetHashList();

			for (int i = 0; i < temp.Length; i++)
			{
				this.HashFunctionComboBox.Items.Add(temp[i]);
			}
			this.HashFunctionComboBox.Text = temp[0];
		}

		/// <summary>
		/// select an item from your disk
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void OpenFileButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.Title = "Select item";
				dialog.Filter = "All file | *.*";
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;
				dialog.Multiselect = false;
				dialog.RestoreDirectory = true;

				dialog.ShowDialog(this);

				if (dialog.FileName.Trim() != "")
				{
					this.LocationTextBox.Text = dialog.FileName.Trim();
				}
			}
		}

		/// <summary>
		/// hash selected item with selected hash function
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CompareButton_Click(object sender, EventArgs e)
		{
			if (this.LocationTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please select a file first.", "Attention");
				return;
			}

			if (System.IO.File.Exists(this.LocationTextBox.Text) == false)
			{
				MessageBox.Show(this, "Can't hash directory or folder.", "Attention");
				return;
			}

			byte[] data = System.IO.File.ReadAllBytes(this.LocationTextBox.Text);

			if (data.Length > this._LimitSize)
			{
				MessageBox.Show(this, "File can't larger than 100 MB.", "Attention");
				return;
			}

			var hash = new Entities.HashFunctionList();
			bool same = this.HashValueTextBox.Text == Entities.HashFunctionList.Hash(this.HashFunctionComboBox.Text, data);
			this.CompareButton.Enabled = false;
			
			if (same == true)
			{
				this.CompareResultLabel.Visible = true;
				this.CompareResultLabel.Text = "File is valid.";
			}
			else
			{
				this.CompareResultLabel.Visible = true;
				this.CompareResultLabel.Text = "File is not valid.";
			}

		}

		private void LocationTextBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}

			var temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.LocationTextBox.Text = temp[0];
			this.HashValueTextBox.Text = "";
			this.CompareButton.Enabled = true;
		}

		private void LocationTextBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		/// <summary>
		/// get file location that dropped inside form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CompareHashFileControl_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}

			var temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.LocationTextBox.Text = temp[0];
			this.HashValueTextBox.Text = "";
		}

		/// <summary>
		/// change icon if there file fragged inside form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CompareHashFileControl_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		#endregion Private
	}
}
