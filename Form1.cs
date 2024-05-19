using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.Win32;
using System.Diagnostics;

namespace LoginForm
{
    public partial class Form1 : Form
    {
        private bool hasRunBefore = false;
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            
            string R_server_ip = ReadRegistry("ServerIP");
            string R_db_Name = ReadRegistry("DatabaseName");
            string R_username = ReadRegistry("UserName");
            string R_userpassword = ReadRegistry("UserPassword");

            string connection = $"Data Source={R_server_ip},49170;Initial Catalog={R_db_Name};User ID={R_username};Password={R_userpassword};";

            try
            {
                SqlConnection sqlconnect = new SqlConnection(connection);
                sqlconnect.Open();
                MessageBox.Show("Connected Successfully");
                
                this.Hide();

                Menu secondForm = new Menu();
                secondForm.ShowDialog();
                
               
               
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error While Connecting {ex.Message}");
            }
           

        }

        private bool CheckRunBeforeFlag()
        {
            using (RegistryKey key = Registry.CurrentUser.OpenSubKey("Software\\OOAD"))
            {
                if (key != null)
                {
                    object value = key.GetValue("HasRunBefore");
                    if (value != null && value.ToString() == "1")
                    {
                        return true;
                    }
                }
            }
            return false;
        }

        private void SaveRunBeforeFlag()
        {
            using (RegistryKey key = Registry.CurrentUser.CreateSubKey("Software\\OOAD"))
            {
                key.SetValue("HasRunBefore", "1", RegistryValueKind.DWord);
            }
        }

        private void SaveToRegistry(string keyName, string value)
        {
            try
            {
                
                using (RegistryKey regKey = Registry.CurrentUser.CreateSubKey("Software\\OOAD\\ServerValues"))
                {
                    if (regKey != null)
                    {
                       
                        regKey.SetValue(keyName, value, RegistryValueKind.String);
                        MessageBox.Show("Value saved in the registry successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to access registry key.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }



        private string ReadRegistry(string keyName)
        {
            using (RegistryKey regkey = Registry.CurrentUser.OpenSubKey("Software\\OOAD\\ServerValues"))
            {
                if (regkey != null)
                {
                    object value = regkey.GetValue(keyName);
                    if (value != null)
                        return value.ToString();
                }
                return ""; 
            }
        }

        private void DeleteRegistryValue(string keyName)
        {
            try
            {
                // Open the registry key where the value is stored
                using (RegistryKey regKey = Registry.CurrentUser.OpenSubKey("Software\\OOAD\\ServerValues", true))
                {
                    if (regKey != null)
                    {
                        // Delete the specified value
                        regKey.DeleteValue(keyName, false); 
                        MessageBox.Show("Value deleted from the registry successfully!");
                    }
                    else
                    {
                        MessageBox.Show("Error: Unable to access registry key.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}");
            }
        }
        
        private bool IsRegistryEmpty()
        {
            string serverIP = ReadRegistry("ServerIP");
            string dbName = ReadRegistry("DatabaseName");
            string username = ReadRegistry("UserName");
            string userpassword = ReadRegistry("UserPassword");

            return string.IsNullOrEmpty(serverIP) || string.IsNullOrEmpty(dbName) ||
                   string.IsNullOrEmpty(username) || string.IsNullOrEmpty(userpassword);
        }



        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void clr_btn_Click(object sender, EventArgs e)
        {
            textbox_serverip.Clear();
            textbox_dbname.Clear();
            textbox_userid.Clear();
            textbox_userpass.Clear();

            textbox_serverip.Focus();
        }

        private void exit_btn_Click(object sender, EventArgs e)
        {
         
            Application.Exit();
        }

        private void textbox_serverip_TextChanged(object sender, EventArgs e)
        {

        }

        private void dlt_regbtn_Click(object sender, EventArgs e)
        {
            DeleteRegistryValue("ServerIP");
            DeleteRegistryValue("DatabaseName");
            DeleteRegistryValue("UserName");
            DeleteRegistryValue("UserPassword");

            MessageBox.Show("Registery has been cleared");
        }

        private void save_regbtn_Click(object sender, EventArgs e)
        {
            string serverIP = textbox_serverip.Text;
            string dbName = textbox_dbname.Text;
            string username = textbox_userid.Text;
            string userpassword = textbox_userpass.Text;

            bool registryEmpty = IsRegistryEmpty();

            if (registryEmpty || !CheckRunBeforeFlag())
            {
                SaveToRegistry("ServerIP", serverIP);
                SaveToRegistry("DatabaseName", dbName);
                SaveToRegistry("UserName", username);
                SaveToRegistry("UserPassword", userpassword);
                SaveRunBeforeFlag(); 

            }
            else
            {
                MessageBox.Show("Information already saved in the registry.");
            }
        }
    }
}
