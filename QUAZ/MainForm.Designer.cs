﻿namespace QUAZ
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
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.numberOfQuestion = new System.Windows.Forms.ToolStripStatusLabel();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.btnExit = new MetroFramework.Controls.MetroButton();
            this.btnMinimize = new MetroFramework.Controls.MetroButton();
            this.topPanel = new MetroFramework.Controls.MetroPanel();
            this.labelNameApp = new MetroFramework.Controls.MetroLabel();
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveAsItem = new System.Windows.Forms.ToolStripMenuItem();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.statusStrip.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.menuStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip
            // 
            this.statusStrip.BackColor = System.Drawing.Color.Black;
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.numberOfQuestion});
            this.statusStrip.Location = new System.Drawing.Point(0, 502);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(801, 22);
            this.statusStrip.TabIndex = 14;
            // 
            // numberOfQuestion
            // 
            this.numberOfQuestion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.numberOfQuestion.ForeColor = System.Drawing.Color.White;
            this.numberOfQuestion.Name = "numberOfQuestion";
            this.numberOfQuestion.Size = new System.Drawing.Size(0, 17);
            this.numberOfQuestion.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Black;
            this.btnExit.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnExit.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnExit.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnExit.Location = new System.Drawing.Point(749, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(51, 43);
            this.btnExit.TabIndex = 18;
            this.btnExit.TabStop = false;
            this.btnExit.Text = "X";
            this.btnExit.UseCustomBackColor = true;
            this.btnExit.UseCustomForeColor = true;
            this.btnExit.UseSelectable = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnMinimize
            // 
            this.btnMinimize.BackColor = System.Drawing.Color.Black;
            this.btnMinimize.FontSize = MetroFramework.MetroButtonSize.Tall;
            this.btnMinimize.FontWeight = MetroFramework.MetroButtonWeight.Regular;
            this.btnMinimize.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.btnMinimize.Location = new System.Drawing.Point(701, 0);
            this.btnMinimize.Name = "btnMinimize";
            this.btnMinimize.Size = new System.Drawing.Size(51, 43);
            this.btnMinimize.TabIndex = 19;
            this.btnMinimize.TabStop = false;
            this.btnMinimize.Text = "_";
            this.btnMinimize.UseCustomBackColor = true;
            this.btnMinimize.UseCustomForeColor = true;
            this.btnMinimize.UseSelectable = true;
            this.btnMinimize.Click += new System.EventHandler(this.btnMinimize_Click);
            // 
            // topPanel
            // 
            this.topPanel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.topPanel.BackColor = System.Drawing.Color.Black;
            this.topPanel.Controls.Add(this.pictureBox1);
            this.topPanel.Controls.Add(this.labelNameApp);
            this.topPanel.HorizontalScrollbarBarColor = true;
            this.topPanel.HorizontalScrollbarHighlightOnWheel = false;
            this.topPanel.HorizontalScrollbarSize = 10;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(707, 43);
            this.topPanel.TabIndex = 20;
            this.topPanel.UseCustomBackColor = true;
            this.topPanel.VerticalScrollbarBarColor = true;
            this.topPanel.VerticalScrollbarHighlightOnWheel = false;
            this.topPanel.VerticalScrollbarSize = 10;
            this.topPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseDown);
            this.topPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseMove);
            this.topPanel.MouseUp += new System.Windows.Forms.MouseEventHandler(this.topPanel_MouseUp);
            // 
            // labelNameApp
            // 
            this.labelNameApp.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.labelNameApp.FontWeight = MetroFramework.MetroLabelWeight.Regular;
            this.labelNameApp.ForeColor = System.Drawing.Color.Silver;
            this.labelNameApp.Location = new System.Drawing.Point(48, 9);
            this.labelNameApp.Name = "labelNameApp";
            this.labelNameApp.Size = new System.Drawing.Size(145, 25);
            this.labelNameApp.TabIndex = 2;
            this.labelNameApp.Text = "EYEquiz";
            this.labelNameApp.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.labelNameApp.UseCustomBackColor = true;
            this.labelNameApp.UseCustomForeColor = true;
            // 
            // menuStrip
            // 
            this.menuStrip.AllowItemReorder = true;
            this.menuStrip.BackColor = System.Drawing.Color.Gray;
            this.menuStrip.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip.Location = new System.Drawing.Point(0, 46);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(45, 24);
            this.menuStrip.TabIndex = 21;
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveItem,
            this.saveAsItem});
            this.fileToolStripMenuItem.Enabled = false;
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveItem
            // 
            this.saveItem.BackColor = System.Drawing.Color.Gray;
            this.saveItem.Name = "saveItem";
            this.saveItem.Size = new System.Drawing.Size(180, 22);
            this.saveItem.Text = "Save ";
            this.saveItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // saveAsItem
            // 
            this.saveAsItem.BackColor = System.Drawing.Color.Gray;
            this.saveAsItem.Name = "saveAsItem";
            this.saveAsItem.Size = new System.Drawing.Size(180, 22);
            this.saveAsItem.Text = "Save as..";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(44, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(61)))), ((int)(((byte)(61)))), ((int)(((byte)(61)))));
            this.ClientSize = new System.Drawing.Size(801, 524);
            this.Controls.Add(this.btnMinimize);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.menuStrip);
            this.Controls.Add(this.topPanel);
            this.Controls.Add(this.btnExit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUAZ";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.topPanel.ResumeLayout(false);
            this.menuStrip.ResumeLayout(false);
            this.menuStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel numberOfQuestion;
        private System.Windows.Forms.Timer timer;
        private MetroFramework.Controls.MetroButton btnExit;
        private MetroFramework.Controls.MetroButton btnMinimize;
        private MetroFramework.Controls.MetroPanel topPanel;
        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveItem;
        private System.Windows.Forms.ToolStripMenuItem saveAsItem;
        private MetroFramework.Controls.MetroLabel labelNameApp;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

