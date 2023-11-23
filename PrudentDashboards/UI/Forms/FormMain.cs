using Library;
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
                Invoke(new Action(Close));
                return;
            }
            base.Close();
        }

        public void Close(DialogResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(Close));
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

        private void DatasourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formDataSources = new FormDataSourceCollection();
            formDataSources.ShowDialog();
        }

        private void DataviewsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formDataSourceViews = new FormDataSourceViewCollection();
            formDataSourceViews.ShowDialog();
        }

        private void ChartsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using var formChartCollection = new FormChartCollection();
            formChartCollection.ShowDialog();
        }
    }
}
