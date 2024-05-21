using System;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using LoginForm.BLL;
using LoginForm.BOL;

namespace OOADproject_CarRental
{
    public partial class CarReg : Form
    {
        private BusinessLogic businessLogic;
        public CarReg()
        {
            InitializeComponent();
            businessLogic = new BusinessLogic();
        }

        private void CarReg_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            BusinessLogic obj = new BusinessLogic();
            CarReg_ car = new CarReg_
            {
                RegNo = txtReg.Text,
                Make = txtMake.Text,
                Model = txtModel.Text,
                Available = txtAvail.Text,
            };
            obj.InsertCar(car.RegNo, car.Make, car.Model, car.Available);
            carDataGrid.DataSource = obj.SelectCar();
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BusinessLogic obj = new BusinessLogic();
            CarReg_ car = new CarReg_
            {
                RegNo = txtReg.Text,
                Make = txtMake.Text,
                Model = txtModel.Text,
                Available = txtAvail.Text,
            };
            businessLogic.UpdateCar(car.RegNo, car.Make, car.Model, car.Available);
            carDataGrid.DataSource = businessLogic.SelectCar();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BusinessLogic obj = new BusinessLogic();
            CarReg_ car = new CarReg_
            {
                RegNo = txtReg.Text,
                
            };
            businessLogic.DeleteCar(car.RegNo);
            carDataGrid.DataSource = businessLogic.SelectCar();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            carDataGrid.DataSource = businessLogic.SelectCar();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MainMenu mm = new MainMenu();
            this.Hide();
            mm.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
