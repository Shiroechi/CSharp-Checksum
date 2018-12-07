using System;
using System.Windows.Forms;

namespace CSharpChecksum.Forms
{
	public partial class ChecksumForm : Form
	{
		int _LimitSize = 104857600; //100 MB
		public ChecksumForm()
		{
			InitializeComponent();
		}

		private void ChecksumForm_Load(object sender, EventArgs e)
		{
			this.LoadHashList();
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
		private void HashFileButton_Click(object sender, EventArgs e)
		{
			if (this.LocationTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please select a file first.", "Attention");
				return;
			}
			
			byte[] data = System.IO.File.ReadAllBytes(this.LocationTextBox.Text);

			if (data.Length > this._LimitSize)
			{
				MessageBox.Show(this, "File can't larger than 100 MB.", "Attention");
				return;
			}

			var hash = new Entities.HashFunctionList();
			this.HashValueTextBox.Text = Entities.HashFunctionList.Hash(this.HashFunctionComboBox.Text, data);
		}

		/// <summary>
		/// copy hash value to clipboard
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CopyButton_Click(object sender, EventArgs e)
		{
			if (this.HashValueTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please hash a file first.", "Attention");
				return;
			}

			Clipboard.SetText(this.HashValueTextBox.Text);
		}


		private void LoadHashList()
		{
			string[] temp = Entities.HashFunctionList.GetHashList();

			for (int i = 0; i < temp.Length; i++)
			{
				this.HashFunctionComboBox.Items.Add(temp[i]);
			}
			this.HashFunctionComboBox.Text = temp[0];
		}

		private void LocationTextBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}

			var temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.LocationTextBox.Text = temp[0];
		}

		private void LocationTextBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}
	}
}
