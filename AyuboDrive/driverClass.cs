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
    internal class driverClass:DB
    {
        internal int id;
        internal string name;
        internal int Mob;
        internal int liceNo;
        internal string address;
        internal float salary;
        internal float overnightchg;

        internal string searchID;

        public driverClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO driver(driverName,driverMob,driverLiceNo,driverAddress,driverSalary,driverOvernightCharge) values ('" + this.name + "' , '" + this.Mob + "' , '" + this.liceNo + "' , '" + this.address + "' , '" + this.salary + "' , '" + this.overnightchg + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE driver SET driverName = '" + this.name + "',driverMob = '" + this.Mob + "',driverLiceNo = '" + this.liceNo + "',driverAddress = '" + this.address + "',driverSalary = '" + this.salary + "',driverOvernightCharge = '" + this.overnightchg + "' WHERE driverID = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM driver Where driverID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT driver.driverID as [Driver ID], driver.driverName as [Driver Name],driver.driverMob as [Driver Mobile], driver.driverLiceNo as [Driver Licence Number], driver.driverAddress as [Driver Address], driver.driverSalary as [Driver Salary], driver.driverOvernightCharge as [Driver Overnight Charge] from driver";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM driver";
            loadcombobox(sql, comboBox, "driverID", "driverName");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT driver.driverID as [Driver ID], driver.driverName as [Driver Name],driver.driverMob as [Driver Mobile], driver.driverLiceNo as [Driver Licence Number], driver.driverAddress as [Driver Address], driver.driverSalary as [Driver Salary], driver.driverOvernightCharge as [Driver Overnight Charge] from driver where driverID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }

    }
}
