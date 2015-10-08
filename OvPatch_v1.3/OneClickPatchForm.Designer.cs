namespace OvPatch
{
    partial class OneClickPatchForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.generateBtn = new System.Windows.Forms.Button();
            this.cancelBtn = new System.Windows.Forms.Button();
            this.gameComboBox = new System.Windows.Forms.ComboBox();
            this.camDistCheckBox = new System.Windows.Forms.CheckBox();
            this.camDistance = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.optionsGroupBox = new System.Windows.Forms.GroupBox();
            this.backupCheckBox = new System.Windows.Forms.CheckBox();
            this.unlockAddonsCheckBox = new System.Windows.Forms.CheckBox();
            this.OneClickSaveDlg = new System.Windows.Forms.SaveFileDialog();
            this.svCheatsCheckBox = new System.Windows.Forms.CheckBox();
            this.optionsGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // generateBtn
            // 
            this.generateBtn.Location = new System.Drawing.Point(12, 168);
            this.generateBtn.Name = "generateBtn";
            this.generateBtn.Size = new System.Drawing.Size(93, 30);
            this.generateBtn.TabIndex = 0;
            this.generateBtn.Text = "Generate";
            this.generateBtn.UseVisualStyleBackColor = true;
            this.generateBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancelBtn
            // 
            this.cancelBtn.Location = new System.Drawing.Point(179, 168);
            this.cancelBtn.Name = "cancelBtn";
            this.cancelBtn.Size = new System.Drawing.Size(93, 30);
            this.cancelBtn.TabIndex = 1;
            this.cancelBtn.Text = "Cancel";
            this.cancelBtn.UseVisualStyleBackColor = true;
            this.cancelBtn.Click += new System.EventHandler(this.cancelBtn_Click);
            // 
            // gameComboBox
            // 
            this.gameComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.gameComboBox.FormattingEnabled = true;
            this.gameComboBox.Items.AddRange(new object[] {
            "Dota 2 - Reborn Beta",
            "Dota 2 - Reborn Beta x64"});
            this.gameComboBox.Location = new System.Drawing.Point(12, 25);
            this.gameComboBox.Name = "gameComboBox";
            this.gameComboBox.Size = new System.Drawing.Size(260, 21);
            this.gameComboBox.TabIndex = 2;
            this.gameComboBox.SelectionChangeCommitted += new System.EventHandler(this.comboBox1_SelectionChangeCommitted);
            // 
            // camDistCheckBox
            // 
            this.camDistCheckBox.AutoSize = true;
            this.camDistCheckBox.Location = new System.Drawing.Point(6, 17);
            this.camDistCheckBox.Name = "camDistCheckBox";
            this.camDistCheckBox.Size = new System.Drawing.Size(147, 17);
            this.camDistCheckBox.TabIndex = 3;
            this.camDistCheckBox.Text = "Change camera distance:";
            this.camDistCheckBox.UseVisualStyleBackColor = true;
            this.camDistCheckBox.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // camDistance
            // 
            this.camDistance.Enabled = false;
            this.camDistance.Location = new System.Drawing.Point(147, 17);
            this.camDistance.MaxLength = 4;
            this.camDistance.Name = "camDistance";
            this.camDistance.Size = new System.Drawing.Size(107, 20);
            this.camDistance.TabIndex = 4;
            this.camDistance.Text = "1134";
            this.camDistance.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.camDistance_KeyPress);
            this.camDistance.Leave += new System.EventHandler(this.camDistance_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(93, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Choose the game:";
            // 
            // optionsGroupBox
            // 
            this.optionsGroupBox.Controls.Add(this.svCheatsCheckBox);
            this.optionsGroupBox.Controls.Add(this.camDistance);
            this.optionsGroupBox.Controls.Add(this.backupCheckBox);
            this.optionsGroupBox.Controls.Add(this.unlockAddonsCheckBox);
            this.optionsGroupBox.Controls.Add(this.camDistCheckBox);
            this.optionsGroupBox.Enabled = false;
            this.optionsGroupBox.Location = new System.Drawing.Point(12, 52);
            this.optionsGroupBox.Name = "optionsGroupBox";
            this.optionsGroupBox.Size = new System.Drawing.Size(260, 110);
            this.optionsGroupBox.TabIndex = 6;
            this.optionsGroupBox.TabStop = false;
            this.optionsGroupBox.Text = "Options";
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Location = new System.Drawing.Point(6, 86);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(96, 17);
            this.backupCheckBox.TabIndex = 6;
            this.backupCheckBox.Text = "Create backup";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            // 
            // unlockAddonsCheckBox
            // 
            this.unlockAddonsCheckBox.AutoSize = true;
            this.unlockAddonsCheckBox.Location = new System.Drawing.Point(6, 40);
            this.unlockAddonsCheckBox.Name = "unlockAddonsCheckBox";
            this.unlockAddonsCheckBox.Size = new System.Drawing.Size(96, 17);
            this.unlockAddonsCheckBox.TabIndex = 5;
            this.unlockAddonsCheckBox.Text = "Unlock -addon";
            this.unlockAddonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OneClickSaveDlg
            // 
            this.OneClickSaveDlg.FileName = "OvPatch.bat";
            this.OneClickSaveDlg.Filter = "Batch files|*.bat";
            // 
            // svCheatsCheckBox
            // 
            this.svCheatsCheckBox.AutoSize = true;
            this.svCheatsCheckBox.Location = new System.Drawing.Point(6, 63);
            this.svCheatsCheckBox.Name = "svCheatsCheckBox";
            this.svCheatsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.svCheatsCheckBox.TabIndex = 7;
            this.svCheatsCheckBox.Text = "Sv_cheats 1 bypass";
            this.svCheatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // OneClickPatchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 204);
            this.Controls.Add(this.optionsGroupBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gameComboBox);
            this.Controls.Add(this.cancelBtn);
            this.Controls.Add(this.generateBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::OvPatch.Properties.Resources.prog_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "OneClickPatchForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "OneClickPatch Creator";
            this.optionsGroupBox.ResumeLayout(false);
            this.optionsGroupBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button generateBtn;
        private System.Windows.Forms.Button cancelBtn;
        private System.Windows.Forms.ComboBox gameComboBox;
        private System.Windows.Forms.CheckBox camDistCheckBox;
        private System.Windows.Forms.TextBox camDistance;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox optionsGroupBox;
        private System.Windows.Forms.CheckBox unlockAddonsCheckBox;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.SaveFileDialog OneClickSaveDlg;
        private System.Windows.Forms.CheckBox svCheatsCheckBox;
    }
}