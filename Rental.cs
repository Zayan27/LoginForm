using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.BLL;
using LoginForm.BOL;

namespace OOADproject_CarRental
{
    public partial class Rental : Form
    {
        private BusinessLogic businessLogic;
        
        public Rental()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            LoadCarIdsIntoComboBox();
            LoadCustomerData();
        }
        private void LoadCarIdsIntoComboBox()
        {
            DataTable carIds = businessLogic.GetCarIds();

            if (carIds != null && carIds.Rows.Count > 0)
            {
                foreach (DataRow row in carIds.Rows)
                {
                    string carId = row["regno"].ToString();
                    txtCarid.Items.Add(carId);
                }
            }
        }

        private void txtCarid_SelectedIndexChanged(object sender, EventArgs e)
        {
            DisplayCarAvailability();

        }
        private void DisplayCarAvailability()
        {

            string selectedCarId = txtCarid.SelectedItem?.ToString(); 

            if (!string.IsNullOrEmpty(selectedCarId) )
            {
                string availability = businessLogic.GetAvailable(selectedCarId); 
                label9.Text = availability;

                if (availability == "NO")
                {
                    txtCustid.Enabled = false;
                    txtCustname.Enabled = false;
                    txtDuedate.Enabled = false;
                    txtIssuedate.Enabled = false;
                    txtRfee.Enabled = false;
                }

            }
            else
            {
                label9.Text = "";
            }
            
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void txtCustid_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtCustid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string cusid = txtCustid.Text;
            if(e.KeyChar == 13)
            {
                if(!string.IsNullOrEmpty(cusid))
                {
                    string names = businessLogic.GetCarCusId(cusid);
                    txtCustname.Text = names;
                }
                else
                {
                    MessageBox.Show("There is no Value");
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                string custId = txtCustid.Text;
                string carId = txtCarid.SelectedItem?.ToString();
                string custName = txtCustname.Text;
                string rentalFee = txtRfee.Text;
                string issueDate = txtIssuedate.Value.Date.ToString("yyyy-MM-dd");
                string dueDate = txtDuedate.Value.Date.ToString("yyyy-MM-dd");
               

                if (string.IsNullOrEmpty(custId) || string.IsNullOrEmpty(carId))
                {
                    MessageBox.Show("Please fill in all fields.");
                    return;
                }

                // Check if the selected car is available
                string availability = businessLogic.GetAvailable(carId);
                if (availability == "NO")
                {
                    MessageBox.Show("The selected car is not available for rental.");
                    return;
                }

                businessLogic.InsertRental(carId, custId, custName, rentalFee, issueDate, dueDate);
                MessageBox.Show("Rental record inserted successfully.");
                LoadCustomerData();
            }
            catch (FormatException)
            {
                MessageBox.Show("Invalid input format. Please enter valid values.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred: " + ex.Message);
            }
        }
        private void LoadCustomerData()
        {
            try
            {
                DataTable customerData = businessLogic.GetRentalCustomers();
                dataGridView1.DataSource = customerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}");
            }
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            this.Hide();
            MainMenu mm = new MainMenu();   
            mm.ShowDialog();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
