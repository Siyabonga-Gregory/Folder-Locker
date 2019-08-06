namespace GDE
{
    partial class GDE
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GDE));
            this.openEbooks = new System.Windows.Forms.OpenFileDialog();
            this.adminPanel = new System.Windows.Forms.GroupBox();
            this.btnUnlock = new System.Windows.Forms.Button();
            this.txtP2 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnFolderProtector = new System.Windows.Forms.Button();
            this.btnLock = new System.Windows.Forms.Button();
            this.txtP1 = new System.Windows.Forms.TextBox();
            this.txtFoldePath = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lblGhostCoderSA = new System.Windows.Forms.Label();
            this.openFolder = new System.Windows.Forms.FolderBrowserDialog();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.txtAdminPassword = new System.Windows.Forms.TextBox();
            this.adminPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // openEbooks
            // 
            this.openEbooks.FileName = "openFileDialog1";
            // 
            // adminPanel
            // 
            this.adminPanel.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.adminPanel.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.adminPanel.BackColor = System.Drawing.Color.Transparent;
            this.adminPanel.Controls.Add(this.btnUnlock);
            this.adminPanel.Controls.Add(this.txtP2);
            this.adminPanel.Controls.Add(this.label6);
            this.adminPanel.Controls.Add(this.btnFolderProtector);
            this.adminPanel.Controls.Add(this.btnLock);
            this.adminPanel.Controls.Add(this.txtP1);
            this.adminPanel.Controls.Add(this.txtFoldePath);
            this.adminPanel.Controls.Add(this.label9);
            this.adminPanel.Controls.Add(this.lblGhostCoderSA);
            this.adminPanel.Location = new System.Drawing.Point(4, 0);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(313, 171);
            this.adminPanel.TabIndex = 4;
            this.adminPanel.TabStop = false;
            this.adminPanel.Visible = false;
            // 
            // btnUnlock
            // 
            this.btnUnlock.ForeColor = System.Drawing.Color.Black;
            this.btnUnlock.Location = new System.Drawing.Point(240, 140);
            this.btnUnlock.Name = "btnUnlock";
            this.btnUnlock.Size = new System.Drawing.Size(68, 27);
            this.btnUnlock.TabIndex = 15;
            this.btnUnlock.Text = "Unlock";
            this.btnUnlock.UseVisualStyleBackColor = true;
            this.btnUnlock.Click += new System.EventHandler(this.btnUnlock_Click);
            // 
            // txtP2
            // 
            this.txtP2.Location = new System.Drawing.Point(160, 114);
            this.txtP2.Name = "txtP2";
            this.txtP2.PasswordChar = 'X';
            this.txtP2.Size = new System.Drawing.Size(148, 20);
            this.txtP2.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(6, 114);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 20);
            this.label6.TabIndex = 13;
            this.label6.Text = "Verify Password";
            // 
            // btnFolderProtector
            // 
            this.btnFolderProtector.ForeColor = System.Drawing.Color.Black;
            this.btnFolderProtector.Location = new System.Drawing.Point(16, 58);
            this.btnFolderProtector.Name = "btnFolderProtector";
            this.btnFolderProtector.Size = new System.Drawing.Size(84, 27);
            this.btnFolderProtector.TabIndex = 12;
            this.btnFolderProtector.Text = "Folder";
            this.btnFolderProtector.UseVisualStyleBackColor = true;
            this.btnFolderProtector.Click += new System.EventHandler(this.btnFolderProtector_Click);
            // 
            // btnLock
            // 
            this.btnLock.ForeColor = System.Drawing.Color.Black;
            this.btnLock.Location = new System.Drawing.Point(160, 140);
            this.btnLock.Name = "btnLock";
            this.btnLock.Size = new System.Drawing.Size(68, 27);
            this.btnLock.TabIndex = 9;
            this.btnLock.Text = "Lock";
            this.btnLock.UseVisualStyleBackColor = true;
            this.btnLock.Click += new System.EventHandler(this.btnLock_Click);
            // 
            // txtP1
            // 
            this.txtP1.Location = new System.Drawing.Point(160, 88);
            this.txtP1.Name = "txtP1";
            this.txtP1.PasswordChar = 'X';
            this.txtP1.Size = new System.Drawing.Size(148, 20);
            this.txtP1.TabIndex = 4;
            // 
            // txtFoldePath
            // 
            this.txtFoldePath.Enabled = false;
            this.txtFoldePath.Location = new System.Drawing.Point(160, 62);
            this.txtFoldePath.Name = "txtFoldePath";
            this.txtFoldePath.Size = new System.Drawing.Size(148, 20);
            this.txtFoldePath.TabIndex = 3;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(6, 88);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(94, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Password";
            // 
            // lblGhostCoderSA
            // 
            this.lblGhostCoderSA.Font = new System.Drawing.Font("Times New Roman", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGhostCoderSA.ForeColor = System.Drawing.Color.DarkGreen;
            this.lblGhostCoderSA.Location = new System.Drawing.Point(10, 16);
            this.lblGhostCoderSA.Name = "lblGhostCoderSA";
            this.lblGhostCoderSA.Size = new System.Drawing.Size(298, 29);
            this.lblGhostCoderSA.TabIndex = 0;
            this.lblGhostCoderSA.Text = "GHOST CODER SA";
            this.lblGhostCoderSA.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtAdminPassword
            // 
            this.txtAdminPassword.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAdminPassword.Location = new System.Drawing.Point(20, 75);
            this.txtAdminPassword.Name = "txtAdminPassword";
            this.txtAdminPassword.PasswordChar = '*';
            this.txtAdminPassword.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAdminPassword.Size = new System.Drawing.Size(288, 20);
            this.txtAdminPassword.TabIndex = 5;
            this.txtAdminPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAdminPassword.WordWrap = false;
            this.txtAdminPassword.TextChanged += new System.EventHandler(this.txtAdminPassword_TextChanged);
            // 
            // GDE
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Black;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(320, 175);
            this.ControlBox = false;
            this.Controls.Add(this.txtAdminPassword);
            this.Controls.Add(this.adminPanel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "GDE";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TopMost = true;
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.GDE_KeyDown);
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openEbooks;
        private System.Windows.Forms.Button btnLock;
        private System.Windows.Forms.TextBox txtP1;
        private System.Windows.Forms.TextBox txtFoldePath;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label lblGhostCoderSA;
        private System.Windows.Forms.TextBox txtP2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFolderProtector;
        private System.Windows.Forms.Button btnUnlock;
        private System.Windows.Forms.FolderBrowserDialog openFolder;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox txtAdminPassword;
        private System.Windows.Forms.GroupBox adminPanel;
    }
}

