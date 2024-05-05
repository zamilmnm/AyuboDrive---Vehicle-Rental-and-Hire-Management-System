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
    internal class maintenenceClass:DB
    {
        internal int id;
        internal int vehicID;
        internal string maintDate;
        internal int mechID;
        internal float milage;
        
        internal string searchID;





        public maintenenceClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO maintenence (vehicID__FK,maintDate,mechID_FK,milage) values ('" + this.vehicID + "' , '" + this.maintDate + "' , '" + this.mechID + "' , '" + this.milage + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE maintenence SET vehicID__FK = '" + this.vehicID + "' , maintDate = '" + this.maintDate + "' , mechID_FK = '" + this.mechID + "' , milage = '" + this.milage + "' WHERE maintID = " + this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM maintenence Where maintID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT maintenence.maintID as [Maintenence ID], maintenence.vehicID__FK as [Vehicle ID], vehicles.vehicName as [Vehicle Name], maintenence.maintDate as [Maintenence Date], maintenence.mechID_FK as [Mechanic ID], mechanic.mechName as [Mechanic Name], maintenence.milage as [Milage] FROM maintenence JOIN vehicles ON vehicles.vehicID = maintenence.vehicID__FK JOIN mechanic ON mechanic.mechID = maintenence.mechID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM maintenence";
            loadcombobox(sql, comboBox, "maintID", "vehicID__FK");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT maintenence.maintID as [Maintenence ID], maintenence.vehicID__FK as [Vehicle ID], vehicles.vehicName as [Vehicle Name], maintenence.maintDate as [Maintenence Date], maintenence.mechID_FK as [Mechanic ID], mechanic.mechName as [Mechanic Name], maintenence.milage as [Milage] FROM maintenence JOIN vehicles ON vehicles.vehicID = maintenence.vehicID__FK JOIN mechanic ON mechanic.mechID = maintenence.mechID_FK where maintID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
