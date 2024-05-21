using BOL;
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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            CarReg carReg = new CarReg();
            this.Hide();
            carReg.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Return re = new Return();
            this.Hide();
            re.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Rental rental = new Rental();
            this.Hide();
            rental.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Customer customer = new Customer();
            this.Hide();
            customer.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
