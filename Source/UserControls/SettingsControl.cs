using System;
using System.Windows.Forms;

namespace CSharpChecksum.UserControls
{
	public partial class SettingsControl : UserControl
	{
		public SettingsControl()
		{
			InitializeComponent();
		}

		private void SettingsControl_Load(object sender, EventArgs e)
		{
			this.LimitSizeValue.Value = Properties.Settings.Default.LimitSize;
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.LimitSize = (long) this.LimitSizeValue.Value;
			Properties.Settings.Default.Save();
		}
	}
}
