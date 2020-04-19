using System;
using System.Windows.Forms;

namespace CSharpChecksum.Forms
{
	public partial class ChecksumForm : Form
	{
		#region Member

		private UserControl _CurrentControl;

		#endregion Member

		#region Constructor & Destructor

		public ChecksumForm()
		{
			InitializeComponent();
		}

		~ChecksumForm()
		{
			this._CurrentControl.Dispose();
			this.MainPanel.Dispose();
		}

		#endregion Constructor & Destructor

		#region Form Event

		private void ChecksumForm_Load(object sender, EventArgs e)
		{
			this._CurrentControl = new UserControls.HashFileControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

		private void ChecksumForm_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (MessageBox.Show("Are you sure that you would like to exit?", "Exit application", MessageBoxButtons.YesNo) == DialogResult.No)
			{
				e.Cancel = true;
			}
		}

		#endregion Form Event

		#region MenuStrip Event

		private void hashFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this._CurrentControl.GetType() == typeof(UserControls.HashFileControl))
			{
				return;
			}

			this.MainPanel.Controls.Remove(this._CurrentControl);
			this._CurrentControl.Dispose();
			this._CurrentControl = new UserControls.HashFileControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

		private void compareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this._CurrentControl.GetType() == typeof(UserControls.CompareHashFileControl))
			{
				return;
			}

			this.MainPanel.Controls.Remove(this._CurrentControl);
			this._CurrentControl.Dispose();
			this._CurrentControl = new UserControls.CompareHashFileControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this._CurrentControl.GetType() == typeof(UserControls.SettingsControl))
			{
				return;
			}

			this.MainPanel.Controls.Remove(this._CurrentControl);
			this._CurrentControl.Dispose();
			this._CurrentControl = new UserControls.SettingsControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

		private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
		{
			if (this._CurrentControl.GetType() == typeof(UserControls.AboutControl))
			{
				return;
			}

			this.MainPanel.Controls.Remove(this._CurrentControl);
			this._CurrentControl.Dispose();
			this._CurrentControl = new UserControls.AboutControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

		#endregion MenuStrip Event
	}
}
