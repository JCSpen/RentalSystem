using Microsoft.IdentityModel.Abstractions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RentalSystem
{
    public partial class MightyMotors : Form
    {
        public DataController Controller = new DataController();
        public User CurrentUser { get; set; }
        public MightyMotors(User CurrentUser)
        {
            this.CurrentUser = CurrentUser;
            InitializeComponent();
        }

        private void MightyMotors_Load(object sender, EventArgs e)
        {
            Controller.FillTable(TableView);
        }

        private void AdminSubmitBtn_Click(object sender, EventArgs e)
        {
            if (ClearanceKeyBox.Text.ToLower() == "admin")
            {
                if (MakeBox.Text == "" || ModelBox.Text == "" || RegBox.Text == "" || MileageBox.Text == "" || PriceBox.Text == "")
                {
                    MessageBox.Show("Please fill out all boxes before submitting");
                }
                else
                { 
                    Controller.CreateVehicle(MakeBox.Text, ModelBox.Text, RegBox.Text, int.Parse(MileageBox.Text), int.Parse(PriceBox.Text), GenerateID());
                }
            }
            else
            {
                MessageBox.Show("Clearance Key is Invalid!");
            }
        }

        public int GenerateID()
        {
            Random RNG = new Random();
            string Output = "";
            for(int i = 0; i < 6; i++)
            {
                Output = Output + RNG.Next(0, 9).ToString();
            }
            return int.Parse(Output);
        }

        private void RefreshBtn_Click(object sender, EventArgs e)
        {
            Controller.FillTable(TableView);
        }

        private void IDBtn_Click(object sender, EventArgs e)
        {
            string[] VehicleData = Controller.FetchVehicleData(int.Parse(VehicleIDBox.Text));
            CurrentUser.SetVehicleData(VehicleData);
        }
    }
}
