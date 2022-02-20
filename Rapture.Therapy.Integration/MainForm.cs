using Rapture.Therapy.Integration.Configuration;

namespace Rapture.Therapy.Integration
{
    public partial class MainForm : Form
    {
        private RaptureTherapyIntegrationSettings AppSettings { get; }

        public MainForm(RaptureTherapyIntegrationSettings appSettings)
        {
            AppSettings = appSettings;

            InitializeComponent();
        }

        private void ButtonExit_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}