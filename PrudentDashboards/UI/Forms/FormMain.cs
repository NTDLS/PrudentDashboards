using Library;
using NTDLS.NASCCL;
using PrudentDashboards.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using UI.Forms;

namespace UI
{
    public partial class FormMain : Form
    {
        private bool _firstShown = true;

        public FormMain()
        {
            InitializeComponent();

            Shown += FormMain_Shown;
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

        private SqlServerConnectionInfo? EstablishPrudentSQLServerConnection()
        {
            NASCCLStream encryptionProvider = new(Utility.GetCurrentuserEncryptionKey());
            var serverConnection = NTDLS.Persistence.ApplicationData.LoadFromDisk<SqlServerConnectionInfo>(Constants.TitleCaption, encryptionProvider.Cipher);

            if (serverConnection == null)
            {
                using (var formEstablishSQLServerConnection = new FormEstablishSQLServerConnection())
                {
                    if (formEstablishSQLServerConnection.ShowDialog() == DialogResult.OK)
                    {
                        NTDLS.Persistence.ApplicationData.SaveToDisk(Constants.TitleCaption, formEstablishSQLServerConnection.ConnectionInfo, encryptionProvider.Cipher);
                        return formEstablishSQLServerConnection.ConnectionInfo;
                    }
                    return null;
                }
            }

            return serverConnection;
        }

        private void FormMain_Shown(object? sender, EventArgs e)
        {

            if (_firstShown)
            {
                _firstShown = false;

                bool wasConnectionsuccessful = false;

                while (!wasConnectionsuccessful)
                {
                    var serverConnectionInfo = EstablishPrudentSQLServerConnection();
                    if (serverConnectionInfo == null)
                    {
                        Close();
                        return;
                    }

                    try
                    {
                        Utility.EnsureNotNull(serverConnectionInfo?.ServerName);
                        Utility.EnsureNotNull(serverConnectionInfo?.DatabaseName);

                        using (var progressForm = new FormProgress())
                        {
                            var thread = new Thread(() =>
                            {
                                progressForm.WaitForVisible();

                                try
                                {
                                    var builder = new SqlConnectionStringBuilder()
                                    {
                                        DataSource = serverConnectionInfo.ServerName,
                                        InitialCatalog = serverConnectionInfo.DatabaseName,
                                        UserID = serverConnectionInfo.UserName,
                                        Password = serverConnectionInfo.Password,
                                        IntegratedSecurity = serverConnectionInfo.IntegratedSecurity
                                    };

                                    using (var sqlConnection = new SqlConnection(builder.ToString()))
                                    {
                                        try
                                        {
                                            sqlConnection.Open();
                                            wasConnectionsuccessful = true;
                                            return; //Successfully connected to the database.
                                        }
                                        finally
                                        {
                                            Utility.TryAndIgnore(sqlConnection.Close);
                                        }
                                    }
                                }
                                finally
                                {
                                    progressForm.Close();
                                }
                            });

                            thread.Start();

                            progressForm.ShowDialog();
                        }
                    }
                    catch
                    {
                    }
                }
            }
        }

        private void datasourcesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
