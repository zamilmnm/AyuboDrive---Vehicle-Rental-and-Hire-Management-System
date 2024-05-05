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
    public partial class Reportmaintenence : Form
    {
        SummaryReportClass maintenenceReportClassObj = new SummaryReportClass();
        public Reportmaintenence()
        {
            InitializeComponent();
        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {
            maintenenceReportClassObj.enddate = Convert.ToString(endDatePicker.Text);
        }

        private void driverIDbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void startDatePicker_ValueChanged(object sender, EventArgs e)
        {
            maintenenceReportClassObj.startdate = Convert.ToString(startDatePicker.Text);
        }

        private void driverReportdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void findBtn(object sender, EventArgs e)
        {

        }

        private void findButton_Click(object sender, EventArgs e)
        {
            maintenenceReportClassObj.maintenenceReport (maintReportdataGridView, vehicIDbox .Text);
        }

        private void maintReportdataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
