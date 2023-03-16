﻿using Microsoft.Win32;
namespace Screen_Grab
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
            this.btnHelp = new System.Windows.Forms.Button();
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
            this.lblFileName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.nupIncrementalNumber)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGrabScreen
            // 
            this.btnGrabScreen.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabScreen.Location = new System.Drawing.Point(253, 268);
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
            this.btnGrabArea.Location = new System.Drawing.Point(28, 268);
            this.btnGrabArea.Margin = new System.Windows.Forms.Padding(4);
            this.btnGrabArea.Name = "btnGrabArea";
            this.btnGrabArea.Size = new System.Drawing.Size(205, 44);
            this.btnGrabArea.TabIndex = 1;
            this.btnGrabArea.Text = "Grab Area";
            this.btnGrabArea.UseVisualStyleBackColor = true;
            this.btnGrabArea.Click += new System.EventHandler(this.btnGrabArea_Click);
            // 
            // btnHelp
            // 
            this.btnHelp.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHelp.Location = new System.Drawing.Point(568, 28);
            this.btnHelp.Margin = new System.Windows.Forms.Padding(4);
            this.btnHelp.Name = "btnHelp";
            this.btnHelp.Size = new System.Drawing.Size(98, 44);
            this.btnHelp.TabIndex = 2;
            this.btnHelp.Text = "Help";
            this.btnHelp.UseVisualStyleBackColor = true;
            this.btnHelp.Click += new System.EventHandler(this.btnHelp_Click);
            // 
            // btnGrabAllWindows
            // 
            this.btnGrabAllWindows.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGrabAllWindows.Location = new System.Drawing.Point(466, 268);
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
            this.txtFolder.Location = new System.Drawing.Point(180, 208);
            this.txtFolder.Margin = new System.Windows.Forms.Padding(4);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(338, 32);
            this.txtFolder.TabIndex = 4;
            // 
            // btnFolder
            // 
            this.btnFolder.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFolder.Location = new System.Drawing.Point(531, 201);
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
            this.label1.Location = new System.Drawing.Point(19, 38);
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
            this.label2.Location = new System.Drawing.Point(26, 98);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 24);
            this.label2.TabIndex = 7;
            this.label2.Text = "Sufix File Name:";
            // 
            // txtPrefix
            // 
            this.txtPrefix.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrefix.Location = new System.Drawing.Point(180, 35);
            this.txtPrefix.Margin = new System.Windows.Forms.Padding(4);
            this.txtPrefix.Name = "txtPrefix";
            this.txtPrefix.Size = new System.Drawing.Size(317, 32);
            this.txtPrefix.TabIndex = 8;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Open Sans", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(100, 211);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 24);
            this.label3.TabIndex = 10;
            this.label3.Text = "Path:";
            // 
            // rdbtnNumericalIncremental
            // 
            this.rdbtnNumericalIncremental.AutoSize = true;
            this.rdbtnNumericalIncremental.Location = new System.Drawing.Point(180, 98);
            this.rdbtnNumericalIncremental.Name = "rdbtnNumericalIncremental";
            this.rdbtnNumericalIncremental.Size = new System.Drawing.Size(193, 27);
            this.rdbtnNumericalIncremental.TabIndex = 11;
            this.rdbtnNumericalIncremental.TabStop = true;
            this.rdbtnNumericalIncremental.Text = "Incremental number";
            this.rdbtnNumericalIncremental.UseVisualStyleBackColor = true;
            // 
            // nupIncrementalNumber
            // 
            this.nupIncrementalNumber.Location = new System.Drawing.Point(379, 98);
            this.nupIncrementalNumber.Name = "nupIncrementalNumber";
            this.nupIncrementalNumber.Size = new System.Drawing.Size(118, 31);
            this.nupIncrementalNumber.TabIndex = 12;
            // 
            // rdbtnDateTime
            // 
            this.rdbtnDateTime.AutoSize = true;
            this.rdbtnDateTime.Location = new System.Drawing.Point(180, 131);
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
            this.rdbtnGuid.Location = new System.Drawing.Point(180, 165);
            this.rdbtnGuid.Name = "rdbtnGuid";
            this.rdbtnGuid.Size = new System.Drawing.Size(72, 27);
            this.rdbtnGuid.TabIndex = 14;
            this.rdbtnGuid.TabStop = true;
            this.rdbtnGuid.Text = "GUID";
            this.rdbtnGuid.UseVisualStyleBackColor = true;
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(24, 339);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(91, 23);
            this.lblFileName.TabIndex = 15;
            this.lblFileName.Text = "File name:";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(705, 377);
            this.Controls.Add(this.lblFileName);
            this.Controls.Add(this.rdbtnGuid);
            this.Controls.Add(this.rdbtnDateTime);
            this.Controls.Add(this.nupIncrementalNumber);
            this.Controls.Add(this.rdbtnNumericalIncremental);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtPrefix);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnFolder);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.btnGrabAllWindows);
            this.Controls.Add(this.btnHelp);
            this.Controls.Add(this.btnGrabArea);
            this.Controls.Add(this.btnGrabScreen);
            this.Font = new System.Drawing.Font("Open Sans", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmMain";
            this.Text = "PrintScreen";
            this.TopMost = true;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.nupIncrementalNumber)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

       
        private System.Windows.Forms.Button btnGrabScreen;
        private System.Windows.Forms.Button btnGrabArea;
        private System.Windows.Forms.Button btnHelp;
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
        private System.Windows.Forms.Label lblFileName;
    }
}