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
			this.MainPanel.Dispose();
			this.Dispose();
		}

		#endregion Constructor & Destructor

		private void ChecksumForm_Load(object sender, EventArgs e)
		{
			this._CurrentControl = new UserControls.HashFileControl();
			this.MainPanel.Controls.Add(this._CurrentControl);
		}

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
			//this.MainPanel.Controls.Clear();
			//this.MainPanel.Controls.Add(new UserControls.CompareHashFileControl());
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
			//this.MainPanel.Controls.Clear();
			//this.MainPanel.Controls.Add(new UserControls.SettingsControl());
		}
	}
}
