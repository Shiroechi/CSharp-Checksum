using System;
using System.ComponentModel;
using System.IO;
using System.Windows.Forms;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Digests;

namespace CSharpChecksum.UserControls
{
	public partial class HashFileControl : UserControl
	{
		#region Member

		private BackgroundWorker _BackgroundWorker;
		private IDigest _Hash;
		private long _LimitSize;
		private byte[] _BlockSize;
		private long _FileSize;

		#endregion Member

		#region Constructor & Destructor

		public HashFileControl()
		{
			InitializeComponent();
			
			this._LimitSize = Properties.Settings.Default.LimitSize * 1048576; //100 MB

			this._BlockSize = new byte[Properties.Settings.Default.BlockSize];

			this._BackgroundWorker = new BackgroundWorker();
			this._BackgroundWorker.WorkerSupportsCancellation = true;
			this._BackgroundWorker.WorkerReportsProgress = true;
			this._BackgroundWorker.DoWork += Hashing_DoWork;
			this._BackgroundWorker.ProgressChanged += Hashing_ProgressChanged;
			this._BackgroundWorker.RunWorkerCompleted += Hahsing_RunWorkerCompleted;
		}

		~HashFileControl()
		{
			if (this._BackgroundWorker.IsBusy == true)
			{
				this._BackgroundWorker.CancelAsync();
			}
			this._BackgroundWorker.Dispose();

			if (this._BlockSize != null || this._BlockSize.Length > 0)
			{
				Array.Clear(this._BlockSize, 0, this._BlockSize.Length);
			}
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
			this.FileLocationTextBox.Text = temp[0];
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
		private void BrowseButton_Click(object sender, EventArgs e)
		{
			using (OpenFileDialog dialog = new OpenFileDialog())
			{
				dialog.InitialDirectory = "D:\\";
				dialog.Title = "Select item";
				dialog.Filter = "All file | *.*";
				dialog.CheckFileExists = true;
				dialog.CheckPathExists = true;
				dialog.Multiselect = false;
				dialog.RestoreDirectory = true;

				if (this.FileLocationTextBox.Text.Trim() != "")
				{
					dialog.InitialDirectory = this.GetFileDirectory(this.FileLocationTextBox.Text);
				}

				if(dialog.ShowDialog() == DialogResult.OK)
				{
					this.FileLocationTextBox.Text = dialog.FileName.Trim();
				}
			}
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
			if (this.HashValueTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please hash a file first.", "Attention");
				return;
			}

			string directory = System.IO.Path.GetDirectoryName(this.FileLocationTextBox.Text);
			string filename = System.IO.Path.GetFileNameWithoutExtension(this.FileLocationTextBox.Text);

			//create file that contain selected hash value
			try
			{
				string path = directory + "\\" + filename + Entities.HashFunctionList.HashFileExtension(this.HashFunctionListComboBox.Text);
				System.IO.File.WriteAllText(path, this.HashValueTextBox.Text);
			}
			catch
			{
				MessageBox.Show(this, "Can't save hash value.", "Attention");
			}
		}

		/// <summary>
		/// hash selected item with selected hash function
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void HashButton_Click(object sender, EventArgs e)
		{
			if (this.FileLocationTextBox.Text.Trim() == "")
			{
				MessageBox.Show(this, "Please select a file first.", "Attention");
				return;
			}
			else if (Directory.Exists(this.FileLocationTextBox.Text))
			{
				MessageBox.Show(this, "Can't hash directory or folder.", "Attention");
				return;
			}
			else if (System.IO.File.Exists(this.FileLocationTextBox.Text) == false)
			{
				MessageBox.Show(this, "File not exist.", "Attention");
				return;
			}

			FileInfo file = new FileInfo(this.FileLocationTextBox.Text);

			if (file.Length > this._LimitSize)
			{
				MessageBox.Show(this, "File can't larger than " +
					Properties.Settings.Default.LimitSize + " MB.", "Attention");
				return;
			}

			this._FileSize = file.Length;
			this.HashButton.Enabled = false;
			this.HashProgressBar.Value = 0;
			this.PrepareHashFunction();
			this._BackgroundWorker.RunWorkerAsync();
		}

		/// <summary>
		/// Cancel already running hashing worker  
		/// </summary>
		/// <param name="sender"></param>
		/// <param name="e"></param>
		private void CancelHashButton_Click(object sender, EventArgs e)
		{
			if (this._BackgroundWorker.WorkerSupportsCancellation == true)
			{
				this._BackgroundWorker.CancelAsync();
				this.HashButton.Enabled = true;
			}
		}

		#endregion Button Event

		#region TextBox Event

		private void FileLocationTextBox_DragDrop(object sender, DragEventArgs e)
		{
			if (e.Data.GetDataPresent(DataFormats.FileDrop, false) == true)
			{
				e.Effect = DragDropEffects.All;
			}

			var temp = (string[])e.Data.GetData(DataFormats.FileDrop, false);
			this.FileLocationTextBox.Text = temp[0];
			this.HashValueTextBox.Text = "";
		}

		private void FileLocationTextBox_DragEnter(object sender, DragEventArgs e)
		{
			e.Effect = DragDropEffects.Link;
		}

		#endregion TextBox Event

		#region Backgroung Worker Event

		private void Hashing_DoWork(object sender, DoWorkEventArgs e)
		{
			BackgroundWorker worker = sender as BackgroundWorker;

			byte[] result = new byte[this._Hash.GetDigestSize()];

			using (Stream source = File.OpenRead(this.FileLocationTextBox.Text))
			{
				int BytesRead;
				long TotalBytesRead = 0;
				float progress;
				while ((BytesRead = source.Read(this._BlockSize, 0, this._BlockSize.Length)) > 0)
				{
					if (worker.CancellationPending == true)
					{
						e.Cancel = true;
						Array.Clear(this._BlockSize, 0, this._BlockSize.Length);
						break;
					}
					else
					{
						this._Hash.BlockUpdate(this._BlockSize, 0, BytesRead);
						TotalBytesRead += BytesRead;
						progress = (TotalBytesRead / this._FileSize) * 100;
						worker.ReportProgress((int)progress);
					}
				}
			}

			this._Hash.DoFinal(result, 0);

			Array.Clear(this._BlockSize, 0, this._BlockSize.Length);

			e.Result = Entities.HashFunctionList.ByteArrayToHexString(result);
		}

		private void Hashing_ProgressChanged(object sender, ProgressChangedEventArgs e)
		{
			this.HashProgressBar.Value = e.ProgressPercentage;

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

			this.HashButton.Enabled = true;
		}

		#endregion Backgroung Worker Event

		#region Private Method

		private void LoadHashList()
		{
			string[] temp = Entities.HashFunctionList.GetHashList();

			for (int i = 0; i < temp.Length; i++)
			{
				this.HashFunctionListComboBox.Items.Add(temp[i]);
			}
			this.HashFunctionListComboBox.Text = temp[0];
		}

		private void PrepareHashFunction()
		{
			if(this._Hash != null)
			{
				this._Hash.Reset();
			}

			switch (this.HashFunctionListComboBox.Text)
			{
				case "Blake2b - 256 bit":
					this._Hash = new Blake2bDigest(256);
					break;
				case "Blake2b - 512 bit":
					this._Hash = new Blake2bDigest(512);
					break;
				case "SHA-1":
					this._Hash = new Sha1Digest();
					break;
				case "SHA-2 256 bit":
					this._Hash = new Sha256Digest();
					break;
				case "SHA-2 512 bit":
					this._Hash = new Sha512Digest();
					break;
				case "SHA-3 256 bit":
					this._Hash = new Sha3Digest(256);
					break;
				case "SHA-3 512 bit":
					this._Hash = new Sha3Digest(512);
					break;
				default:
					this._Hash = new Sha1Digest();
					break;
			}
			this._Hash.Reset();
		}

		private string GetFileDirectory(string path)
		{
			FileInfo file = new FileInfo(path);
			return file.DirectoryName;
		}

		#endregion Private Method

	}
}
