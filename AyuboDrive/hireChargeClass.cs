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
    internal class hireChargeClass:DB
    {
        internal int id;
        internal int hireID_FK;
        internal string hireChgDate;
        internal float hireBaseChg;
        internal float hireWaitingChg;
        internal float hireExtraKmChg;
        internal float hireOvernightStayChg;
        internal float endOdoMeter;

        public hireChargeClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO hireCharge (hireID_FK,GETDATE(),hireBaseChg,hireWaitingChg,hireExtraKmChg,hireOvernightStayChg) values ('" + this.hireID_FK + "' , '" + this.hireChgDate + "' , '" + this.hireBaseChg + "' , '" + this.hireWaitingChg + "' , '" + this.hireExtraKmChg + "' , '" + this.hireOvernightStayChg + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE hireCharge SET hireID_FK = '" + this.hireID_FK + "' , hireChgDate = '" + this.hireChgDate + "' , hireBaseChg = '" + this.hireBaseChg + "' , hireWaitingChg = '" + this.hireWaitingChg + "' , hireExtraKmChg = '" + this.hireExtraKmChg + "' , hireOvernightStayChg = '" + this.hireOvernightStayChg + "' WHERE hireChargeID = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM hireCharge Where hireChargeID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT * FROM hireCharge";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM hireCharge";
            loadcombobox(sql, comboBox, "hireChargeID", "hireID_FK");
        }

        public DataTable findBtnClick(string hireID)
        {

            string sql = "select * from hire join customer on customer.custID = hire.custID_FK  join vehicleCatogery on hire.vehicCatogID_FK = vehicleCatogery.vehicCatogID join hirePackages on  hirePackages.hirepackID = hire.hirepackID_FK join driver on hire.driverID_FK = driver.driverID WHERE hire.hireID = " + hireID;
            return getDataFromDatabase(sql);
        }
    }
}
