using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Threading;
using System.Windows.Forms;

namespace OvPatch
{
    public partial class updaterForm : Form
    {
        private string[] currentVersionAndUrl;
        private string currentVersionWithUrl;
        private bool noUpdating;
        private bool readyToUpdate;
        private readonly string localVersion = "2.0.9";
        private readonly WebClient update = new WebClient();
        private readonly string UriVersion = "https://raw.githubusercontent.com/mihalech19/OvPatch/master/version.ini";

        public updaterForm()
        {
            InitializeComponent();
        }

        private void updaterForm_Shown(object sender, EventArgs e)
        {
            updatesWorker.RunWorkerAsync();
        }

        private void updatesWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            updatesWorker.ReportProgress(30);
            Thread.Sleep(500);
            try
            {
                currentVersionWithUrl = update.DownloadString(UriVersion);
                updatesWorker.ReportProgress(100);
                Thread.Sleep(500);
            }
            catch
            {
                updatesWorker.ReportProgress(1);
            }
            if (currentVersionWithUrl != string.Empty)
            {
                currentVersionAndUrl = currentVersionWithUrl.Split('|');
                if (currentVersionAndUrl[0] != localVersion)
                {
                    updatesWorker.ReportProgress(60);
                    try
                    {
                        update.DownloadFile(currentVersionAndUrl[1], "updater.exe");
                        update.DownloadFile(currentVersionAndUrl[2], "OvPatch2.exe");
                        readyToUpdate = true;
                        updatesWorker.ReportProgress(100);
                        Thread.Sleep(1500);
                    }
                    catch
                    {
                        if (File.Exists("updater.exe"))
                            File.Delete("updater.exe");
                        if (File.Exists("OvPatch2.exe"))
                            File.Delete("OvPatch2.exe");
                        updatesWorker.ReportProgress(2);
                    }
                }
                else
                {
                    noUpdating = true;
                }
            }
            else
            {
                updatesWorker.ReportProgress(2);
            }
        }

        private void updatesWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            switch (e.ProgressPercentage)
            {
                case 1:
                    MessageBox.Show("Error of verification of the version!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
                    Close();
                    break;
                case 2:
                    MessageBox.Show("Updating error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                    break;
                case 60:
                    progressBar1.Value = e.ProgressPercentage;
                    label2.Text = "Updating...";
                    break;
                case 100:
                    progressBar1.Value = e.ProgressPercentage;
                    label2.Text = "Done!";
                    break;
                default:
                    progressBar1.Value = e.ProgressPercentage;
                    break;
            }
        }

        private void updatesWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (noUpdating)
            {
                Close();
            }
            else if (File.Exists("updater.exe") & File.Exists("OvPatch2.exe"))
            {
                if (readyToUpdate)
                {
                    Process.Start("updater.exe", "OvPatch2.exe OvPatch.exe");
                    Process.GetCurrentProcess().Kill();
                }
                else
                {
                    MessageBox.Show("Updating error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    Close();
                }
            }
            else
            {
                MessageBox.Show("Updating error!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }
    }
}