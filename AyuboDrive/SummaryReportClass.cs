using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data;
using AyuboDrive.CommonClass;
using System.Windows.Forms;

namespace AyuboDrive
{
    internal class SummaryReportClass:DB
    {
        internal string startdate;
        internal string enddate;
        public SummaryReportClass()
        {
            connectionWithDatabase();
        }

        public void customerHireHistoryReport (DataGridView _MyloadTable, string id)
        {
            string sql = "SELECT customer.custID AS [Customer ID], customer.custName AS [Customer Name], hirePackages.hirepackName AS [Hire Package Name],hire.hireStartDateTime AS [Hire Start DateTime], hire.hireEndDateTime As [Hire End DateTime] ,vehicleCatogery.vehicCatogName AS [Vehicle Catogery] FROM hire JOIN customer ON customer.custID = hire.custID_FK JOIN hirePackages ON hire.hirepackID_FK = hirePackages.hirepackID JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = hire.vehicCatogID_FK WHERE custID = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        
        public void customerRentHistoryReport (DataGridView  _MyloadTable, string id)
        {
            string sql = "SELECT customer.custID AS [Customer ID], customer.custName AS [Customer Name], rent.rID AS [Rent ID], vehicles.vehicName AS [Vehicle Name], vehicles.vehicRegNo AS [Vehicle Register No], rent.rentStartDate AS [Rent Start Date], rent.rentEndDate AS [Rent End Date],driver.driverName AS [Driver Name], rentCharge.driverChg AS [Driver Charge Per Day],rentCharge.rBaseChg AS [Rent Base Charge] FROM rent JOIN customer ON customer.custID = rent.custID_FK JOIN vehicles ON vehicles.vehicID = rent.vehicID_FK JOIN rentCharge ON rentCharge.rID_FK = rent.rID JOIN driver ON driver.driverID = rent.driverID_FK WHERE custID = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }

        public void driverHireHistoryReport(DataGridView _MyloadTable, string id)
        {
            string sql = "SELECT driver.driverID, driver.driverName, hire.hireID AS [Hire ID], hirePackages.hirepackName AS [Hire Package], hire.hireStartDateTime AS [Hire Start DateTime], hire.hireEndDateTime AS [Hire End DateTime], driver.driverSalary AS [Driver Salary] FROM hire JOIN driver ON driver.driverID = hire.driverID_FK JOIN hirePackages ON hirePackages.hirepackID = hire.hirepackID_FK  WHERE driverID = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }

        public void driverRentHistoryReport(DataGridView _MyloadTable, string id)
        {
            string sql = "SELECT driver.driverID AS [Driver ID], driver.driverName AS [Driver Name], rent.rID AS [Rent ID], rent.rentStartDate AS [Rent Start Date], rent.rentEndDate AS [Rent End Date], driver.driverSalary AS [Driver Salary] FROM rent JOIN driver ON driver.driverID = rent.driverID_FK  WHERE driverID = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }

        public void maintenenceReport(DataGridView _MyloadTable, string id)
        {
            string sql = "SELECT maintenence.maintID AS [Maintenance ID], vehicles.vehicID AS [Vehicle ID] ,vehicles.vehicName AS [Vehicle Name], vehicles.vehicRegNo AS [Vehicle Register No], maintenence.milage AS [Milage] ,mechanic.mechName AS [Mechanic Name], maintenence.maintDate AS [Maintenence Date]  FROM maintenence JOIN vehicles ON vehicles.vehicID = maintenence.vehicID__FK JOIN mechanic ON mechanic.mechID = maintenence.mechID_FK WHERE maintDate BETWEEN '" + this.startdate+ "' AND '"+ this.enddate +"' AND vehicID = " + id;
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
    }
}
