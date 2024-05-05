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
    internal class hirePackagesClass:DB
    {
        internal int id;
        internal string hirepackName;
        internal int vehicCatogID;
        internal float maxKm;
        internal float maxHrs;
        internal float extradistchg;
        internal float packAmount;

        internal string searchID;


        public hirePackagesClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO hirePackages (hirePackName,vehicCatogID_FK,maxKm,maxHrs,extradistancechg,packAmount) values ('" + this.hirepackName + "' ,'" + this.vehicCatogID + "' ,'" + this.maxKm + "', '" + this.maxHrs + "' , '" + this.extradistchg + "' , '" + this.packAmount + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE hirePackages SET hirePackName ='" + this.hirepackName + "' ,vehicCatogID_FK = '" + this.vehicCatogID + "', maxKm = '" + this.maxKm + "' ,maxHrs = '" + this.maxHrs + "' ,extradistancechg = '" + this.extradistchg + "' , packAmount = '" + this.packAmount + "' WHERE hirePackID = " +this.id ;
            executeQuery(sql, FunctionType.update);
        }

        public void delete()
        {
            string sql = "DELETE FROM hirePackages Where hirepackID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT hirePackages.hirepackID as[Hire Package ID], hirePackages.hirepackName as [Hire Package], hirePackages.vehicCatogID_FK as[Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], hirePackages.maxKm as [Max Km], hirePackages.maxHrs as [Max Hours], hirePackages.extradistancechg as[Extra Distance Charge],hirePackages.packAmount as [Package Amount] FROM hirePackages JOIN vehicleCatogery ON  vehicleCatogery.vehicCatogID = hirePackages.vehicCatogID_FK";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }
        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM hirePackages";
            loadcombobox(sql, comboBox, "hirePackID", "hirePackName");
        }
        public void search(DataGridView _MyloadTable)
        {
            if (this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT hirePackages.hirepackID as[Hire Package ID], hirePackages.hirepackName as [Hire Package], hirePackages.vehicCatogID_FK as[Vehicle Catogery ID], vehicleCatogery.vehicCatogName as [Vehicle Catogery], hirePackages.maxKm as [Max Km], hirePackages.maxHrs as [Max Hours], hirePackages.extradistancechg as[Extra Distance Charge], hirePackages.packAmount as [Package Amount]  FROM hirePackages JOIN vehicleCatogery ON  vehicleCatogery.vehicCatogID = hirePackages.vehicCatogID_FK where hirePackID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }
    }
}
