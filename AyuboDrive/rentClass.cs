using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
using System.Data;
using AyuboDrive.CommonClass;

namespace AyuboDrive
{
    internal class rentClass:DB
    {
        internal int id;
        internal int vehicID;
        internal int CustID;
        internal int driverID;
        internal string rentStartDate;
        internal string rentEndDate;
        internal int rentDays;
        internal float startOdometer;
        internal float endOdometer;
        internal float totalOdometerForRent;
        

        internal string searchID;


        public rentClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO rent (vehicID_FK,custID_FK,driverID_FK,rentStartDate,rentEndDate,rentDays,startOdometer,endOdometer,totalOdometerForRent) values ('" + this.vehicID + "' , '" + this.CustID + "' ,'" + this.driverID + "' , '" + this.rentStartDate + "' , '" + this.rentEndDate + "' , '" + this.rentDays + "' , '" + this.startOdometer + "' , '" + this.endOdometer + "' , '" + this.totalOdometerForRent + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE rent SET vehicID_FK = '" + this.vehicID + "',custID_FK = '" + this.CustID + "' ,driverID_FK =  '" + this.driverID + "' , rentStartDate = '" + this.rentStartDate + "' , rentEndDate = '" + this.rentEndDate + "' , rentDays = '" + this.rentDays + "' , startOdometer = '" + this.startOdometer + "' ,endOdometer =  '" + this.endOdometer + "' ,totalOdometerForRent =  '" + this.totalOdometerForRent + "' WHERE rID = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM rent Where rID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT rent.rID as [Rent ID] , vehicles.vehicID as [Vehicle ID], vehicles.vehicName as [Vehicle Name], rent.custID_FK as [Customer ID], customer.custName as [Customer Name],driver.driverID as[Driver ID], driver.driverName as[Driver Name],rent.rentStartDate as [Rent Start Date],rent.rentEndDate as [Rent End Date],rent.rentDays as [Rent Days], rent.startOdometer as [Start Odo Meter], rent.endOdometer as [End Odo Meter], rent.totalOdometerForRent as [Total Odo Meter For Rent]  FROM rent  join driver on  driver.driverID = rent.driverID_FK  join vehicles on vehicles.vehicID = rent.vehicID_FK join customer on customer.custID = rent.custID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM rent";
            loadcombobox(sql, comboBox, "rID", "vehicID_FK");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT rent.rID as [Rent ID] , vehicles.vehicID as [Vehicle ID], vehicles.vehicName as [Vehicle Name], rent.custID_FK as [Customer ID], customer.custName as [Customer Name],driver.driverID as[Driver ID], driver.driverName as[Driver Name],rent.rentStartDate as [Rent Start Date],rent.rentEndDate as [Rent End Date],rent.rentDays as [Rent Days], rent.startOdometer as [Start Odo Meter], rent.endOdometer as [End Odo Meter], rent.totalOdometerForRent as [Total Odo Meter For Rent]  FROM rent  join driver on  driver.driverID = rent.driverID_FK  join vehicles on vehicles.vehicID = rent.vehicID_FK join customer on customer.custID = rent.custID_FK where rID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
