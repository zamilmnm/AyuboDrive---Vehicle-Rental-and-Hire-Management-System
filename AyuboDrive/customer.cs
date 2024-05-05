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
    public partial class customer : Form
    {  
        customerClass customerClassObj = new customerClass();
        public customer()
        {
            InitializeComponent();
        }

        private void custNameBox_TextChanged(object sender, EventArgs e)
        {
            customerClassObj.name = custNameBox.Text;
        }

        private void custLicBox_TextChanged(object sender, EventArgs e)
        {
            customerClassObj.licNo = Convert.ToInt32(custLicBox.Text);
        }

        private void custMobBox_TextChanged(object sender, EventArgs e)
        {
            customerClassObj.Mob = Convert.ToInt32(custMobBox.Text);
        }

        private void custAddressBox_TextChanged(object sender, EventArgs e)
        {
            customerClassObj.address = custAddressBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            customerClassObj.save();
            customerClassObj.view(customerdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            customerClassObj.update();
            customerClassObj.view(customerdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            customerClassObj.delete();
            customerClassObj.view(customerdataGridView);
        }

        private void customerdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void customer_Load(object sender, EventArgs e)
        {
            customerClassObj.view(customerdataGridView);
        }

        private void customerdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            int index = e.RowIndex;
            customerClassObj.id = Convert.ToInt32(customerdataGridView.Rows[index].Cells[0].Value.ToString());
            customerClassObj.name = customerdataGridView.Rows[index].Cells[1].Value.ToString();
            customerClassObj.licNo = Convert.ToInt32(customerdataGridView.Rows[index].Cells[2].Value.ToString());
            customerClassObj.Mob = Convert.ToInt32(customerdataGridView.Rows[index].Cells[3].Value.ToString());
            customerClassObj.address = customerdataGridView.Rows[index].Cells[4].Value.ToString();

            custNameBox.Text = customerClassObj.name;
            custLicBox.Text =  Convert.ToString(customerClassObj.licNo);
            custMobBox.Text = Convert.ToString(customerClassObj.Mob);
            custAddressBox.Text = customerClassObj.address;


        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            customerClassObj.searchID = searchBox.Text;
            customerClassObj.search(customerdataGridView);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            custNameBox.Clear();
            custLicBox.Text = "0";
            custMobBox.Text = "0";
            custAddressBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void customergroupBox_Enter(object sender, EventArgs e)
        {

        }
    }
}
