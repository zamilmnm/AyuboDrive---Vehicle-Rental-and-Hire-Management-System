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
    internal class hireClass:DB
    {
        internal int id;
        internal int hirepackID;
        internal int vehicCatogID;
        internal int CustID;
        internal int driverID;
        internal float hireExtrKmChg;
        internal float hireWaitingChgExtHrs;
        internal string hireStartDateTime;
        internal string hireEndDateTime;
        internal int hireStartOdo;
        

        internal string searchID;

        public hireClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO hire (hirepackID_FK,vehicCatogID_FK,custID_FK,driverID_FK,hireExtraKmChg,hireWaitingChgExtraHours,hireStartDateTime,hireEndDateTime,hireStartOdoMeter) values ('" + this.hirepackID + "' , '" + this.vehicCatogID + "' ,'" + this.CustID + "', '" + this.driverID + "' , '" + this.hireExtrKmChg + "' , '" + this.hireWaitingChgExtHrs + "' , '" + this.hireStartDateTime + "' , '" + this.hireEndDateTime + "' , '" + this.hireStartOdo + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE hire SET hirepackID_FK = '" + this.hirepackID + "' , vehicCatogID_FK = '" + this.vehicCatogID + "' ,driverID_FK =  '" + this.driverID + "' , hireExtraKmChg = '" + this.hireExtrKmChg + "' ,hireWaitingChgExtraHours =  '" + this.hireWaitingChgExtHrs + "' , hireStartDateTime = '" + this.hireStartDateTime + "' , hireEndDateTime = '" + this.hireEndDateTime + "' ,custID_FK = '" + this.CustID + "' , hireStartOdoMeter = '" + this.hireStartOdo + "' WHERE hireID =" +this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM hire Where hireID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT hire.hireID as [Hire ID], hire.hirepackID_FK as [Hire Pack ID], hirePackages.hirepackName as [Hire Package], hire.vehicCatogID_FK as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], hire.custID_FK as [Customer ID], customer.custName as [Customer Name], hire.driverID_FK as [Driver ID], driver.driverName as [Driver Name], hire.hireExtraKmChg as [Hire Extra Km Charge], hire.hireWaitingChgExtraHours as [Hire Waiting Charge Extra Hours], hire.hireStartDateTime as [Hire Start Date], hire.hireEndDateTime as [Hire End  Date], hire.hireStartOdoMeter as [Hire Start Odo Meter] FROM hire JOIN hirePackages ON hirePackages.hirepackID =hire.hirepackID_FK JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = hire.vehicCatogID_FK JOIN customer ON customer.custID = hire.custID_FK JOIN driver ON driver.driverID = hire.driverID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM hire";
            loadcombobox(sql, comboBox, "hireID", "hirepackID_FK");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT hire.hireID as [Hire ID], hire.hirepackID_FK as [Hire Pack ID], hirePackages.hirepackName as [Hire Package], hire.vehicCatogID_FK as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], hire.custID_FK as [Customer ID], customer.custName as [Customer Name], hire.driverID_FK as [Driver ID], driver.driverName as [Driver Name], hire.hireExtraKmChg as [Hire Extra Km Charge], hire.hireWaitingChgExtraHours as [Hire Waiting Charge Extra Hours], hire.hireStartDateTime as [Hire Start Date], hire.hireEndDateTime as [Hire End  Date], hire.hireStartOdoMeter as [Hire Start Odo Meter] FROM hire JOIN hirePackages ON hirePackages.hirepackID =hire.hirepackID_FK JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = hire.vehicCatogID_FK JOIN customer ON customer.custID = hire.custID_FK JOIN driver ON driver.driverID = hire.driverID_FK where hireID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
