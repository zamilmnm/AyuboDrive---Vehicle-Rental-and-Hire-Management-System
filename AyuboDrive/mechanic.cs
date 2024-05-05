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
    public partial class mechanic : Form
    {
        mechanicClass mechanicClassObj = new mechanicClass();
        public mechanic()
        {
            InitializeComponent();
        }

        private void mechanic_Load(object sender, EventArgs e)
        {
            mechanicClassObj.view(mechanicdataGridView);
        }

        private void mechNameBox_TextChanged(object sender, EventArgs e)
        {
            mechanicClassObj.name = mechNameBox.Text;
        }

        private void mechNicBox_TextChanged(object sender, EventArgs e)
        {
            mechanicClassObj.nic = Convert.ToInt32(mechNicBox.Text);
        }

        private void mechMobBox_TextChanged(object sender, EventArgs e)
        {
            mechanicClassObj.Mob = Convert.ToInt32(mechMobBox.Text);
        }

        private void saveBtn_Click(object sender, EventArgs e)
        {
            mechanicClassObj.save();
            mechanicClassObj.view(mechanicdataGridView);
        }

        private void updateBtn_Click(object sender, EventArgs e)
        {
            mechanicClassObj.update();
            mechanicClassObj.view(mechanicdataGridView);
        }

        private void deleteBtn_Click(object sender, EventArgs e)
        {
            mechanicClassObj.delete();
            mechanicClassObj.view(mechanicdataGridView);
        }

        private void mechanicdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void mechanicgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void mechanicdataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            mechanicClassObj.id = Convert.ToInt32(mechanicdataGridView.Rows[index].Cells[0].Value.ToString());
            mechanicClassObj.name = mechanicdataGridView.Rows[index].Cells[1].Value.ToString();
            mechanicClassObj.nic = Convert.ToInt32(mechanicdataGridView.Rows[index].Cells[2].Value.ToString());
            mechanicClassObj.Mob = Convert.ToInt32(mechanicdataGridView.Rows[index].Cells[3].Value.ToString());

            
            mechNameBox.Text = mechanicClassObj.name;
            mechNicBox.Text = Convert.ToString(mechanicClassObj.nic);
            mechMobBox.Text = Convert.ToString(mechanicClassObj.Mob);
        }

        private void searchBtn_Click(object sender, EventArgs e)
        {
            
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            mechanicClassObj.searchID = searchBox.Text;
            mechanicClassObj.search(mechanicdataGridView);
        }

        private void clearBtn_Click(object sender, EventArgs e)
        {
            mechNameBox.Clear();
            mechNicBox.Text = "0";
            mechMobBox.Text = "0";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
