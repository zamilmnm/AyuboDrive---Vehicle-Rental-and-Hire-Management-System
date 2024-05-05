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
    internal class customerClass: DB
    {
        internal int id;
        internal string name;
        internal int licNo;
        internal int Mob;
        internal string address;

        internal string searchID;

        public customerClass()
        {
            connectionWithDatabase();
        }
        public void save()
        {
            string sql = "INSERT INTO customer (custName,custLicNo,custMob,custAddress) values ('" + this.name + "' , '" + this.licNo + "' , '" + this.Mob + "' , '" + this.address + "')";
            executeQuery(sql, FunctionType.save);
        }

        public void update()
        {
            string sql = "UPDATE customer SET  custName= '" + this.name + "' ,custLicNo ='" + this.licNo + "' ,custMob = '" + this.Mob + "' ,custAddress = '" + this.address + "'  WHERE custID = " + this.id;
            executeQuery(sql, FunctionType.update);
            

            
        }

        public void delete()
        {
            string sql = "DELETE FROM customer Where custID = " + this.id;
            executeQuery(sql, FunctionType.delete);
        }

        public void view(DataGridView _MyloadTable)
        {
            string sql = "SELECT customer.custID as [Customer ID], customer.custName as [Customer Name], customer.custLicNo as [Customer Licence Number], customer.custMob as [Customer Mobile], customer.custAddress as [Customer Address] from customer";
            DataTable dt = getDataFromDatabase(sql);
            _MyloadTable.DataSource = dt;
        }


        public void search(DataGridView _MyloadTable)
        {
            if(this.searchID == "")
            {
                view(_MyloadTable);
            }
            else
            {
                string sql = "SELECT customer.custID as [Customer ID], customer.custName as [Customer Name], customer.custLicNo as [Customer Licence Number], customer.custMob as [Customer Mobile], customer.custAddress as [Customer Address] from customer where custID = " + this.searchID;
                DataTable dt = getDataFromDatabase(sql);
                _MyloadTable.DataSource = dt;
            }
        }



        public void loadlistInComboBox(ComboBox comboBox)
        {
            string sql = "SELECT * FROM customer";
            loadcombobox(sql, comboBox, "custID", "custName");
        }

    }
}
