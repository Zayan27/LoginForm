using LoginForm.BLL;
using System;
using System.Windows.Forms;
using LoginForm.BOL;

namespace OOADproject_CarRental
{
    public partial class Form1 : Form
    {
        private bool hasRunBefore = false;
        private BusinessLogic businessLogic;
        public Form1()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            UserCredentials credentials = new UserCredentials
            {
                ServerIp = businessLogic.ReadFromRegistry("ServerIP"),
                DbName = businessLogic.ReadFromRegistry("DatabaseName"),
                Username = businessLogic.ReadFromRegistry("UserName"),
                UserPassword = businessLogic.ReadFromRegistry("UserPassword")
            };

            if (businessLogic.ConnectToDatabase(credentials.ServerIp, credentials.DbName, credentials.Username, credentials.UserPassword))
            {
                MessageBox.Show("Connected Successfully");
                this.Hide();
                MainMenu secondForm = new MainMenu();
                secondForm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Error While Connecting");
            }
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

        private void dlt_regbtn_Click(object sender, EventArgs e)
        {
            businessLogic.DeleteRegistryValue("ServerIP");
            businessLogic.DeleteRegistryValue("DatabaseName");
            businessLogic.DeleteRegistryValue("UserName");
            businessLogic.DeleteRegistryValue("UserPassword");
            MessageBox.Show("Registry has been cleared");
        }

        private void save_regbtn_Click(object sender, EventArgs e)
        {
            string serverIP = textbox_serverip.Text;
            string dbName = textbox_dbname.Text;
            string username = textbox_userid.Text;
            string userpassword = textbox_userpass.Text;

            bool registryEmpty = businessLogic.IsRegistryEmpty();

            if (registryEmpty || !hasRunBefore)
            {
                businessLogic.SaveToRegistry("ServerIP", serverIP);
                businessLogic.SaveToRegistry("DatabaseName", dbName);
                businessLogic.SaveToRegistry("UserName", username);
                businessLogic.SaveToRegistry("UserPassword", userpassword);
                hasRunBefore = true;
                MessageBox.Show("Data Has Been Added");
            }
            else
            {
                MessageBox.Show("Information already saved in the registry.");
            }
        }
    }
}
