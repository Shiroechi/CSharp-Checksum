using System;
using System.Windows.Forms;

namespace CSharpChecksum.UserControls
{
	public partial class SettingsControl : UserControl
	{
		#region Member

		private ToolTip _ToolTip = new ToolTip();

		#endregion Member

		public SettingsControl()
		{
			InitializeComponent();
		}

		private void SettingsControl_Load(object sender, EventArgs e)
		{
			this.LimitSizeValue.Value = Properties.Settings.Default.LimitSize;
			this.BlockSizeValue.Value = Properties.Settings.Default.BlockSize;
			
			// Set up the delays for the ToolTip.
			this._ToolTip.AutoPopDelay = 5000;
			this._ToolTip.InitialDelay = 1000;
			this._ToolTip.ReshowDelay = 500;
			// Force the ToolTip text to be displayed whether or not the form is active.
			this._ToolTip.ShowAlways = true;

			// Set up the ToolTip text for the Button and Checkbox.
			this._ToolTip.SetToolTip(this.LimitSizeLabel, "Max file size to hash.");
			this._ToolTip.SetToolTip(this.BlockSizeLabel, "Block size to read from file when hashing.");
		}

		private void SaveButton_Click(object sender, EventArgs e)
		{
			Properties.Settings.Default.LimitSize = (int) this.LimitSizeValue.Value;
			Properties.Settings.Default.BlockSize = (int) this.BlockSizeValue.Value;
			Properties.Settings.Default.Upgrade();
			Properties.Settings.Default.Save();
		}
	}
}
