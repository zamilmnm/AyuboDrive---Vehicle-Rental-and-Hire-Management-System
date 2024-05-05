using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using AyuboDrive.CommonClass;

namespace AyuboDrive
{
    public partial class Dashboard : Form
    {
        ComClass CommonClassObj = new ComClass();
        public Dashboard()
        {
            InitializeComponent();
        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void mechanicToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new driver(), dashboardPanel);
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            
        }

        private void rentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void rentChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new rent(), dashboardPanel);
        }

        private void hireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void hireChargeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new hire(), dashboardPanel);
        }

        private void hireToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new hirePackages(), dashboardPanel);
        }

        private void vehiclesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void vehicleCatogeryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new vehicleCatogery(), dashboardPanel);
        }

        private void maitenenceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new maintenence(), dashboardPanel);
        }

        private void mechanicToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new mechanic(), dashboardPanel);
        }

        private void tarrifsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new home(), dashboardPanel);
        }

        private void rentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new rentCharge(), dashboardPanel);
        }

        private void hireChargeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new hireCharge(), dashboardPanel);
        }

        private void customerToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new customer(), dashboardPanel);
        }

        private void vehiclesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new vehicle(), dashboardPanel);
        }

        private void tarrifsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new tarrifs(), dashboardPanel);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void label_Click(object sender, EventArgs e)
        {
           
        }

        private void exitLabel_Click(object sender, EventArgs e)
        {
            this.Close();
            // To close the dashboard for exit from the application 
        }

        private void minimizelabel_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void customerHireHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new ReportcustomerHireHistory(), dashboardPanel);
        }

        private void customerRentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new ReportcustomerRentHistory(), dashboardPanel);
        }

        private void driverHireHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new ReportdriverHireHistory(), dashboardPanel);
        }

        private void driverRentHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new ReportdriverRentHistory(), dashboardPanel);
        }

        private void vehicleMaintenenceHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CommonClassObj.appsFormLoadInsidePanel(new Reportmaintenence(), dashboardPanel);
        }
    }
}
