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
    public partial class ReportcustomerHireHistory : Form
    {
        SummaryReportClass customerHireHistoryClassObj = new SummaryReportClass();
        public ReportcustomerHireHistory()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void customerHireHistory_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            customerHireHistoryClassObj.customerHireHistoryReport(custHireHistorydataGridView, custIDBox.Text);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
}
