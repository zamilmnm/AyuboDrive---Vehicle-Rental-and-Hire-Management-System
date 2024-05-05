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
    public partial class tarrifs : Form
    {
        tarrifsClass tarrifsClassObj = new tarrifsClass();
        vehicleCatogeryClass vehiccatogID = new vehicleCatogeryClass();
        public tarrifs()
        {
            InitializeComponent();
        }

        private void tarrifs_Load(object sender, EventArgs e)
        {
            tarrifsClassObj.view(tarrifsdataGridView);

            vehiccatogID.loadlistInComboBox(vehicCatogIDcomboBox);
        }

        private void vehicCatogIDcomboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            tarrifsClassObj.vehicCatogID = Convert.ToInt32(vehicCatogIDcomboBox.SelectedValue.ToString());
        }

        private void perDayBox_TextChanged(object sender, EventArgs e)
        {
            tarrifsClassObj.perday = Convert.ToInt32(perDayBox.Text);
        }

        private void perWeekBox_TextChanged(object sender, EventArgs e)
        {
            tarrifsClassObj.perWeek = Convert.ToInt32(perWeekBox.Text);
        }

        private void perMonthBox_TextChanged(object sender, EventArgs e)
        {
            tarrifsClassObj.perMonth = Convert.ToInt32(perMonthBox.Text);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            tarrifsClassObj.save();
            tarrifsClassObj.view(tarrifsdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            tarrifsClassObj.update();
            tarrifsClassObj.view(tarrifsdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            tarrifsClassObj.delete();
            tarrifsClassObj.view(tarrifsdataGridView);
        }

        private void tarrifsdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void tarrifsdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            tarrifsClassObj.id = Convert.ToInt32(tarrifsdataGridView.Rows[index].Cells[0].Value.ToString());
            tarrifsClassObj.vehicCatogID = Convert.ToInt32(tarrifsdataGridView.Rows[index].Cells[1].Value.ToString());
            tarrifsClassObj.perday = Convert.ToInt32(tarrifsdataGridView.Rows[index].Cells[3].Value.ToString());
            tarrifsClassObj.perWeek = Convert.ToInt32(tarrifsdataGridView.Rows[index].Cells[4].Value.ToString());
            tarrifsClassObj.perMonth = Convert.ToInt32(tarrifsdataGridView.Rows[index].Cells[5].Value.ToString());

            vehicCatogIDcomboBox.Text = Convert.ToString(tarrifsClassObj.vehicCatogID);
            perDayBox.Text = Convert.ToString(tarrifsClassObj.perday);
            perWeekBox.Text = Convert.ToString(tarrifsClassObj.perWeek);
            perMonthBox.Text = Convert.ToString(tarrifsClassObj.perMonth);

        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            tarrifsClassObj.searchID = searchBox.Text;
            tarrifsClassObj.search(tarrifsdataGridView);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            vehicCatogIDcomboBox.Text = "0";
            perDayBox.Text = "0";
            perWeekBox.Text = "0";
            perMonthBox.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
