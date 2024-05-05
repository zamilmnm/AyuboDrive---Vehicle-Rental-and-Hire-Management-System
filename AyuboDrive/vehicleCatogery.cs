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
    public partial class vehicleCatogery : Form
    {
        vehicleCatogeryClass vehicleCatogeryClassObj = new vehicleCatogeryClass();
        public vehicleCatogery()
        {
            InitializeComponent();
        }

        private void vehicleCatogery_Load(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.view(vehicCatogerydataGridView);
        }

        private void vehicCatogBox_TextChanged(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.name = vehicCatogBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.save();
            vehicleCatogeryClassObj.view(vehicCatogerydataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.update();
            vehicleCatogeryClassObj.view(vehicCatogerydataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.delete();
            vehicleCatogeryClassObj.view(vehicCatogerydataGridView);
        }

        private void vehicCatogerydataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void vehicCatogerydataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            vehicleCatogeryClassObj.id = Convert.ToInt32(vehicCatogerydataGridView.Rows[index].Cells[0].Value.ToString());
            vehicleCatogeryClassObj.name = vehicCatogerydataGridView.Rows[index].Cells[1].Value.ToString();

            vehicCatogBox.Text = Convert.ToString(vehicleCatogeryClassObj.name);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            vehicleCatogeryClassObj.searchID = searchBox.Text;
            vehicleCatogeryClassObj.search(vehicCatogerydataGridView);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicCatogBox.Clear();
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
