using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Permissions;
using Microsoft.Win32;
using System.Windows.Forms;

namespace GDE
{
    public static class WindowsKey
    {
        public static void Disable()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.LocalMachine.CreateSubKey(@"System\CurrentControlSet\Control\Keyboard Layout");
                byte[] binary = new byte[] { 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x03, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x5B, 
                    0xE0, 
                    0x00, 
                    0x00, 
                    0x5C, 
                    0xE0, 
                    0x00, 
                    0x00, 
                    0x00, 
                    0x00 
                };
                key.SetValue("Scancode Map", binary, RegistryValueKind.Binary);
            }
            catch (System.Exception)
            {
                //Debug.Assert(false, ex.ToString());
            }
            finally
            {
               // key.Close();
            }
        }//Method to disable the windows button from user keyboard may need a user to logoff and or restart the machine for changes to take place

    
        public static void Enable()
        {
            RegistryKey key = null;
            try
            {
                key = Registry.LocalMachine.OpenSubKey(@"System\CurrentControlSet\Control\Keyboard Layout", true);
                key.DeleteValue("Scancode Map", true);
            }
            catch (System.Exception)
            {
               // MessageBox.Show("","GDE",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                //Debug.Assert(false, ex.ToString());
            }
            finally
            {
               // key.Close();
            }
        }//Method to enable the windows button from user keyboard may need a user to logoff and or restart the machine for changes to take place

        public static void deleteRegistry()//Method to delete application from registry, preventing it from  being uninstall from control panel
        {
            try
            {
                RegistryKey key = null;
                key = Registry.LocalMachine.OpenSubKey(@"SOFTWARE\Wow6432Node\Microsoft\Windows\CurrentVersion\Uninstall\{63EF3DE1-F37C-4B1B-BBBD-26910690C7CF}", true);


                key.DeleteValue("ModifyPath", true);
                key.DeleteValue("UnInstallString", true);
                key.DeleteValue("Version", true);
                key.DeleteValue("VersionMajor", true);
                key.DeleteValue("VersionMinor", true);
                key.DeleteValue("WindowsInstaller", true);

                key.Close();
                
            }
            catch (Exception)
            {

            }
        }
    }
}
