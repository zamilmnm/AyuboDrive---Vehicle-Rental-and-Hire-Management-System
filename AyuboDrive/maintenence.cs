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
    public partial class maintenence : Form
    {
        maintenenceClass maintenenceClassObj = new maintenenceClass();
        mechanicClass mechID = new mechanicClass();
        vehicleClass vehicID = new vehicleClass();
        public maintenence()
        {
            InitializeComponent();
        }

        private void maintenence_Load(object sender, EventArgs e)
        {
            maintenenceClassObj.view(maitenencedataGridView);
            mechID.loadlistInComboBox(mechIDcomboBox);
            vehicID.loadlistInComboBox(vehicIDcomboBox);
        }

        private void vehicRegNocomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void maintenenceTimePicker_ValueChanged(object sender, EventArgs e)
        {
            maintenenceClassObj.maintDate = maintenenceTimePicker.Text;
        }

        private void milageBox_TextChanged(object sender, EventArgs e)
        {
            maintenenceClassObj.milage = Convert.ToInt32(milageBox.Text);
        }

        private void mechIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maintenenceClassObj.mechID = Convert.ToInt32(mechIDcomboBox.SelectedValue.ToString());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            maintenenceClassObj.save();
            maintenenceClassObj.view(maitenencedataGridView);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            maintenenceClassObj.update();
            maintenenceClassObj.view(maitenencedataGridView);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            maintenenceClassObj.delete();
            maintenenceClassObj.view(maitenencedataGridView);
        }

        private void maitenencedataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void maitenencedataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            maintenenceClassObj.id = Convert.ToInt32(maitenencedataGridView.Rows[index].Cells[0].Value.ToString());
            maintenenceClassObj.vehicID = Convert.ToInt32(maitenencedataGridView.Rows[index].Cells[1].Value.ToString());
            maintenenceClassObj.maintDate = maitenencedataGridView.Rows[index].Cells[3].Value.ToString();
            maintenenceClassObj.mechID = Convert.ToInt32(maitenencedataGridView.Rows[index].Cells[4].Value.ToString());
            maintenenceClassObj.milage = Convert.ToInt32(maitenencedataGridView.Rows[index].Cells[6].Value.ToString());

            vehicIDcomboBox.Text = Convert.ToString(maintenenceClassObj.vehicID);
            maintenenceTimePicker.Text = Convert.ToString(maintenenceClassObj.maintDate);
            mechIDcomboBox.Text = Convert.ToString(maintenenceClassObj.mechID);
            milageBox.Text = Convert.ToString(maintenenceClassObj.milage);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            maintenenceClassObj.searchID = searchBox.Text;
            maintenenceClassObj.search(maitenencedataGridView);
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void vehicIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            maintenenceClassObj.vehicID = Convert.ToInt32(vehicIDcomboBox.SelectedValue.ToString());
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            
            vehicIDcomboBox.Text="0";
            mechIDcomboBox.Text = "0";
            milageBox.Text = "0";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
