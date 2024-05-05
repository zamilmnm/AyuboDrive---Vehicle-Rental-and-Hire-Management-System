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
    public partial class vehicle : Form
    {
        vehicleClass vehicleClassObj = new vehicleClass();
        vehicleCatogeryClass vehicname = new vehicleCatogeryClass();
        public vehicle()
        {
            InitializeComponent();
        }

        private void vehicle_Load(object sender, EventArgs e)
        {
            vehicleClassObj.view(vehiclesdataGridView);

            vehicname.loadlistInComboBox(vehicomboBox);

        }

        private void vehicomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            vehicleClassObj.vehicCatogID = Convert.ToInt32(vehicomboBox.SelectedValue.ToString());
            
        }

        private void vehicNameBox_TextChanged(object sender, EventArgs e)
        {
            vehicleClassObj.name = vehicNameBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            vehicleClassObj.save();
            vehicleClassObj.view(vehiclesdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            vehicleClassObj.update();
            vehicleClassObj.view(vehiclesdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            vehicleClassObj.delete();
            vehicleClassObj.view(vehiclesdataGridView);
        }

        private void vehiclesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void vehiclesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            vehicleClassObj.vehicID = Convert.ToInt32(vehiclesdataGridView.Rows[index].Cells[0].Value.ToString());
            vehicleClassObj.regNO = vehiclesdataGridView.Rows[index].Cells[1].Value.ToString();
            vehicleClassObj.vehicCatogID = Convert.ToInt32(vehiclesdataGridView.Rows[index].Cells[2].Value.ToString());
            vehicleClassObj.name = vehiclesdataGridView.Rows[index].Cells[4].Value.ToString();

            vehicRegNoBox.Text = Convert.ToString(vehicleClassObj.regNO);
            vehicomboBox.Text = Convert.ToString(vehicleClassObj.vehicCatogID);
            vehicNameBox.Text = Convert.ToString(vehicleClassObj.name);


        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            vehicleClassObj.searchID = searchBox.Text;
            vehicleClassObj.search(vehiclesdataGridView);
        }

        private void vehicRegNoBox_TextChanged(object sender, EventArgs e)
        {
            vehicleClassObj.regNO =  vehicRegNoBox.Text;
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicRegNoBox.Clear();
            vehicNameBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
