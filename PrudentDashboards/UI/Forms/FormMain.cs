using Library;
using NTDLS.NASCCL;
using PrudentDashboards.UI;
using System.Data.SqlClient;
using UI.Forms;

namespace UI
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();
        }

        public new void Close()
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Close()));
                return;
            }
            base.Close();
        }

        public void Close(DialogResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Close()));
                return;
            }
            DialogResult = result;
            base.Close();
        }

        private void ShowErrorMessage(string text)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => ShowErrorMessage(text)));
                return;
            }
            MessageBox.Show(text, Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void datasourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (var formDataSources = new FormDataSources())
            {
                formDataSources.ShowDialog();
            }
        }
    }
}
