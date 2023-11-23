namespace PrudentDashboards.UI
{
    public partial class FormProgress : Form
    {
        public bool IsVisible { get; private set; } = false;
        public class ProgressFormStatus
        {
            public string Caption { get; set; } = string.Empty;
            public string Header { get; set; } = string.Empty;
            public string Body { get; set; } = string.Empty;
            public int? ProgressValue { get; set; }
            public int? ProgressMinimum { get; set; }
            public int? ProgressMaximum { get; set; }

            public ProgressFormStatus()
            {
                ProgressValue = null;
                ProgressMinimum = null;
                ProgressMaximum = null;
            }
        }

        public void WaitForVisible()
        {
            while (IsVisible == false)
            {
                Thread.Sleep(10);
            }
        }

        #region Events

        public class OnCancelInfo
        {
            public bool Cancel = false;
        }

        public delegate void EventOnCancel(object? sender, OnCancelInfo e);
        public event EventOnCancel? OnCancel;

        #endregion

        public FormProgress()
        {
            InitializeComponent();

            lblHeader.Text = "Please wait...";
            lblBody.Text = "";
            cmdCancel.Enabled = false;
            pbProgress.Minimum = 0;
            pbProgress.Maximum = 100;

            DialogResult = DialogResult.OK;
        }

        private void CmdCancel_Click(object? sender, EventArgs e)
        {
            if (OnCancel != null)
            {
                OnCancelInfo onCancelInfo = new();
                OnCancel(this, onCancelInfo);
                if (onCancelInfo.Cancel)
                {
                    return;
                }
            }

            DialogResult = DialogResult.Cancel;
            Close();

        }

        #region Properties.
        public bool CanCancel
        {
            get { return cmdCancel.Enabled; }
            set { cmdCancel.Enabled = value; }
        }
        public string CaptionText
        {
            get { return Text; }
            set { Text = value; }
        }
        public string HeaderText
        {
            get { return lblHeader.Text; }
            set { lblHeader.Text = value; }
        }
        public string BodyText
        {
            get { return lblBody.Text; }
            set { lblBody.Text = value; }
        }
        public int ProgressMinimum
        {
            get { return pbProgress.Minimum; }
            set { pbProgress.Minimum = value; }
        }
        public int ProgressMaximum
        {
            get { return pbProgress.Maximum; }
            set { pbProgress.Maximum = value; }
        }
        public int ProgressPosition
        {
            get { return pbProgress.Value; }
            set
            {
                if (pbProgress.Value > 0 && pbProgress.Style == ProgressBarStyle.Marquee)
                {
                    pbProgress.Style = ProgressBarStyle.Continuous;
                }
                pbProgress.Value = value;
            }
        }
        public ProgressBarStyle ProgressStyle
        {
            get { return pbProgress.Style; }
            set { pbProgress.Style = value; }
        }
        #endregion


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
                Invoke(new Action(() => Close(result)));
                return;
            }
            DialogResult = result;
            base.Close();
        }

        public void UpdateStatus(ProgressFormStatus? status)
        {
            if (InvokeRequired)
            {
                Invoke(new Action(() => UpdateStatus(status)));
                return;
            }


            if (status != null)
            {
                if (status.Caption != null)
                {
                    CaptionText = status.Caption;
                }

                if (status.Header != null)
                {
                    HeaderText = status.Header;
                }

                if (status.Body != null)
                {
                    BodyText = status.Body;
                }

                if (status.ProgressValue != null)
                {
                    ProgressPosition = (int)status.ProgressValue;
                }

                if (status.ProgressMinimum != null)
                {
                    ProgressMinimum = (int)status.ProgressMinimum;
                }

                if (status.ProgressMaximum != null)
                {
                    ProgressMaximum = (int)status.ProgressMaximum;
                }
            }
        }

        private void FormProgress_Shown(object? sender, EventArgs e)
        {
            IsVisible = true;
        }
    }
}
