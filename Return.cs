
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using LoginForm.BOL;
using LoginForm.BLL;

namespace BOL
{
    public partial class Return : Form
    {
        private BusinessLogic businessLogic;
        public Return()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void txtretun_carid_KeyPress(object sender, KeyPressEventArgs e)
        {
            string carId = txtretun_carid.Text;
            if (e.KeyChar == 13)
            {
                if (!string.IsNullOrEmpty(carId))
                {
                    RentalInfo rentalInfo = businessLogic.GetRentalInfo(carId);
                    if (rentalInfo != null)
                    {
                        txtretun_Custid.Text = rentalInfo.CustomerId;
                        txtretun_date.Text = rentalInfo.DueDate;
                        txtretun_days.Text = rentalInfo.ElapsedDays;
                        txtretun_fine.Text = rentalInfo.Fine;
                    }
                    else
                    {
                        MessageBox.Show("No rental information found for the provided Car ID.");
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Car ID.");
                }
            }
        }

        private void Return_Load(object sender, EventArgs e)
        {
            LoadCarIdsIntoComboBox();
        }

        private void txtretun_Custid_TextChanged(object sender, EventArgs e)
        {

        }
        private void LoadCarIdsIntoComboBox()
        {
            try
            {
                DataTable customerData = businessLogic.GetReturnTable();
                dataGridView1.DataSource = customerData;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred while loading customer data: {ex.Message}");
            }
        }
        private void RentInset_btn_Click(object sender, EventArgs e)
        {
            RentalInfo ri = new RentalInfo
            {
                CustomerId = txtretun_Custid.Text,
                CarID = txtretun_carid.Text,
                DueDate = txtretun_date.Text,
                ElapsedDays = txtretun_days.Text,
                Fine = txtretun_fine.Text,
            };
            businessLogic.InsertReturn(ri.CarID,ri.CustomerId,ri.DueDate,ri.ElapsedDays,ri.Fine);
            MessageBox.Show("Data Has Been Added");
            LoadCarIdsIntoComboBox();
        }

        private void ext_btn_Click(object sender, EventArgs e)
        {
            Application.Exit();
            
        }
    }
}
