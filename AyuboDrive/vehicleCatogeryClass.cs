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
    internal class vehicleCatogeryClass:DB
    {
        internal int id;
        internal string name;
        internal string searchID;

        public vehicleCatogeryClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO vehicleCatogery (vehicCatogName) values ('" + this.name + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE vehicleCatogery SET vehicCatogName = '" + this.name + "' WHERE vehicCatogID = " + this.id;
            
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM vehicleCatogery Where vehicCatogID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT vehicleCatogery.vehicCatogID as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery] FROM vehicleCatogery";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM vehicleCatogery";
            loadcombobox(sql, comboBox, "vehicCatogID", "vehicCatogName");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT vehicleCatogery.vehicCatogID as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery] FROM vehicleCatogery where vehicCatogID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
