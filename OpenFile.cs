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
    public partial class OpenFile : Form
    {
        public OpenFile()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        public string fileToExecute = "";//this will hold the file

        public static string drive = "";
        public static string  subFolder ="";


        public static string signal = "";

        void reader()
        {
            if (subFolder.ToString()!="" && signal !="")
            {
                drive =@lblDrive.Text.ToString()+ subFolder + @"\";
            }
            
            try
            {
                accessControl();//calling method to unlock folder.
                dataGridView1.AllowUserToAddRows = false;
                dataGridView1.RowHeadersVisible = false;

                DataGridViewImageColumn colIcon = new DataGridViewImageColumn();
                colIcon.Name = "colIcon";
                colIcon.HeaderText = "";
                colIcon.ImageLayout = DataGridViewImageCellLayout.Zoom;
                colIcon.DefaultCellStyle.SelectionBackColor = Color.White;
                colIcon.Width = 30;
                //colIcon.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                dataGridView1.Columns.Add(colIcon);

                DataGridViewColumn colHold = new DataGridViewTextBoxColumn();
                colHold.Name = "colFileName";
                colHold.HeaderText = "";
                colHold.DefaultCellStyle.Alignment = DataGridViewContentAlignment.TopLeft;
                colHold.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                colHold.Width = 80;
                dataGridView1.Columns.Add(colHold);

                dataGridView1.RowTemplate.Height = 26;
                string strDirLocal = drive;


                int nRow = 0;
                string sFileName = "";
                decimal nFileSize = 0;
                string sExt = "";
                string sDateModified = "";

                if (System.IO.Directory.Exists(strDirLocal))
                {
                    foreach (string sPath in System.IO.Directory.GetFiles(strDirLocal, "*.*"))
                    {
                        Icon FileIcon = SystemIcons.WinLogo;
                        FileIcon = Icon.ExtractAssociatedIcon(sPath);

                        dataGridView1.Rows.Add();
                        nRow = dataGridView1.Rows.Count - 1;
                        sFileName = sPath;
                        sDateModified = System.IO.File.GetLastWriteTime(sPath).ToString();

                        nFileSize = System.IO.File.ReadAllBytes(sPath).Length;
                        nFileSize = nFileSize / 1024;
                        nFileSize = System.Math.Round(nFileSize);
                        if (nFileSize < 1)
                        {
                            nFileSize = 1;
                        }
                        if (System.IO.File.ReadAllBytes(sPath).Length == 0)
                        {
                            nFileSize = 0;
                        }
                        string[] sExtHold = sPath.Split('.');
                        sExt = sExtHold[sExtHold.Count() - 1];

                        dataGridView1.Rows[nRow].Cells[0].Value = FileIcon;
                        dataGridView1.Rows[nRow].Cells[1].Value = sFileName;
                    }

                    if (signal!="active")
                    {
                        List<string> subFolders = new List<string>(Directory.EnumerateDirectories(strDirLocal));

                        foreach (var folder in subFolders)
                        {
                            //  Console.WriteLine("{0}", folder.Substring(folder.LastIndexOf("\\") + 1));
                            cbxSubFolders.Items.Add(folder.Substring(folder.LastIndexOf(@"\")));
                        }
                    }

                    
                    
                }
            }
            catch (Exception ad)
            {
                MessageBox.Show(ad.InnerException.ToString());
            }
        }
        private void OpenFile_Load(object sender, EventArgs e)
        {
            try
            {
                 reader();
            }
            catch(Exception ad)
            {
                MessageBox.Show(ad.ToString());
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            try
            {
                accessLocker();//calling method to lock folder
            }
            catch(Exception )
                {

                }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                fileToExecute=Convert.ToString(dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString());
            }
            catch (Exception)
            {
                
            }
        }

        private void btnOpen_Click(object sender, EventArgs e)
        {
            try
            {
                GDE zero = new GDE();//here we are creating an object of class GDE
                zero.TopMost = false;
                System.Diagnostics.Process.Start(@"" + fileToExecute.ToString() + "");
                this.TopMost = false;
                this.Visible = false;

               // accessLocker();//calling method to lock folder
            }
            catch (Exception)
            {
            
            }
       }


        void accessControl()//unlocking the file
        {
            string admin = Environment.UserName;

            DirectorySecurity ds = Directory.GetAccessControl(@"C:\ebooks");

            FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.ReadData, AccessControlType.Deny);

            ds.RemoveAccessRule(fs);
            Directory.SetAccessControl(@"C:\ebooks", ds);
        }

        void accessLocker()//locking the file
        {
            string admin = Environment.UserName;


            DirectorySecurity ds = Directory.GetAccessControl(@"C:\ebooks");

            FileSystemAccessRule fs = new FileSystemAccessRule(admin, FileSystemRights.ReadData, AccessControlType.Deny);

            FileSystemAccessRule testing = new FileSystemAccessRule(admin, FileSystemRights.Delete, AccessControlType.Deny);


            ds.AddAccessRule(fs);
            ds.AddAccessRule(testing);

            Directory.SetAccessControl(@"C:\ebooks", ds);

        }

        private void cbxSubFolders_SelectedIndexChanged(object sender, EventArgs e)
        {
            signal = "active";
           

            dataGridView1.Rows.Clear();
            dataGridView1.Refresh();

            subFolder = cbxSubFolders.SelectedItem.ToString().Substring(1);

            reader();
        }
    }
}
