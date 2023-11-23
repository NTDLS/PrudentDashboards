using Library;
using Library.Models;
using PrudentDashboards.UI;
using System.Data.SqlClient;

namespace UI.Forms
{
    public partial class FormDataSource : Form
    {
        public DataSourceModel DataSource { get; set; }

        public FormDataSource()
        {
            InitializeComponent();
            DataSource = new DataSourceModel()
            {
                IntegratedSecurity = true,
            };
        }

        public FormDataSource(DataSourceModel? connectionInfo)
        {
            if (connectionInfo == null)
            {
                DataSource = new DataSourceModel()
                {
                    IntegratedSecurity = true,
                };
            }
            else
            {
                DataSource = connectionInfo;
            }
            InitializeComponent();
        }

        private void EstablishSQLServerConnection_Load(object sender, EventArgs e)
        {
            AcceptButton = buttonOk;
            CancelButton = buttonCancel;

            textBoxName.Text = DataSource.Name;
            textBoxDescription.Text = DataSource.Description;
            textBoxUsername.Text = DataSource.UserName;
            textBoxPassword.Text = DataSource.Password;
            textBoxServerName.Text = DataSource.ServerName;
            textBoxDatabaseName.Text = DataSource.DatabaseName;
            checkBoxIntegratedSecurity.Checked = DataSource.IntegratedSecurity;

            CheckboxIntegratedSecurity_CheckedChanged(this, new EventArgs());
        }

        private void ButtonOk_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(textBoxName.Text))
            {
                MessageBox.Show("You must enter a name (this is just for your identification).", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxServerName.Text))
            {
                MessageBox.Show("You must enter a server name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (string.IsNullOrWhiteSpace(textBoxDatabaseName.Text))
            {
                MessageBox.Show("You must enter a database name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                return;
            }

            if (checkBoxIntegratedSecurity.Checked == false)
            {
                if (string.IsNullOrWhiteSpace(textBoxUsername.Text))
                {
                    MessageBox.Show("You must enter a user name.", Constants.TitleCaption, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    return;
                }
            }

            using (var progressForm = new FormProgress())
            {
                var thread = new Thread(() =>
                {
                    progressForm.WaitForVisible();

                    var builder = new SqlConnectionStringBuilder()
                    {
                        DataSource = textBoxServerName.Text,
                        InitialCatalog = textBoxDatabaseName.Text,
                        UserID = textBoxUsername.Text,
                        Password = textBoxPassword.Text,
                        IntegratedSecurity = checkBoxIntegratedSecurity.Checked
                    };

                    using (var sqlConnection = new SqlConnection(builder.ToString()))
                    {
                        try
                        {
                            sqlConnection.Open();
                            progressForm.Close();

                            DataSource = new DataSourceModel()
                            {
                                Name = textBoxName.Text,
                                Description = textBoxDescription.Text,
                                ServerName = textBoxServerName.Text,
                                DatabaseName = textBoxDatabaseName.Text,
                                UserName = textBoxUsername.Text,
                                Password = textBoxPassword.Text,
                                IntegratedSecurity = checkBoxIntegratedSecurity.Checked
                            };

                            Close(DialogResult.OK);
                        }
                        catch (Exception ex)
                        {
                            ShowErrorMessage(ex.Message);
                        }
                        finally
                        {
                            Utility.TryAndIgnore(sqlConnection.Close);
                        }
                    }

                    progressForm.Close();
                });

                thread.Start();

                progressForm.ShowDialog();
            }
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

        private void ButtonCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public void Close(DialogResult result)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => Close(result)));
                return;
            }
            DialogResult = result;
            base.Close();
        }

        private void CheckboxIntegratedSecurity_CheckedChanged(object sender, EventArgs e)
        {
            textBoxUsername.Enabled = !checkBoxIntegratedSecurity.Checked;
            textBoxPassword.Enabled = !checkBoxIntegratedSecurity.Checked;
        }
    }
}
