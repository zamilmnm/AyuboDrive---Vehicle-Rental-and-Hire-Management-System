﻿using System;
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
    public partial class ReportdriverRentHistory : Form
    {
        SummaryReportClass driverRentHistoryClassObj = new SummaryReportClass();    
        public ReportdriverRentHistory()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }

        private void driverIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void findBtn_Click(object sender, EventArgs e)
        {
            driverRentHistoryClassObj.driverRentHistoryReport(driverRentHistorydataGridView, driverIDBox.Text);
        }
    }
}
