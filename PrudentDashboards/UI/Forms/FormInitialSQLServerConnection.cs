namespace PrudentDashboards.UI
{
    public partial class FormInitialSQLServerConnection : Form
    {
        private void SQLConnectForm_Load(object sender, EventArgs e)
        {
            AcceptButton = cmdOk;
            CancelButton = cmdCancel;
        }
    }
}
