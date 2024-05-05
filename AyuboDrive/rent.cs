using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    
    public partial class rent : Form
    {
        rentClass rentClassObj = new rentClass();

        vehicleClass vehicID = new vehicleClass();
        driverClass DriverID = new driverClass();
        customerClass custID = new customerClass();
        public rent()
        {
            InitializeComponent();
        }

        private void rent_Load(object sender, EventArgs e)
        {
            rentClassObj.view(rentdataGridView);

            vehicID.loadlistInComboBox(vehicIDcomboBox);
            DriverID.loadlistInComboBox(driverIDcomboBox);
            custID.loadlistInComboBox(custIDcomboBox);


        }

        private void vehicRegNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void driverIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentClassObj.driverID = Convert.ToInt32(driverIDcomboBox.SelectedValue.ToString());
        }

        private void rentstartBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void rentStartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            rentClassObj.rentStartDate = Convert.ToString(rentStartdateTimePicker.Text);
        }

        private void rentEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            rentClassObj.rentEndDate = Convert.ToString(rentEnddateTimePicker.Text);
        }

        private void rentDaysBox_TextChanged(object sender, EventArgs e)
        {
            rentClassObj.rentDays = Convert.ToInt32(rentDaysBox.Text);
        }

        private void startOdometerBox_TextChanged(object sender, EventArgs e)
        {
            rentClassObj.startOdometer = Convert.ToInt32(startOdometerBox.Text);
        }

        private void endOdometerBox_TextChanged(object sender, EventArgs e)
        {
            rentClassObj.endOdometer = Convert.ToInt32(endOdometerBox.Text);

            // TO calculate the total Odometer for rent
            double startOdo = Convert.ToDouble(startOdometerBox.Text);
            double endOdo = Convert.ToDouble(endOdometerBox.Text);
            totalOdometerBox.Text = Convert.ToString(endOdo - startOdo);
        }

        private void totalOdometerBox_TextChanged(object sender, EventArgs e)
        {
            rentClassObj.totalOdometerForRent = Convert.ToInt32(totalOdometerBox.Text);    
        }

        private void custIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            rentClassObj.CustID = Convert.ToInt32(custIDcomboBox.SelectedValue.ToString());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            rentClassObj.save();
            rentClassObj.view(rentdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            rentClassObj.update();
            rentClassObj.view(rentdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            rentClassObj.delete();
            rentClassObj.view(rentdataGridView);
        }

        private void rentdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void rentdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            rentClassObj.id = Convert.ToInt32(rentdataGridView.Rows[index].Cells[0].Value.ToString());
            rentClassObj.vehicID = Convert.ToInt32(rentdataGridView.Rows[index].Cells[1].Value.ToString());
            rentClassObj.CustID = Convert.ToInt32(rentdataGridView.Rows[index].Cells[3].Value.ToString());
            rentClassObj.driverID = Convert.ToInt32(rentdataGridView.Rows[index].Cells[5].Value.ToString());
            rentClassObj.rentStartDate = rentdataGridView.Rows[index].Cells[7].Value.ToString();
            rentClassObj.rentEndDate = rentdataGridView.Rows[index].Cells[8].Value.ToString();
            rentClassObj.rentDays = Convert.ToInt32(rentdataGridView.Rows[index].Cells[9].Value.ToString());
            rentClassObj.startOdometer = Convert.ToInt32(rentdataGridView.Rows[index].Cells[10].Value.ToString());
            rentClassObj.endOdometer = Convert.ToInt32(rentdataGridView.Rows[index].Cells[11].Value.ToString());
            rentClassObj.totalOdometerForRent = Convert.ToInt32(rentdataGridView.Rows[index].Cells[12].Value.ToString());
            

            vehicIDcomboBox.Text = Convert.ToString(rentClassObj.vehicID);
            custIDcomboBox.Text = Convert.ToString(rentClassObj.CustID);
            driverIDcomboBox.Text = Convert.ToString(rentClassObj.driverID);
            rentStartdateTimePicker.Text = Convert.ToString(rentClassObj.rentStartDate);
            rentEnddateTimePicker.Text = Convert.ToString(rentClassObj.rentEndDate);
            rentDaysBox.Text = Convert.ToString(rentClassObj.rentDays);
            startOdometerBox.Text = Convert.ToString(rentClassObj.startOdometer);
            endOdometerBox.Text = Convert.ToString(rentClassObj.endOdometer);
            totalOdometerBox.Text = Convert.ToString(rentClassObj.totalOdometerForRent);
            

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            rentClassObj.searchID = searchBox.Text;
            rentClassObj.search(rentdataGridView);
        }

        

        private void vehicIDcomboBox_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            rentClassObj.vehicID = Convert.ToInt32(vehicIDcomboBox.SelectedValue.ToString());
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicIDcomboBox.Text = "0";
            custIDcomboBox.Text = "0";
            driverIDcomboBox.Text = "0";
            rentDaysBox.Text = "0";
            startOdometerBox.Text = "0";
            endOdometerBox.Text = "0";
            totalOdometerBox.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
        
    }   

}
