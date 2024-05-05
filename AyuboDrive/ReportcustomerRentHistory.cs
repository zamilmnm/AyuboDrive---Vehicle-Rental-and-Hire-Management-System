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
    public partial class ReportcustomerRentHistory : Form
    {
        SummaryReportClass customerRentHistoryClassObj = new SummaryReportClass();
        public ReportcustomerRentHistory()
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
            customerRentHistoryClassObj.customerRentHistoryReport(custRentHistorydataGridView, custIDBox.Text);
        }

        private void custIDBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
