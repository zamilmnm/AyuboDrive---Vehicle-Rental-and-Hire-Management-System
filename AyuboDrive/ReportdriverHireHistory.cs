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
    public partial class ReportdriverHireHistory : Form
    {
        SummaryReportClass driverHireHistoryClassObj = new SummaryReportClass();
        public ReportdriverHireHistory()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            driverHireHistoryClassObj.driverHireHistoryReport(driverHireHistorydataGridView, driverIDBox.Text);
        }
    }
}
