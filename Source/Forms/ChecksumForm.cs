using System;
using System.Windows.Forms;

namespace CSharpChecksum.Forms
{
	public partial class ChecksumForm : Form
	{
		public ChecksumForm()
		{
			InitializeComponent();
		}

		private void ChecksumForm_Load(object sender, EventArgs e)
		{
			this.MainPanel.Controls.Add(new UserControls.HashFileControl());
		}

		private void hashFileToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainPanel.Controls.Clear();
			this.MainPanel.Controls.Add(new UserControls.HashFileControl());
		}

		private void compareToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainPanel.Controls.Clear();
			this.MainPanel.Controls.Add(new UserControls.CompareHashFileControl());
		}

		private void settingToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.MainPanel.Controls.Clear();
			this.MainPanel.Controls.Add(new UserControls.SettingsControl());
		}
	}
}
