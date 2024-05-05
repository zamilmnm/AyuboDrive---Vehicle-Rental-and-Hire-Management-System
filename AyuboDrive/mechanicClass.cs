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
    internal class mechanicClass:DB
    {
        internal int id;
        internal string name;
        internal int nic;
        internal int Mob;
        internal string searchID;


        public mechanicClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO mechanic (mechName,mechNic,mechMob) values ('" + this.name + "' , '" + this.nic + "' , '" + this.Mob + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE mechanic SET mechName = '" + this.name + "' , mechNic = '" + this.nic + "' , mechMob = '" + this.Mob + "' WHERE mechID = "+ this.id;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM mechanic Where mechID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT mechanic.mechID as [Mechanic ID], mechanic.mechName as [Name], mechanic.mechNic as [NIC], mechanic.mechMob as [Mobile] from mechanic";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM mechanic";
            loadcombobox(sql, comboBox, "mechID", "mechName");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT mechanic.mechID as [Mechanic ID], mechanic.mechName as [Name], mechanic.mechNic as [NIC], mechanic.mechMob as [Mobile] from mechanic where mechID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
