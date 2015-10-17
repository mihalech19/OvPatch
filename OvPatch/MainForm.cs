using System;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using OvPatch.Properties;

namespace OvPatch
{
    public partial class MainForm : Form
    {
        private Match cameraDistance;
        private String sEngine2Dll;
        private String sPanoramaDll;
        private String sClientDll;
        private string steamPath = String.Empty;

        private readonly string[] dllPath =
        {
            @"\game\dota\bin\win64\client.dll", @"\game\dota\bin\win32\client.dll"
        };

        private readonly string[] engine2DllPath =
        {
            @"\game\bin\win64\engine2.dll", @"\game\bin\win32\engine2.dll"
        };

        private readonly string[] PanoramaDllPath =
        {
            @"\game\bin\win64\panorama.dll", @"\game\bin\win32\panorama.dll"
        };

        private readonly updaterForm updateForm = new updaterForm();

        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void camDist_Leave(object sender, EventArgs e)
        {
            var camValue = 0;
            if (int.TryParse(camDist.Text, out camValue))
            {
                if (camValue < 1134)
                    camDist.Text = "1134";
                else if (camValue > 1999)
                    camDist.Text = "1999";
            }
            else
                camDist.Text = "1134";
        }

        private void folderDlgBtn_Click(object sender, EventArgs e)
        {
            if (dotaFolderDlg.ShowDialog() == DialogResult.OK)
                dotaFolder.Text = dotaFolderDlg.SelectedPath;
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            (gamesBox.Controls[Settings.Default.selectedGame] as RadioButton).Checked = true;
            if (File.Exists("updater.exe"))
                File.Delete("updater.exe");
            updateForm.ShowDialog();
            if ((dotaFolder.Text = FoldersFind.DotaFind()) == String.Empty)
                if (Directory.Exists(FoldersFind.SteamFind() + @"\steamapps\common\dota 2 beta"))
                    dotaFolder.Text = FoldersFind.SteamFind() + @"\steamapps\common\dota 2 beta";
                else
                    MessageBox.Show("The program couldn't find the folder with Dota 2, but you can choose it manually",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void tbCamDist_ValueChanged(object sender, EventArgs e)
        {
            camDist.Text = tbCamDist.Value.ToString();
        }

        private void dotaFolder_TextChanged(object sender, EventArgs e)
        {
            if (Directory.Exists(dotaFolder.Text) & File.Exists(dotaFolder.Text + @"\game\dota\pak01_dir.vpk") &
                File.Exists(dotaFolder.Text + dllPath[Settings.Default.selectedGame]))
            {
                FoldersFind.SaveFolder(dotaFolder.Text);
                if (!loadCamValueWorker.IsBusy)
                {
                    tbCamDist.Value = 1134;
                    tbCamDist.Enabled = false;
                    camDist.ReadOnly = true;
                    camDist.Text = "Loading...";
                    loadCamValueWorker.RunWorkerAsync();
                }
            }
            else
            {
                tbCamDist.Value = 1134;
                tbCamDist.Enabled = false;
                camDist.ReadOnly = true;
                camDist.Text = "Choose the folder with Dota 2!";
            }
            if (File.Exists(dotaFolder.Text + dllPath[Settings.Default.selectedGame] + ".bak"))
                backupCheckBox.Checked = false;
            else
                backupCheckBox.Checked = true;
        }

        private void loadCamValueWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            sClientDll = File.ReadAllText(dotaFolder.Text + dllPath[Settings.Default.selectedGame],
                Encoding.Default);
            cameraDistance = Patch.FindCameraDistance(ref sClientDll);
        }

        private void loadCamValueWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            if (cameraDistance.Value != String.Empty)
            {
                tbCamDist.Enabled = true;
                camDist.ReadOnly = false;
                camDist.Text = cameraDistance.Value;
            }
            else
            {
                MessageBox.Show("Client.dll is damaged. Please choose a correct folder with Dota 2", "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
                camDist.Text = "Choose the folder with Dota 2!";
            }
        }

        private void camDist_TextChanged(object sender, EventArgs e)
        {
            var camValue = 0;
            if (int.TryParse(camDist.Text, out camValue))
            {
                if (camValue >= 1134 & camValue <= 1999)
                    tbCamDist.Value = camValue;
            }
        }

        private void patchBtn_Click(object sender, EventArgs e)
        {
           /* if (svCheatsCheckBox.Checked)
            {
                Patch.CloseSteamProcesses();
                Thread.Sleep(100);
                if (Process.GetProcessesByName("steam").Count() == 0)
                    Patch.AddOverrideVpk(steamPath);
            }
            */

            if (!patchWorker.IsBusy & !loadCamValueWorker.IsBusy)
            {
                if (!camDist.ReadOnly & Directory.Exists(dotaFolder.Text) &
                    File.Exists(dotaFolder.Text + @"\game\dota\pak01_dir.vpk") &
                    File.Exists(dotaFolder.Text + dllPath[Settings.Default.selectedGame]))
                {
                    Enabled = false;
                    patchWorker.RunWorkerAsync();
                }
                else
                    MessageBox.Show("Choose the correct folder with Dota 2!", "Error", MessageBoxButtons.OK,
                        MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("The program is still loading, just a minute please", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void patchWorker_DoWork(object sender, DoWorkEventArgs e)
        {
            try
            {
                if (backupCheckBox.Checked)
                    Patch.CreateBackup(dotaFolder.Text + dllPath[Settings.Default.selectedGame]);

                patchWorker.ReportProgress(30);
                Patch.ChangeCameraDistance(ref sClientDll, cameraDistance, camDist.Text);
                patchWorker.ReportProgress(60);

                if (unlockAddonsCheckBox.Checked | svCheatsCheckBox.Checked)
                {
                    if (backupCheckBox.Checked)
                        Patch.CreateBackup(dotaFolder.Text + engine2DllPath[Settings.Default.selectedGame]);
                   
                    sEngine2Dll = File.ReadAllText(dotaFolder.Text + engine2DllPath[Settings.Default.selectedGame], Encoding.Default);
                   // sPanoramaDll = File.ReadAllText(dotaFolder.Text + PanoramaDllPath[Settings.Default.selectedGame], Encoding.Default);

                    if (unlockAddonsCheckBox.Checked)
                        Patch.UnlockAddons(ref sEngine2Dll, ref sClientDll, ref sPanoramaDll, Settings.Default.selectedGame);

                    if (svCheatsCheckBox.Checked)
                        Patch.UnlockSvCheats(ref sEngine2Dll, Settings.Default.selectedGame);

                    File.WriteAllText(dotaFolder.Text + engine2DllPath[Settings.Default.selectedGame], sEngine2Dll,
                    Encoding.Default);
                    
                }
                patchWorker.ReportProgress(80);
                File.WriteAllText(dotaFolder.Text + dllPath[Settings.Default.selectedGame], sClientDll,
                    Encoding.Default);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void patchWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
                    progressBar1.Value = e.ProgressPercentage;
        }

        private void patchWorker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            progressBar1.Value = 100;
            if (backupCheckBox.Checked)
                backupCheckBox.Checked = false;
            if (unlockAddonsCheckBox.Checked)
                unlockAddonsCheckBox.Checked = false;
            Enabled = true;
            MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            progressBar1.Value = 0;
        }

        private void exitBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void Our_Click(object sender, EventArgs e)
        {
            Process.Start("http://vk.com/dota2knowledge");
        }

        private void rb1200_CheckedChanged(object sender, EventArgs e)
        {
            if (!camDist.ReadOnly)
                tbCamDist.Value = int.Parse((sender as RadioButton).Tag.ToString());
            (sender as RadioButton).Checked = false;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (svCheatsCheckBox.Checked)
            {
                if (steamPath == String.Empty)
                {
                    steamPath = FoldersFind.SteamFind();
                    if (steamPath == String.Empty | !Directory.Exists(steamPath + @"\userdata") |
                        !File.Exists(steamPath + @"\steam.exe"))
                    {
                        if (SteamPathDlg.ShowDialog() == DialogResult.OK)
                        {
                            if (Directory.Exists(SteamPathDlg.SelectedPath + @"\userdata") &
                                File.Exists(SteamPathDlg.SelectedPath + @"\steam.exe"))
                            {
                                steamPath = SteamPathDlg.SelectedPath;
                            }
                            else
                            {
                                svCheatsCheckBox.Checked = false;
                                steamPath = String.Empty;
                            }
                        }
                        else
                        {
                            svCheatsCheckBox.Checked = false;
                            steamPath = String.Empty;
                        }
                    }
                }
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {
            if (!camDist.ReadOnly)
            {
                var OneClickPatchForm = new OneClickPatchForm();
                OneClickPatchForm.Owner = this;
                OneClickPatchForm.ShowDialog();
            }
            else if (camDist.Text == "Loading...")
                MessageBox.Show("The program is still loading, just a minute please", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            else
                MessageBox.Show("First choose the correct folder with Dota 2!", "Error", MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            if (!loadCamValueWorker.IsBusy)
            {
                if (Settings.Default.selectedGame != (sender as RadioButton).TabIndex)
                {
                    Settings.Default.selectedGame = (sender as RadioButton).TabIndex;
                    Settings.Default.Save();
                    dotaFolder_TextChanged(new object(), EventArgs.Empty);
                }
            }
            else
            {
                (gamesBox.Controls[Settings.Default.selectedGame] as RadioButton).Checked = true;
                MessageBox.Show("The program is still loading, just a minute please", "Warning", MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
            }
        }

        private void ourLabel2_Click(object sender, EventArgs e)
        {
            Process.Start("http://jet-shark.ucoz.ru");
        }
    }
}