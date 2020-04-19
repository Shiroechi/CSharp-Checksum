using System.Windows.Forms;

namespace CSharpChecksum.UserControls
{
	public partial class AboutControl : UserControl
	{
		public AboutControl()
		{
			InitializeComponent();
		}

		~AboutControl()
		{
			label1.Dispose();
		}
	}
}
