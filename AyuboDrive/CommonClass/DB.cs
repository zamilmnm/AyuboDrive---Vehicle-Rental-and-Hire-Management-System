using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;

namespace AyuboDrive.CommonClass
{
    public enum FunctionType
    {
        save,
        update,
        delete
    }
    internal class DB
    {
        private string connectionString = @"Data Source=ZAMIL\SQLEXPRESS;Initial Catalog=AyuboDrive;Integrated Security=True";

        private SqlConnection con = null;

        protected void connectionWithDatabase()
        {
            con = new SqlConnection(connectionString);
        }


        protected void executeQuery(string sql, FunctionType _type)
        {

            string message = "";
            int effectedRowsCount = 0;

            con.Open();

            if (_type == FunctionType.save)
            {
                SqlCommand cmd = new SqlCommand(sql, con);
                effectedRowsCount = cmd.ExecuteNonQuery();
                message = "Inserted Successfully";
            }


            else if (_type == FunctionType.update)
            {
                if (MessageBox.Show("Do you want to Update?", "Update Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    effectedRowsCount = cmd.ExecuteNonQuery();
                    message = "Update Successfully";

                }

            }


            else if (_type == FunctionType.delete)
            {
                if (MessageBox.Show("Do you want to Delete?", "Delete Confirmation Message", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    SqlCommand cmd = new SqlCommand(sql, con);
                    effectedRowsCount = cmd.ExecuteNonQuery();
                    message = "Deleted Successfully";

                }

            }
            con.Close();
            if (effectedRowsCount > 0)
            {
                MessageBox.Show(message);
            }
        }

        protected DataTable getDataFromDatabase(string sql)
        {
            DataTable myReturn = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(sql, con);
            da.Fill(myReturn);
            return myReturn;
        }
        protected void loadcombobox(string sql, ComboBox myFKBox, string idcoloumnName, string nameColoumnName)
        {
            DataTable dt = getDataFromDatabase(sql);
            myFKBox.DisplayMember = nameColoumnName;
            myFKBox.ValueMember = idcoloumnName;
            myFKBox.DataSource = dt;
        }
    }

}

