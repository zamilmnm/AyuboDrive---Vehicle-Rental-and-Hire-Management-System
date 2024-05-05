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
    internal class tarrifsClass:DB
    {
        internal int id;
        internal int vehicCatogID;
        internal int perday;
        internal int perWeek;
        internal int perMonth;

        internal string searchID;

        public tarrifsClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO tarrifs (vehicCatogID_FK,perDay,perWeek,perMonth) values ('" + this.vehicCatogID + "' , '" + this.perday + "' , '" + this.perWeek + "' , '" + this.perMonth + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE tarrifs SET vehicCatogID_FK = '" + this.vehicCatogID + "' ,perDay = '" + this.perday + "' ,perWeek = '" + this.perWeek + "' ,perMonth = '" + this.perMonth + "' WHERE tID = "+ this.id;
            executeQuery(sql, FunctionType.update);

        }

        public void delete()
        {
            string sql = "DELETE FROM tarrifs Where tID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT tarrifs.tID as [Tarrif ID] , tarrifs.vehicCatogID_FK as [Vehicle Catogery ID] , vehicleCatogery.vehicCatogName as [Vehicle Catogery] , tarrifs.perDay as [Per Day] , tarrifs.perWeek as [Per Week] , tarrifs.perMonth as [Per Month] FROM tarrifs JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = tarrifs.vehicCatogID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM tarrifs";
            loadcombobox(sql, comboBox, "tID", "vehicCatogID_FK");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT tarrifs.tID as [Tarrif ID] , tarrifs.vehicCatogID_FK as [Vehicle Catogery ID] , vehicleCatogery.vehicCatogName as [Vehicle Catogery] , tarrifs.perDay as [Per Day] , tarrifs.perWeek as [Per Week] , tarrifs.perMonth as [Per Month] FROM tarrifs JOIN vehicleCatogery ON vehicleCatogery.vehicCatogID = tarrifs.vehicCatogID_FK where tID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
