using System;
using System.IO;
using System.Windows.Forms;

namespace OvPatch
{
    public partial class OneClickPatchForm : Form
    {
        public OneClickPatchForm()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectionChangeCommitted(object sender, EventArgs e)
        {
            optionsGroupBox.Enabled = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (camDistCheckBox.Checked)
                camDistance.Enabled = true;
            else
                camDistance.Enabled = false;
        }

        private void camDistance_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != Convert.ToChar(8))
                e.Handled = true;
        }

        private void camDistance_Leave(object sender, EventArgs e)
        {
            var camValue = 0;
            if (int.TryParse(camDistance.Text, out camValue))
            {
                if (camValue < 1134)
                    camDistance.Text = "1134";
                else if (camValue > 1999)
                    camDistance.Text = "1999";
            }
            else
                camDistance.Text = "1134";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var MainForm = Owner as MainForm;
                if (camDistCheckBox.Checked | unlockAddonsCheckBox.Checked | svCheatsCheckBox.Checked | backupCheckBox.Checked)
                {
                    if (OneClickSaveDlg.ShowDialog() == DialogResult.OK)
                    {
                        var oneClickFileStr = "@echo off\n" +
                                              "echo Patch in process...\n" +
                                              "start \"\" /wait \"" + Application.ExecutablePath + "\" \"" +
                                              MainForm.dotaFolder.Text + "\" " + gameComboBox.SelectedIndex + " " +
                                              Convert.ToInt32(camDistCheckBox.Checked) + " " +
                                              Convert.ToInt32(camDistance.Text) + " " +
                                              Convert.ToInt32(unlockAddonsCheckBox.Checked) + " " +
                                              Convert.ToInt32(svCheatsCheckBox.Checked) + " " +
                                              Convert.ToInt32(backupCheckBox.Checked) +
                                              "\necho Done\npause";
                        File.WriteAllText(OneClickSaveDlg.FileName, oneClickFileStr, System.Text.Encoding.GetEncoding(866));
                        MessageBox.Show("Done!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);Close();
                    }
                }
                else
                    MessageBox.Show("Need to choose at least one item", "Warning", MessageBoxButtons.OK,
                        MessageBoxIcon.Warning);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}