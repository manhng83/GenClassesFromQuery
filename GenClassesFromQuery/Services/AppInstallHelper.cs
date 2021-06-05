﻿using AzDeploy.Client;
using System;
using System.Windows.Forms;

namespace GenClassesFromQuery.Services
{
    internal class AppInstallHelper : InstallHelper
    {
        public AppInstallHelper() : base(Version.Parse(Application.ProductVersion), "aosoftware", "install", "GenClassesFromQuerySetup.exe")
        {
        }

        protected override void ExitApplication()
        {
            Application.Exit();
        }

        protected override bool PromptDownloadAndExit()
        {
            return (MessageBox.Show(
                "A new version is available. Click OK to download and exit the application now.",
                "New Version Available", MessageBoxButtons.OKCancel) == DialogResult.OK);
        }
    }
}