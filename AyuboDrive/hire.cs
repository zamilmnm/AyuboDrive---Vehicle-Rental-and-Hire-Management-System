using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AyuboDrive
{
    public partial class hire : Form
    {
        hireClass hireClassObj = new hireClass();
        hirePackagesClass hirepack = new hirePackagesClass();
        vehicleCatogeryClass vehicCatogID = new vehicleCatogeryClass();
        driverClass driverID = new driverClass();
        customerClass custID = new customerClass();

        public hire()
        {
            InitializeComponent();
        }

        private void hire_Load(object sender, EventArgs e)
        {
            hirepack.loadlistInComboBox(hirePackIDcomboBox);
            vehicCatogID.loadlistInComboBox(vehicCatogIDcomboBox);
            driverID.loadlistInComboBox(driverIDcomboBox);
            custID.loadlistInComboBox(custIDcomboBox);

            hireClassObj.view(hiredataGridView);
        }

        private void hirePackIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClassObj.hirepackID = Convert.ToInt32(hirePackIDcomboBox.SelectedValue.ToString());
        }

        private void vehicRegNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void driverIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClassObj.driverID = Convert.ToInt32(driverIDcomboBox.SelectedValue.ToString());
        }

        

        private void hireWaitingChgBox_TextChanged(object sender, EventArgs e)
        {
        
        }

        private void hireWaitingchgExtrahrsBox_TextChanged(object sender, EventArgs e)
        {
            hireClassObj.hireWaitingChgExtHrs = Convert.ToInt32(hireWaitingchgExtrahrsBox.Text);
        }

        private void hireStartdateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //hireClassObj.hireStartDateTime = DateTime.ParseExact(hireStartdateTimePicker.Text, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            hireClassObj.hireStartDateTime = Convert.ToString(hireStartdateTimePicker.Text);
        }

        private void hireEnddateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            //hireClassObj.hireEndDateTime = DateTime.ParseExact(hireEnddateTimePicker.Text, "MM/dd/yyyy HH:mm:ss", CultureInfo.InvariantCulture);
            hireClassObj.hireEndDateTime = Convert.ToString(hireEnddateTimePicker.Text);
        }

        private void custIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClassObj.CustID = Convert.ToInt32(custIDcomboBox.SelectedValue.ToString());
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            hireClassObj.save();
            hireClassObj.view(hiredataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            hireClassObj.update();
            hireClassObj.view(hiredataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            hireClassObj.delete();
            hireClassObj.view(hiredataGridView);
        }

        private void hiredataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void hiredataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            hireClassObj.id = Convert.ToInt32(hiredataGridView.Rows[index].Cells[0].Value.ToString());
            hireClassObj.hirepackID = Convert.ToInt32(hiredataGridView.Rows[index].Cells[1].Value.ToString());
            hireClassObj.vehicCatogID = Convert.ToInt32(hiredataGridView.Rows[index].Cells[3].Value.ToString());
            hireClassObj.CustID = Convert.ToInt32(hiredataGridView.Rows[index].Cells[5].Value.ToString());
            hireClassObj.driverID = Convert.ToInt32(hiredataGridView.Rows[index].Cells[7].Value.ToString());
            hireClassObj.hireExtrKmChg = Convert.ToInt32(hiredataGridView.Rows[index].Cells[9].Value.ToString());
            hireClassObj.hireWaitingChgExtHrs = Convert.ToInt32(hiredataGridView.Rows[index].Cells[10].Value.ToString());
            hireClassObj.hireStartDateTime =Convert.ToString (hiredataGridView.Rows[index].Cells[11].Value.ToString());
            hireClassObj.hireEndDateTime =Convert.ToString (hiredataGridView.Rows[index].Cells[12].Value.ToString());
            hireClassObj.hireStartOdo = Convert.ToInt32(hiredataGridView.Rows[index].Cells[13].Value.ToString());
            


            hirePackIDcomboBox.Text = Convert.ToString(hireClassObj.hirepackID);
            vehicCatogIDcomboBox.Text = Convert.ToString(hireClassObj.vehicCatogID);
            driverIDcomboBox.Text = Convert.ToString(hireClassObj.driverID);
            hireExtraKmChgBox.Text = Convert.ToString(hireClassObj.hireExtrKmChg);
            hireWaitingchgExtrahrsBox.Text = Convert.ToString(hireClassObj.hireWaitingChgExtHrs);
            hireStartdateTimePicker.Text = Convert.ToString(hireClassObj.hireStartDateTime);
            hireEnddateTimePicker.Text = Convert.ToString(hireClassObj.hireEndDateTime);
            hireStartOdoMeterBox.Text = Convert.ToString(hireClassObj.hireStartOdo);
            custIDcomboBox.Text = Convert.ToString(hireClassObj.CustID);

        }

        private void hireDaysBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void searchBox_TextChanged_1(object sender, EventArgs e)
        {
            hireClassObj.searchID = searchBox.Text;
            hireClassObj.search(hiredataGridView);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            hireExtraKmChgBox.Text = "0";
            hireWaitingchgExtrahrsBox.Text = "0";
            hireStartOdoMeterBox.Text= "0";
        }

        private void vehicCatogIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hireClassObj.vehicCatogID = Convert.ToInt32(vehicCatogIDcomboBox.SelectedValue.ToString());
        }

        private void hireStartOdoMeterBox_TextChanged(object sender, EventArgs e)
        {
            hireClassObj.hireStartOdo = Convert.ToInt32(hireStartOdoMeterBox.Text);
        }

        private void hireExtraKmChgBox_TextChanged(object sender, EventArgs e)
        {
            hireClassObj.hireExtrKmChg = Convert.ToInt32(hireExtraKmChgBox.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
