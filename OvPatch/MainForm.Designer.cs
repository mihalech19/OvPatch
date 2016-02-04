namespace OvPatch
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.visualStyler1 = new SkinSoft.VisualStyler.VisualStyler(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.dotaFolder = new System.Windows.Forms.TextBox();
            this.exitBtn = new System.Windows.Forms.Button();
            this.unlockAddonsCheckBox = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.patchBtn = new System.Windows.Forms.Button();
            this.tbCamDist = new System.Windows.Forms.TrackBar();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.backupCheckBox = new System.Windows.Forms.CheckBox();
            this.folderDlgBtn = new System.Windows.Forms.Button();
            this.camDist = new System.Windows.Forms.TextBox();
            this.dotaFolderDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.loadCamValueWorker = new System.ComponentModel.BackgroundWorker();
            this.patchWorker = new System.ComponentModel.BackgroundWorker();
            this.ourLabel1 = new System.Windows.Forms.Label();
            this.rb1200 = new System.Windows.Forms.RadioButton();
            this.rb1300 = new System.Windows.Forms.RadioButton();
            this.rb1400 = new System.Windows.Forms.RadioButton();
            this.rb1500 = new System.Windows.Forms.RadioButton();
            this.rb1600 = new System.Windows.Forms.RadioButton();
            this.rb1700 = new System.Windows.Forms.RadioButton();
            this.rb1800 = new System.Windows.Forms.RadioButton();
            this.rb1900 = new System.Windows.Forms.RadioButton();
            this.rb1999 = new System.Windows.Forms.RadioButton();
            this.svCheatsCheckBox = new System.Windows.Forms.CheckBox();
            this.SteamPathDlg = new System.Windows.Forms.FolderBrowserDialog();
            this.label3 = new System.Windows.Forms.Label();
            this.optionsBox = new System.Windows.Forms.GroupBox();
            this.gamesBox = new System.Windows.Forms.GroupBox();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.ourLabel2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCamDist)).BeginInit();
            this.optionsBox.SuspendLayout();
            this.gamesBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // visualStyler1
            // 
            this.visualStyler1.HostForm = this;
            this.visualStyler1.License = ((SkinSoft.VisualStyler.Licensing.VisualStylerLicense)(resources.GetObject("visualStyler1.License")));
            this.visualStyler1.LoadVisualStyle(null, "STALKER Style (Default).vssf");
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 236);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(379, 23);
            this.progressBar1.TabIndex = 0;
            // 
            // dotaFolder
            // 
            this.dotaFolder.Location = new System.Drawing.Point(12, 23);
            this.dotaFolder.Name = "dotaFolder";
            this.dotaFolder.Size = new System.Drawing.Size(345, 20);
            this.dotaFolder.TabIndex = 1;
            this.dotaFolder.TextChanged += new System.EventHandler(this.dotaFolder_TextChanged);
            // 
            // exitBtn
            // 
            this.exitBtn.BackColor = System.Drawing.SystemColors.Control;
            this.exitBtn.Location = new System.Drawing.Point(12, 265);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(187, 38);
            this.exitBtn.TabIndex = 2;
            this.exitBtn.Text = "Exit";
            this.exitBtn.UseVisualStyleBackColor = false;
            this.exitBtn.Click += new System.EventHandler(this.exitBtn_Click);
            // 
            // unlockAddonsCheckBox
            // 
            this.unlockAddonsCheckBox.Location = new System.Drawing.Point(6, 16);
            this.unlockAddonsCheckBox.Name = "unlockAddonsCheckBox";
            this.unlockAddonsCheckBox.Size = new System.Drawing.Size(130, 21);
            this.unlockAddonsCheckBox.TabIndex = 3;
            this.unlockAddonsCheckBox.Text = "Unlock -addon";
            this.unlockAddonsCheckBox.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(150, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Choose the folder with Dota 2:";
            // 
            // patchBtn
            // 
            this.patchBtn.Location = new System.Drawing.Point(204, 265);
            this.patchBtn.Name = "patchBtn";
            this.patchBtn.Size = new System.Drawing.Size(187, 38);
            this.patchBtn.TabIndex = 5;
            this.patchBtn.Text = "Patch";
            this.patchBtn.UseVisualStyleBackColor = true;
            this.patchBtn.Click += new System.EventHandler(this.patchBtn_Click);
            // 
            // tbCamDist
            // 
            this.tbCamDist.Enabled = false;
            this.tbCamDist.LargeChange = 100;
            this.tbCamDist.Location = new System.Drawing.Point(12, 75);
            this.tbCamDist.Maximum = 1999;
            this.tbCamDist.Minimum = 1134;
            this.tbCamDist.Name = "tbCamDist";
            this.tbCamDist.Size = new System.Drawing.Size(379, 45);
            this.tbCamDist.SmallChange = 50;
            this.tbCamDist.TabIndex = 6;
            this.tbCamDist.TabStop = false;
            this.tbCamDist.TickFrequency = 100;
            this.tbCamDist.TickStyle = System.Windows.Forms.TickStyle.None;
            this.tbCamDist.Value = 1134;
            this.tbCamDist.ValueChanged += new System.EventHandler(this.tbCamDist_ValueChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Camera distance:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(176, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 10;
            this.label4.Text = "Progress:";
            // 
            // backupCheckBox
            // 
            this.backupCheckBox.AutoSize = true;
            this.backupCheckBox.Location = new System.Drawing.Point(6, 61);
            this.backupCheckBox.Name = "backupCheckBox";
            this.backupCheckBox.Size = new System.Drawing.Size(96, 17);
            this.backupCheckBox.TabIndex = 11;
            this.backupCheckBox.Text = "Create backup";
            this.backupCheckBox.UseVisualStyleBackColor = true;
            // 
            // folderDlgBtn
            // 
            this.folderDlgBtn.Location = new System.Drawing.Point(363, 22);
            this.folderDlgBtn.Name = "folderDlgBtn";
            this.folderDlgBtn.Size = new System.Drawing.Size(28, 20);
            this.folderDlgBtn.TabIndex = 13;
            this.folderDlgBtn.Text = "...";
            this.folderDlgBtn.UseVisualStyleBackColor = true;
            this.folderDlgBtn.Click += new System.EventHandler(this.folderDlgBtn_Click);
            // 
            // camDist
            // 
            this.camDist.Location = new System.Drawing.Point(104, 49);
            this.camDist.MaxLength = 4;
            this.camDist.Name = "camDist";
            this.camDist.ReadOnly = true;
            this.camDist.Size = new System.Drawing.Size(253, 20);
            this.camDist.TabIndex = 15;
            this.camDist.Text = "Choose the folder with Dota 2!";
            this.camDist.TextChanged += new System.EventHandler(this.camDist_TextChanged);
            this.camDist.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox3_KeyPress);
            this.camDist.Leave += new System.EventHandler(this.camDist_Leave);
            // 
            // loadCamValueWorker
            // 
            this.loadCamValueWorker.WorkerSupportsCancellation = true;
            this.loadCamValueWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.loadCamValueWorker_DoWork);
            this.loadCamValueWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.loadCamValueWorker_RunWorkerCompleted);
            // 
            // patchWorker
            // 
            this.patchWorker.WorkerReportsProgress = true;
            this.patchWorker.WorkerSupportsCancellation = true;
            this.patchWorker.DoWork += new System.ComponentModel.DoWorkEventHandler(this.patchWorker_DoWork);
            this.patchWorker.ProgressChanged += new System.ComponentModel.ProgressChangedEventHandler(this.patchWorker_ProgressChanged);
            this.patchWorker.RunWorkerCompleted += new System.ComponentModel.RunWorkerCompletedEventHandler(this.patchWorker_RunWorkerCompleted);
            // 
            // ourLabel1
            // 
            this.ourLabel1.AutoSize = true;
            this.ourLabel1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ourLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.ourLabel1.Location = new System.Drawing.Point(9, 308);
            this.ourLabel1.Name = "ourLabel1";
            this.ourLabel1.Size = new System.Drawing.Size(157, 13);
            this.ourLabel1.TabIndex = 16;
            this.ourLabel1.Text = "http://vk.com/dota2knowledge";
            this.ourLabel1.Click += new System.EventHandler(this.Our_Click);
            // 
            // rb1200
            // 
            this.rb1200.AutoSize = true;
            this.rb1200.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1200.Location = new System.Drawing.Point(35, 97);
            this.rb1200.Name = "rb1200";
            this.rb1200.Size = new System.Drawing.Size(35, 30);
            this.rb1200.TabIndex = 19;
            this.rb1200.TabStop = true;
            this.rb1200.Tag = "1200";
            this.rb1200.Text = "1200";
            this.rb1200.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1200.UseVisualStyleBackColor = true;
            this.rb1200.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1300
            // 
            this.rb1300.AutoSize = true;
            this.rb1300.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1300.Location = new System.Drawing.Point(76, 97);
            this.rb1300.Name = "rb1300";
            this.rb1300.Size = new System.Drawing.Size(35, 30);
            this.rb1300.TabIndex = 20;
            this.rb1300.TabStop = true;
            this.rb1300.Tag = "1300";
            this.rb1300.Text = "1300";
            this.rb1300.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1300.UseVisualStyleBackColor = true;
            this.rb1300.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1400
            // 
            this.rb1400.AutoSize = true;
            this.rb1400.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1400.Location = new System.Drawing.Point(117, 97);
            this.rb1400.Name = "rb1400";
            this.rb1400.Size = new System.Drawing.Size(35, 30);
            this.rb1400.TabIndex = 21;
            this.rb1400.TabStop = true;
            this.rb1400.Tag = "1400";
            this.rb1400.Text = "1400";
            this.rb1400.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1400.UseVisualStyleBackColor = true;
            this.rb1400.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1500
            // 
            this.rb1500.AutoSize = true;
            this.rb1500.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1500.Location = new System.Drawing.Point(158, 97);
            this.rb1500.Name = "rb1500";
            this.rb1500.Size = new System.Drawing.Size(35, 30);
            this.rb1500.TabIndex = 22;
            this.rb1500.TabStop = true;
            this.rb1500.Tag = "1500";
            this.rb1500.Text = "1500";
            this.rb1500.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1500.UseVisualStyleBackColor = true;
            this.rb1500.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1600
            // 
            this.rb1600.AutoSize = true;
            this.rb1600.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1600.Location = new System.Drawing.Point(199, 97);
            this.rb1600.Name = "rb1600";
            this.rb1600.Size = new System.Drawing.Size(35, 30);
            this.rb1600.TabIndex = 23;
            this.rb1600.TabStop = true;
            this.rb1600.Tag = "1600";
            this.rb1600.Text = "1600";
            this.rb1600.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1600.UseVisualStyleBackColor = true;
            this.rb1600.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1700
            // 
            this.rb1700.AutoSize = true;
            this.rb1700.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1700.Location = new System.Drawing.Point(239, 97);
            this.rb1700.Name = "rb1700";
            this.rb1700.Size = new System.Drawing.Size(35, 30);
            this.rb1700.TabIndex = 24;
            this.rb1700.TabStop = true;
            this.rb1700.Tag = "1700";
            this.rb1700.Text = "1700";
            this.rb1700.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1700.UseVisualStyleBackColor = true;
            this.rb1700.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1800
            // 
            this.rb1800.AutoSize = true;
            this.rb1800.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1800.Location = new System.Drawing.Point(280, 97);
            this.rb1800.Name = "rb1800";
            this.rb1800.Size = new System.Drawing.Size(35, 30);
            this.rb1800.TabIndex = 25;
            this.rb1800.TabStop = true;
            this.rb1800.Tag = "1800";
            this.rb1800.Text = "1800";
            this.rb1800.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1800.UseVisualStyleBackColor = true;
            this.rb1800.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1900
            // 
            this.rb1900.AutoSize = true;
            this.rb1900.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1900.Location = new System.Drawing.Point(321, 97);
            this.rb1900.Name = "rb1900";
            this.rb1900.Size = new System.Drawing.Size(35, 30);
            this.rb1900.TabIndex = 26;
            this.rb1900.TabStop = true;
            this.rb1900.Tag = "1900";
            this.rb1900.Text = "1900";
            this.rb1900.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1900.UseVisualStyleBackColor = true;
            this.rb1900.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // rb1999
            // 
            this.rb1999.AutoSize = true;
            this.rb1999.CheckAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rb1999.Location = new System.Drawing.Point(361, 97);
            this.rb1999.Name = "rb1999";
            this.rb1999.Size = new System.Drawing.Size(35, 30);
            this.rb1999.TabIndex = 27;
            this.rb1999.TabStop = true;
            this.rb1999.Tag = "1999";
            this.rb1999.Text = "1999";
            this.rb1999.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.rb1999.UseVisualStyleBackColor = true;
            this.rb1999.CheckedChanged += new System.EventHandler(this.rb1200_CheckedChanged);
            // 
            // svCheatsCheckBox
            // 
            this.svCheatsCheckBox.AutoSize = true;
            this.svCheatsCheckBox.Location = new System.Drawing.Point(6, 39);
            this.svCheatsCheckBox.Name = "svCheatsCheckBox";
            this.svCheatsCheckBox.Size = new System.Drawing.Size(122, 17);
            this.svCheatsCheckBox.TabIndex = 28;
            this.svCheatsCheckBox.Text = "Sv_cheats 1 bypass";
            this.svCheatsCheckBox.UseVisualStyleBackColor = true;
            // 
            // SteamPathDlg
            // 
            this.SteamPathDlg.Description = "Select steam folder";
            this.SteamPathDlg.SelectedPath = "ProgramFiles";
            this.SteamPathDlg.ShowNewFolderButton = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.label3.Location = new System.Drawing.Point(279, 308);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(112, 13);
            this.label3.TabIndex = 29;
            this.label3.Text = "Create OneClickPatch";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // optionsBox
            // 
            this.optionsBox.Controls.Add(this.unlockAddonsCheckBox);
            this.optionsBox.Controls.Add(this.backupCheckBox);
            this.optionsBox.Controls.Add(this.svCheatsCheckBox);
            this.optionsBox.Location = new System.Drawing.Point(12, 130);
            this.optionsBox.Name = "optionsBox";
            this.optionsBox.Size = new System.Drawing.Size(204, 87);
            this.optionsBox.TabIndex = 30;
            this.optionsBox.TabStop = false;
            this.optionsBox.Text = "Options";
            // 
            // gamesBox
            // 
            this.gamesBox.Controls.Add(this.radioButton3);
            this.gamesBox.Controls.Add(this.radioButton2);
            this.gamesBox.Controls.Add(this.radioButton1);
            this.gamesBox.Location = new System.Drawing.Point(222, 130);
            this.gamesBox.Name = "gamesBox";
            this.gamesBox.Size = new System.Drawing.Size(169, 87);
            this.gamesBox.TabIndex = 31;
            this.gamesBox.TabStop = false;
            this.gamesBox.Text = "Game";
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(6, 60);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(146, 17);
            this.radioButton3.TabIndex = 0;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "Dota 2 - Reborn Beta x64";
            this.radioButton3.UseVisualStyleBackColor = true;
            this.radioButton3.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 38);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(126, 17);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "Dota 2 - Reborn Beta";
            this.radioButton2.UseVisualStyleBackColor = true;
            this.radioButton2.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Enabled = false;
            this.radioButton1.Location = new System.Drawing.Point(7, 17);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(57, 17);
            this.radioButton1.TabIndex = 2;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "Dota 2";
            this.radioButton1.UseVisualStyleBackColor = true;
            this.radioButton1.Click += new System.EventHandler(this.radioButton1_Click);
            // 
            // ourLabel2
            // 
            this.ourLabel2.AutoSize = true;
            this.ourLabel2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ourLabel2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline);
            this.ourLabel2.Location = new System.Drawing.Point(9, 325);
            this.ourLabel2.Name = "ourLabel2";
            this.ourLabel2.Size = new System.Drawing.Size(116, 13);
            this.ourLabel2.TabIndex = 32;
            this.ourLabel2.Text = "http://jet-shark.ucoz.ru";
            this.ourLabel2.Click += new System.EventHandler(this.ourLabel2_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Hand;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(279, 325);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 13);
            this.label5.TabIndex = 33;
            this.label5.Text = "Restore from backup";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 346);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ourLabel2);
            this.Controls.Add(this.gamesBox);
            this.Controls.Add(this.optionsBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rb1999);
            this.Controls.Add(this.rb1900);
            this.Controls.Add(this.rb1800);
            this.Controls.Add(this.rb1700);
            this.Controls.Add(this.rb1600);
            this.Controls.Add(this.rb1500);
            this.Controls.Add(this.rb1400);
            this.Controls.Add(this.rb1300);
            this.Controls.Add(this.rb1200);
            this.Controls.Add(this.ourLabel1);
            this.Controls.Add(this.camDist);
            this.Controls.Add(this.folderDlgBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tbCamDist);
            this.Controls.Add(this.patchBtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.dotaFolder);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = global::OvPatch.Properties.Resources.prog_icon;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Patch";
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.visualStyler1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCamDist)).EndInit();
            this.optionsBox.ResumeLayout(false);
            this.optionsBox.PerformLayout();
            this.gamesBox.ResumeLayout(false);
            this.gamesBox.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SkinSoft.VisualStyler.VisualStyler visualStyler1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox unlockAddonsCheckBox;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TrackBar tbCamDist;
        private System.Windows.Forms.Button patchBtn;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox backupCheckBox;
        private System.Windows.Forms.Button folderDlgBtn;
        private System.Windows.Forms.TextBox camDist;
        private System.Windows.Forms.FolderBrowserDialog dotaFolderDlg;
        private System.ComponentModel.BackgroundWorker loadCamValueWorker;
        private System.ComponentModel.BackgroundWorker patchWorker;
        private System.Windows.Forms.Label ourLabel1;
        private System.Windows.Forms.RadioButton rb1999;
        private System.Windows.Forms.RadioButton rb1900;
        private System.Windows.Forms.RadioButton rb1800;
        private System.Windows.Forms.RadioButton rb1700;
        private System.Windows.Forms.RadioButton rb1600;
        private System.Windows.Forms.RadioButton rb1500;
        private System.Windows.Forms.RadioButton rb1400;
        private System.Windows.Forms.RadioButton rb1300;
        private System.Windows.Forms.RadioButton rb1200;
        private System.Windows.Forms.CheckBox svCheatsCheckBox;
        private System.Windows.Forms.FolderBrowserDialog SteamPathDlg;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox gamesBox;
        private System.Windows.Forms.GroupBox optionsBox;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        public System.Windows.Forms.TextBox dotaFolder;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label ourLabel2;
        private System.Windows.Forms.Label label5;
    }
}

