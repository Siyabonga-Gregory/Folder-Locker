using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Security.AccessControl;
using System.IO;
using System.Diagnostics;
namespace GDE
{
    public partial class GDE : Form
    {
        public GDE()
        {
            InitializeComponent();
        }

        private void btnFolderProtector_Click(object sender, EventArgs e)
        {
            try
            {
                openFolder.ShowDialog();

                txtFoldePath.Text = openFolder.SelectedPath;
            }
            catch (Exception error)
            {
                MessageBox.Show(error.ToString());
            }
        }

        private void btnLock_Click(object sender, EventArgs e)
        {
            if (txtFoldePath.Text.ToString() != "")
            {
                if (txtP1.Text.ToString() == "gregory@ghostcoder.sa" && txtP2.Text.ToString() == "gregory@ghostcoder.sa")
                {

                    string admin = Environment.UserName;

                    DirectorySecurity ds = Directory.GetAccessControl(txtFoldePath.Text.ToString());

                    FileSystemAccessRule readingDataRule = new FileSystemAccessRule(admin, FileSystemRights.ReadData, AccessControlType.Deny);
                    FileSystemAccessRule changingPermissionRule = new FileSystemAccessRule(admin, FileSystemRights.ChangePermissions, AccessControlType.Deny);
                    FileSystemAccessRule takeOwnership = new FileSystemAccessRule(admin, FileSystemRights.TakeOwnership, AccessControlType.Deny);
                    FileSystemAccessRule readPermissions = new FileSystemAccessRule(admin, FileSystemRights.ReadPermissions, AccessControlType.Deny);

                    FileSystemAccessRule deleteRule = new FileSystemAccessRule(admin, FileSystemRights.Delete, AccessControlType.Deny);
                    FileSystemAccessRule readAttributes = new FileSystemAccessRule(admin, FileSystemRights.ReadAttributes, AccessControlType.Deny);


                    ds.AddAccessRule(readingDataRule);
                    ds.AddAccessRule(changingPermissionRule);
                    ds.AddAccessRule(deleteRule);
                    ds.AddAccessRule(readAttributes);
                    ds.AddAccessRule(takeOwnership);
                    ds.AddAccessRule(readPermissions);

                    Directory.SetAccessControl(txtFoldePath.Text.ToString(), ds);

                    MessageBox.Show("Folder has been successfully locked", "", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    txtFoldePath.Text = "";
                    txtP1.Clear();
                    txtP2.Clear();

                }
                else
                {
                    MessageBox.Show("Entered password is invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose a folder", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnUnlock_Click(object sender, EventArgs e)
        {

            if (txtFoldePath.Text.ToString() != "")
            {
                if (txtP1.Text.ToString() == "gregory@ghostcoder.sa" && txtP2.Text.ToString() == "gregory@ghostcoder.sa")
                {

                    string admin = Environment.UserName;

                    DirectorySecurity ds = Directory.GetAccessControl(txtFoldePath.Text.ToString());

                    FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.FullControl, AccessControlType.Deny);

                    ds.RemoveAccessRule(fs);
                    Directory.SetAccessControl(txtFoldePath.Text.ToString(), ds);

                    MessageBox.Show("Folder has been successfully unlocked", "", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    txtFoldePath.Text = "";
                    txtP1.Clear();
                    txtP2.Clear();
                }
                else
                {
                    MessageBox.Show("Entered password is invalid", "", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Please choose a folder", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void GDE_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.Control && e.Shift && e.KeyCode == Keys.T)//showing admin panel 
            {
                adminPanel.Visible = true;
                txtAdminPassword.Visible = false;
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.K)//minimizing the application
            {
                 this.WindowState = FormWindowState.Minimized;
                txtAdminPassword.Visible =true;
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.G)//hiding admin panel
            {
                txtFoldePath.Text = "";
                txtP1.Clear();
                txtP2.Clear();
                adminPanel.Visible = false;
                txtAdminPassword.Visible = true;
            }
            else if (e.Control && e.Shift && e.KeyCode == Keys.H)//Exit application
            {
                Application.Exit();
            }
        }

        void accessControl(string folder)//unlocking the file
        {
            string admin = Environment.UserName;

            DirectorySecurity ds = Directory.GetAccessControl(folder.ToString());

            FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.ReadData, AccessControlType.Deny);

            ds.RemoveAccessRule(fs);
            Directory.SetAccessControl(folder.ToString(), ds);
        }

        void accessLocker(string folder)//locking the file
        {
            string admin = Environment.UserName;
       

            DirectorySecurity ds = Directory.GetAccessControl(folder.ToString());

            FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.ReadData, AccessControlType.Deny);

            FileSystemAccessRule testing = new FileSystemAccessRule(admin, FileSystemRights.Delete, AccessControlType.Deny);


            ds.AddAccessRule(fs);
            ds.AddAccessRule(testing);

            Directory.SetAccessControl(folder.ToString(), ds);

        }

        void accessSelectedFile(string filePath)
        {
            string admin = Environment.UserName;
        }

        private void txtAdminPassword_TextChanged(object sender, EventArgs e)
        {
            if (txtAdminPassword.Text.ToString().Equals("gregory@ghostcoder.sa"))
            {
                adminPanel.Visible = true;
                txtAdminPassword.Visible = false;
                KeyPreview = true;
            }
        }
    }
}
