using GenClassesFromQuery.Services;
using System;
using System.Windows.Forms;

namespace GenClassesFromQuery.Forms
{
    public partial class frmAbout : Form
    {
        private AppInstallHelper _installer = new AppInstallHelper();

        public frmAbout()
        {
            InitializeComponent();
        }

        private async void frmAbout_Load(object sender, EventArgs e)
        {
            lblVersion.Text = Application.ProductVersion;

            var check = await _installer.GetVersionCheckAsync();
            panel1.Visible = check.IsNew;
            lblNewVersion.Text = $"Version {check.Version} available:";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            _installer.AutoInstallAsync();
        }
    }
}