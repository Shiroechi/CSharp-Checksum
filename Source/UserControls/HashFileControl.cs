using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using CSharpChecksum.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace CSharpChecksum.UserControls
{
	public partial class HashFileControl : UserControl
	{
		#region Member

		private long _LimitSize;
		private BackgroundWorker _BackgroundWorker;
		private byte[] _Data;
		private Form _WaitingForm;

		#endregion Member

		#region Constructor & Destructor

		public HashFileControl()
		{
			InitializeComponent();
			
			this._LimitSize = Properties.Settings.Default.LimitSize *
							  Properties.Settings.Default.DefaultMultiplier; //100 MB

			this._Data = new byte[Properties.Settings.Default.BlockSize];

			this._WaitingForm = new WaitingForm();

			this._BackgroundWorker = new BackgroundWorker();
			this._BackgroundWorker.WorkerSupportsCancellation = true;
			this._BackgroundWorker.DoWork += Hashing_DoWork;
			this._BackgroundWorker.RunWorkerCompleted += Hahsing_RunWorkerCompleted;
		}

		~HashFileControl()
		{
			if (this._BackgroundWorker.IsBusy == true)
			{
				this._BackgroundWorker.CancelAsync();
			}
			this._BackgroundWorker.Dispose();

			if (this._Data != null || this._Data.Length > 0)
			{
				Array.Clear(this._Data, 0, this._Data.Length);
			}

			this._WaitingForm.Dispose();
		}

		#endregion Constructor & Destructor

		#region Form Event

		private void HashFileControl_Load(object sender, EventArgs e)
		{
			this.LoadHashList();
		}
		
		/// <summary>
		/// get file location that dropped inside form
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HashFileControl_DragDrop(object sender, DragEventArgs e)
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
		private void HashFileControl_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		#endregion Form Event

		#region Button Event

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

			if (System.IO.File.Exists(this.LocationTextBox.Text) == false)
			{
				MessageBox.Show(this, "Can't hash directory or folder.", "Attention");
				return;
			}

			FileInfo file = new FileInfo(this.LocationTextBox.Text);

			if (file.Length > this._LimitSize)
			{
				MessageBox.Show(this, "File can't larger than " +
					Properties.Settings.Default.LimitSize + " MB.", "Attention");
				return;
			}

			this.HashFileButton.Enabled = false;
			
			this._BackgroundWorker.RunWorkerAsync();

			this._WaitingForm.ShowDialog();
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

		/// <summary>
		/// save hash value in texxt format
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void SaveButton_Click(object sender, EventArgs e)
		{
			if (this.LocationTextBox.Text.Trim() == "")
			{
				return;
			}

			if (this.HashValueTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please hash a file first.", "Attention");
				return;
			}

			string directory = System.IO.Path.GetDirectoryName(this.LocationTextBox.Text);
			string filename = System.IO.Path.GetFileNameWithoutExtension(this.LocationTextBox.Text);

			//create file that contain selected hash value
			try
			{
				string path = directory + "\\" + filename + CSharpChecksum.Entities.HashFunctionList.HashFileExtension(this.HashFunctionComboBox.Text);
				System.IO.File.WriteAllText(path, this.HashValueTextBox.Text);
			}
			catch
			{
				MessageBox.Show(this, "Can't save.", "Attention");
			}
		}

		#endregion Button Event

		#region TextBox Event

		private void LocationTextBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}

			var temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.LocationTextBox.Text = temp[0];
			this.HashValueTextBox.Text = "";
		}

		private void LocationTextBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		#endregion TextBox Event

		#region Backgroung Worker Event

		private void Hashing_DoWork(object sender, DoWorkEventArgs e)
		{
			var temp = sender as BackgroundWorker;
			if (temp.CancellationPending == true)
			{
				Array.Clear(this._Data, 0, this._Data.Length);
				e.Cancel = true;
				return;
			}

			e.Result = this.ExecuteHash();
		}

		private void Hashing_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{

		}

		private void Hahsing_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
		{
			if (e.Error != null)
			{
				MessageBox.Show(this, e.Error.Message);
			}
			else if (e.Cancelled)
			{
				//this.CompareResultLabel.Text = "Cancelled";
			}
			else
			{
				this.HashValueTextBox.Text = e.Result.ToString();
			}
			
			this.HashFileButton.Enabled = true;
			this._WaitingForm.Close();
		}

		#endregion Backgroung Worker Event

		#region Private Method

		private void LoadHashList()
		{
			string[] temp = Entities.HashFunctionList.GetHashList();

			for (int i = 0; i < temp.Length; i++)
			{
				this.HashFunctionComboBox.Items.Add(temp[i]);
			}
			this.HashFunctionComboBox.Text = temp[0];
		}

		private string ExecuteHash()
		{
			IDigest hash;
			switch (this.HashFunctionComboBox.Text)
			{
				case "Blake2b - 256 bit":
					hash = new Blake2bDigest(256);
					break;
				case "Blake2b - 512 bit":
					hash = new Blake2bDigest(512);
					break;
				case "SHA-1":
					hash = new Sha1Digest();
					break;
				case "SHA-2 256 bit":
					hash = new Sha256Digest();
					break;
				case "SHA-2 512 bit":
					hash = new Sha512Digest();
					break;
				case "SHA-3 256 bit":
					hash = new Sha3Digest(256);
					break;
				case "SHA-3 512 bit":
					hash = new Sha3Digest(512);
					break;
				default:
					hash = new Sha1Digest();
					break;
			}

			byte[] result = new byte[hash.GetDigestSize()];

			using (Stream source = File.OpenRead(this.LocationTextBox.Text))
			{
				int BytesRead;
				while ((BytesRead = source.Read(this._Data, 0, this._Data.Length)) > 0)
				{
					hash.BlockUpdate(this._Data, 0, BytesRead);
				}
			}

			hash.DoFinal(result, 0);

			Array.Clear(this._Data, 0, this._Data.Length);

			return Entities.HashFunctionList.ByteArrayToHexString(result);
		}

		#endregion Private Method

	}
}
