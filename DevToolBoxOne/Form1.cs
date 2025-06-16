// Ignore Spelling: FRM

using DevToolBoxOne.Forms.Converter;
using System.Windows.Forms;

namespace DevToolBoxOne
{
	public partial class DevDashBoard_FRM : Form
	{
		public DevDashBoard_FRM()
		{
			InitializeComponent();
		}

		private void ShamsiDate_BTN_Click(object sender, System.EventArgs e)
		{
			ShamsiDate_FRM ShamsiDateForm = new ShamsiDate_FRM();
			ShamsiDateForm.ShowDialog();
		}
	}
}
