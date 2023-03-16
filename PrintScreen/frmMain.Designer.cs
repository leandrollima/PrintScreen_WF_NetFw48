using Microsoft.Win32;
namespace PrintScreen
{
    partial class frmMain
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

   
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnGrabScreen = new System.Windows.Forms.Button();
            this.btnGrabArea = new System.Windows.Forms.Button();
            this.btnGrabAllWindows = new System.Windows.Forms.Button();
            this.folderBrowserDialog1 = new System.Windows.Forms.FolderBrowserDialog();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnFolder = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPrefix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rdbtnNumericalIncremental = new System.Windows.Forms.RadioButton();
            this.nupIncrementalNumber = new System.Windows.Forms.NumericUpDown();
            this.rdbtnDateTime = new System.Windows.Forms.RadioButton();
            this.rdbtnGuid = new System.Windows.Forms.RadioButton();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.lblOpenFolder = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel3 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblFileName = new System.Windows.Forms.ToolStripStatusLabel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.nupIncrementalNumber)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnGrabScreen
            // 
            this.btnGrabScreen.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabScreen.Location = new System.Drawing.Point(249, 293);
            this.btnGrabScreen.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabScreen.Name = "btnGrabScreen";
            this.btnGrabScreen.Size = new System.Drawing.Size(205, 44);
            this.btnGrabScreen.TabIndex = 0;
            this.btnGrabScreen.Text = "Grab Screen";
            this.btnGrabScreen.UseVisualStyleBackColor = true;
            this.btnGrabScreen.Click += new System.EventHandler(this.btnGrabScreen_Click);
            // 
            // btnGrabArea
            // 
            this.btnGrabArea.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabArea.Location = new System.Drawing.Point(13, 293);
            this.btnGrabArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabArea.Name = "btnGrabArea";
            this.btnGrabArea.Size = new System.Drawing.Size(205, 44);
            this.btnGrabArea.TabIndex = 1;
            this.btnGrabArea.Text = "Grab Area";
            this.btnGrabArea.UseVisualStyleBackColor = true;
            this.btnGrabArea.Click += new System.EventHandler(this.btnGrabArea_Click);
            // 
            // btnGrabAllWindows
            // 
            this.btnGrabAllWindows.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabAllWindows.Location = new System.Drawing.Point(487, 293);
            this.btnGrabAllWindows.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabAllWindows.Name = "btnGrabAllWindows";
            this.btnGrabAllWindows.Size = new System.Drawing.Size(205, 44);
            this.btnGrabAllWindows.TabIndex = 3;
            this.btnGrabAllWindows.Text = "Grab all windows";
            this.btnGrabAllWindows.UseVisualStyleBackColor = true;
            this.btnGrabAllWindows.Click += new System.EventHandler(this.btnGrabAllWindows_Click);
            // 
            // txtFolder
            // 
            this.txtFolder.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFolder.Location = new System.Drawing.Point(173, 208);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(338, 32);
            this.txtFolder.TabIndex = 4;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(524, 201);
            this.btnFolder.Margin = new System.Windows.Forms.Padding(4);
            this.btnFolder.Name = "btnFolder";
            this.btnFolder.Size = new System.Drawing.Size(140, 44);
            this.btnFolder.TabIndex = 5;
            this.btnFolder.Text = "Folder";
            this.btnFolder.UseVisualStyleBackColor = true;
            this.btnFolder.Click += new System.EventHandler(this.btnFolder_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 46);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Prefix File Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sufix File Name:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(173, 43);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(486, 32);
            this.txtPrefix.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(93, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path:";
            // 
            // rdbtnNumericalIncremental
            // 
            this.rdbtnNumericalIncremental.AutoSize = true;
            this.rdbtnNumericalIncremental.Location = new System.Drawing.Point(173, 98);
            this.rdbtnNumericalIncremental.Name = "rdbtnNumericalIncremental";
            this.rdbtnNumericalIncremental.Size = new System.Drawing.Size(193, 27);
            this.rdbtnNumericalIncremental.TabIndex = 11;
            this.rdbtnNumericalIncremental.TabStop = true;
            this.rdbtnNumericalIncremental.Text = "Incremental number";
            this.rdbtnNumericalIncremental.UseVisualStyleBackColor = true;
            // 
            // nupIncrementalNumber
            // 
            this.nupIncrementalNumber.Location = new System.Drawing.Point(372, 98);
            this.nupIncrementalNumber.Name = "nupIncrementalNumber";
            this.nupIncrementalNumber.Size = new System.Drawing.Size(118, 31);
            this.nupIncrementalNumber.TabIndex = 12;
            this.nupIncrementalNumber.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // rdbtnDateTime
            // 
            this.rdbtnDateTime.AutoSize = true;
            this.rdbtnDateTime.Location = new System.Drawing.Point(173, 131);
            this.rdbtnDateTime.Name = "rdbtnDateTime";
            this.rdbtnDateTime.Size = new System.Drawing.Size(141, 27);
            this.rdbtnDateTime.TabIndex = 13;
            this.rdbtnDateTime.TabStop = true;
            this.rdbtnDateTime.Text = "Date and time";
            this.rdbtnDateTime.UseVisualStyleBackColor = true;
            // 
            // rdbtnGuid
            // 
            this.rdbtnGuid.AutoSize = true;
            this.rdbtnGuid.Location = new System.Drawing.Point(173, 165);
            this.rdbtnGuid.Name = "rdbtnGuid";
            this.rdbtnGuid.Size = new System.Drawing.Size(72, 27);
            this.rdbtnGuid.TabIndex = 14;
            this.rdbtnGuid.TabStop = true;
            this.rdbtnGuid.Text = "GUID";
            this.rdbtnGuid.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblOpenFolder,
            this.toolStripStatusLabel3,
            this.toolStripStatusLabel1,
            this.lblFileName});
            this.statusStrip1.Location = new System.Drawing.Point(0, 348);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(705, 29);
            this.statusStrip1.TabIndex = 16;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // lblOpenFolder
            // 
            this.lblOpenFolder.IsLink = true;
            this.lblOpenFolder.LinkVisited = true;
            this.lblOpenFolder.Name = "lblOpenFolder";
            this.lblOpenFolder.Size = new System.Drawing.Size(107, 23);
            this.lblOpenFolder.Text = "Open Folder";
            this.lblOpenFolder.Click += new System.EventHandler(this.lblOpenFolder_Click);
            // 
            // toolStripStatusLabel3
            // 
            this.toolStripStatusLabel3.Name = "toolStripStatusLabel3";
            this.toolStripStatusLabel3.Size = new System.Drawing.Size(19, 23);
            this.toolStripStatusLabel3.Text = "|";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(94, 23);
            this.toolStripStatusLabel1.Text = "File Name:";
            // 
            // lblFileName
            // 
            this.lblFileName.IsLink = true;
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 23);
            this.lblFileName.Click += new System.EventHandler(this.lblFileName_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtFolder);
            this.groupBox1.Controls.Add(this.rdbtnGuid);
            this.groupBox1.Controls.Add(this.btnFolder);
            this.groupBox1.Controls.Add(this.rdbtnDateTime);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nupIncrementalNumber);
            this.groupBox1.Controls.Add(this.txtPrefix);
            this.groupBox1.Controls.Add(this.rdbtnNumericalIncremental);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(681, 262);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Parameters to save screenshot";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 377);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.btnGrabAllWindows);
            this.Controls.Add(this.btnGrabArea);
            this.Controls.Add(this.btnGrabScreen);
            this.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "Print Screen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nupIncrementalNumber)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        private System.Windows.Forms.Button btnGrabScreen;
        private System.Windows.Forms.Button btnGrabArea;
        private System.Windows.Forms.Button btnGrabAllWindows;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialog1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnFolder;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPrefix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton rdbtnNumericalIncremental;
        private System.Windows.Forms.NumericUpDown nupIncrementalNumber;
        private System.Windows.Forms.RadioButton rdbtnDateTime;
        private System.Windows.Forms.RadioButton rdbtnGuid;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel lblFileName;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblOpenFolder;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel3;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}