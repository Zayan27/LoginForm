using LoginForm.BLL;
using LoginForm.BOL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OOADproject_CarRental
{
    public partial class Customer : Form
    {
        private BusinessLogic businessLogic;
        public Customer()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();

            string newCustomerId = businessLogic.C_AutoInc();
            txtcid.Text = newCustomerId;
        }

        private void Customer_Load(object sender, EventArgs e)
        {
            LoadCustomerData();
        }

        private void c_add_btn_Click(object sender, EventArgs e)
        {
            try
            {
                AutoNoid customer = new AutoNoid
                {
                    c_Id = txtcid.Text,
                    c_Name = txtc_name.Text,
                    c_address = txtc_add.Text,
                    c_mobile = txtc_mob.Text,
                };

                businessLogic.Cus_Insert(customer.c_Id, customer.c_Name, customer.c_address, customer.c_mobile);
                MessageBox.Show("Customer Data Inserted");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
                
            }
        }

        private void LoadCustomerData()
        {
            try
            {
                DataTable customerData = businessLogic.GetCustomers();
                dataGridView1.DataSource = customerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtcid.Text = row.Cells["CustomerID"].Value.ToString();
                txtc_name.Text = row.Cells["Customer Name"].Value.ToString();
                txtc_add.Text = row.Cells["Address"].Value.ToString();
                txtc_mob.Text = row.Cells["Mobile"].Value.ToString();
            }
        }

        private void c_updt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                AutoNoid customer = new AutoNoid
                {
                    c_Id = txtcid.Text,
                    c_Name = txtc_name.Text,
                    c_address = txtc_add.Text,
                    c_mobile = txtc_mob.Text,
                };

                businessLogic.Cus_Update(customer.c_Id, customer.c_Name, customer.c_address, customer.c_mobile);
                MessageBox.Show("Customer Data Updated");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void c_dlt_btn_Click(object sender, EventArgs e)
        {
            try
            {
                string customerId = txtcid.Text;

                businessLogic.Cus_Delete(customerId);
                MessageBox.Show("Customer Data Deleted");
                LoadCustomerData();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog(this);
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
