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
    public partial class driver : Form
    {
        driverClass driverClassObj = new driverClass();
        public driver()
        {
            InitializeComponent();
        }

        private void driver_Load(object sender, EventArgs e)
        {
            driverClassObj.view(driverdataGridView);
        }

        private void driverNameBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.name = driverNameBox.Text;
        }

        private void drivermobileBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.Mob = Convert.ToInt32(drivermobileBox.Text);
        }

        private void driverLicBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.liceNo = Convert.ToInt32(driverLicBox.Text);
        }

        private void driverAddressBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.address = driverAddressBox.Text;
        }

        private void driverSalaryBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.salary = Convert.ToInt32(driverSalaryBox.Text);
        }

        private void driverOvernightChgBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.overnightchg = Convert.ToInt32(driverOvernightChgBox.Text);
        }

        private void driverdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            driverClassObj.save();
            driverClassObj.view(driverdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            driverClassObj.update();
            driverClassObj.view(driverdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            driverClassObj.delete();
            driverClassObj.view(driverdataGridView);
        }

        private void driverdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            driverClassObj.id = Convert.ToInt32(driverdataGridView.Rows[index].Cells[0].Value.ToString());
            driverClassObj.name = driverdataGridView.Rows[index].Cells[1].Value.ToString();
            driverClassObj.Mob = Convert.ToInt32(driverdataGridView.Rows[index].Cells[2].Value.ToString());
            driverClassObj.liceNo = Convert.ToInt32(driverdataGridView.Rows[index].Cells[3].Value.ToString());
            driverClassObj.address = driverdataGridView.Rows[index].Cells[4].Value.ToString();
            driverClassObj.salary = Convert.ToInt32(driverdataGridView.Rows[index].Cells[5].Value.ToString());
            driverClassObj.overnightchg = Convert.ToInt32(driverdataGridView.Rows[index].Cells[6].Value.ToString());


            driverNameBox.Text = driverClassObj.name;
            drivermobileBox.Text = Convert.ToString(driverClassObj.Mob);
            driverLicBox.Text = Convert.ToString(driverClassObj.liceNo);
            driverAddressBox.Text = driverClassObj.address;
            driverSalaryBox.Text = Convert.ToString(driverClassObj.salary);
            driverOvernightChgBox.Text = Convert.ToString(driverClassObj.overnightchg);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            driverClassObj.searchID = searchBox.Text;
            driverClassObj.search(driverdataGridView);
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void SearchBtn_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            driverNameBox.Clear();
            drivermobileBox.Text = "0";
            driverLicBox.Text = "0";
            driverAddressBox.Clear();
            driverSalaryBox.Text = "0";
            driverOvernightChgBox.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
