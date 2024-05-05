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
    public partial class hirePackages : Form
    {
        hirePackagesClass hirePackagesClassObj = new hirePackagesClass();
        vehicleCatogeryClass vehicCatogID = new vehicleCatogeryClass();
        public hirePackages()
        {
            InitializeComponent();
        }

        private void hirePackages_Load(object sender, EventArgs e)
        {
            hirePackagesClassObj.view(hirePackagesdataGridView);
            vehicCatogID.loadlistInComboBox(vehicCatogcomboBox);
        }

        private void hirepackNameBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.hirepackName = hirepackNameBox.Text;
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            hirePackagesClassObj.save();
            hirePackagesClassObj.view(hirePackagesdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            hirePackagesClassObj.update();
            hirePackagesClassObj.view(hirePackagesdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            hirePackagesClassObj.delete();
            hirePackagesClassObj.view(hirePackagesdataGridView);
        }

        private void hirePackagesdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void hirePackagesdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            hirePackagesClassObj.id = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[0].Value.ToString());
            hirePackagesClassObj.hirepackName = hirePackagesdataGridView.Rows[index].Cells[1].Value.ToString();
            hirePackagesClassObj.vehicCatogID = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[2].Value.ToString());
            hirePackagesClassObj.maxKm = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[4].Value.ToString());
            hirePackagesClassObj.maxHrs = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[5].Value.ToString());
            hirePackagesClassObj.extradistchg = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[6].Value.ToString());
            hirePackagesClassObj.packAmount = Convert.ToInt32(hirePackagesdataGridView.Rows[index].Cells[7].Value.ToString());

            hirepackNameBox.Text = Convert.ToString(hirePackagesClassObj.hirepackName);
            vehicCatogcomboBox.Text = Convert.ToString(hirePackagesClassObj.vehicCatogID);
            maxKmBox.Text = Convert.ToString(hirePackagesClassObj.maxKm);
            maxHrsBox.Text = Convert.ToString(hirePackagesClassObj.maxHrs);
            extraDistBox.Text = Convert.ToString(hirePackagesClassObj.extradistchg);
            packageAmountBox.Text = Convert.ToString(hirePackagesClassObj.packAmount);


        }

        private void maxKmBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.maxKm = Convert.ToInt32(maxKmBox.Text);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.searchID = searchBox.Text;
            hirePackagesClassObj.search(hirePackagesdataGridView);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            hirepackNameBox.Clear();
            vehicCatogcomboBox.Text = "0";
            maxKmBox.Text = "0";
            maxHrsBox.Text = "0";
            extraDistBox.Text = "0";
            packageAmountBox.Text = "0";
        }

        private void vehicCatogcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.vehicCatogID = Convert.ToInt32(vehicCatogcomboBox.SelectedValue.ToString());
        }

        private void maxHrsBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.maxHrs = Convert.ToInt32(maxHrsBox.Text);
        }

        private void extraDistBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.extradistchg = Convert.ToInt32(extraDistBox.Text);
        }

        private void packageAmountBox_TextChanged(object sender, EventArgs e)
        {
            hirePackagesClassObj.packAmount = Convert.ToInt32(packageAmountBox.Text);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
