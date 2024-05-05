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
    internal class vehicleClass:DB
    {
        internal int vehicID;
        internal string regNO;
        internal int vehicCatogID;
        internal string name;

        internal string searchID;
        public vehicleClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO vehicles (vehicRegNo,vehicCatogID_FK,vehicName) values ('" + this.regNO + "','" + this.vehicCatogID + "' , '" + this.name + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE vehicles SET vehicRegNo = '" + this.regNO + "' , vehicCatogID_FK = '" + this.vehicCatogID + "' , vehicName = '" + this.name + "' WHERE vehicID = " + this.vehicID;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM vehicles Where vehicID = " + this.vehicID;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT vehicles.vehicID as [Vehicle ID], vehicles.vehicRegNo as [Vehicle Register No], vehicles.vehicCatogID_FK as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], vehicles.vehicName as [Vehicle Name] FROM vehicles JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = vehicles.vehicCatogID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM vehicles";
            loadcombobox(sql, comboBox, "vehicID", "vehicName");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT vehicles.vehicID as [Vehicle ID], vehicles.vehicRegNo as [Vehicle Register No], vehicles.vehicCatogID_FK as [Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], vehicles.vehicName as [Vehicle Name] FROM vehicles JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = vehicles.vehicCatogID_FK where vehicID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
