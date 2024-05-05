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
    internal class rentChargeClass:DB
    {
        public int id;
        public int rID_FK;
        public double rBaseChg;
        public double rChgDate;
        public double driverChg;

        public rentChargeClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO rentCharge (rID_Fk,rChgDate,rBaseChg,driverChg) values ('" + this.rID_FK + "' , GETDATE() , '" + this.rBaseChg + "'  , '" + this.driverChg + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE rentCharge rentCharge SET rID_Fk='" + this.rID_FK + "' ,  rChgDate='" + this.rChgDate + "' ,rBaseChg='" + this.rBaseChg + "' , driverChg='" + this.driverChg + "'Where rChgID = " +this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM rentCharge Where rChgID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT * FROM rentCharge";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM rentCharge";
            loadcombobox(sql, comboBox, "rChgID", "rBaseChg");
        }

        public DataTable findBtnClick(string rentID)
        {

            string sql = "select * from rent join customer on customer.custID = rent.custID_FK join vehicles on rent.vehicID_FK = vehicles.vehicID join vehicleCatogery on vehicles.vehicCatogID_FK = vehicleCatogery.vehicCatogID join tarrifs on tarrifs.vehicCatogID_FK = vehicleCatogery.vehicCatogID join driver on rent.driverID_FK = driver.driverID WHERE rent.rID = " + rentID;
            return getDataFromDatabase(sql);
        }
    }
}
