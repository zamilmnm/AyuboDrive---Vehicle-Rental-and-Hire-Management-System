using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

namespace AyuboDrive.CommonClass
{
    internal class ComClass
    {
        //application close btn click function
        public void appsCloseBtnFun()
        {
            Application.Exit();

        }
        //form close btn click fun
        public void formCloseBtnFun(Form formName)
        {
            formName.Close();
        }
        //application minimize btn click fun
        public void appsminBtnFun(Form formName)
        {
            formName.WindowState = FormWindowState.Minimized;
        }
        //application new form open btn without close current form
        public void appsNewFormOpenWithoutCurrentFormClose(Form formName)
        {
            formName.Show();
        }

        //application new form open btn with close current form
        public void apssNewFormOpenWithCurrentFormClose(Form formName, Form currentForm)
        {
            formName.Show();
            currentForm.Hide();
        }
        //display form inside panel
        public void appsFormLoadInsidePanel(Form Dashboard, Panel dashboardPanel)
        {
            //clear control first
            dashboardPanel.Controls.Clear();

            //add controls
            Dashboard.TopLevel = false;
            Dashboard.AutoScroll = true;
            dashboardPanel.Controls.Add(Dashboard);
            Dashboard.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            Dashboard.Dock = DockStyle.Fill;
            Dashboard.Show();
        }
        //convert string to int
        public int convertStringToInt(string str)
        {
            int myRet = 0;

            try
            {
                if (str != "")
                {
                    myRet = int.Parse(str);
                }
                else
                {
                    myRet = 0;
                }

            }
            catch (Exception ex)
            {
                throw;
            }
            return myRet;
        }
        //convert string to int 
        public DateTime convertStringToDateTime(string str)
        {
            DateTime myRet = new DateTime();

            try
            {
                //"2009-05-08 14:40:52,531"
                DateTime.TryParseExact(str, "yyyy-MM-dd",
                    System.Globalization.CultureInfo.InvariantCulture,
                    System.Globalization.DateTimeStyles.None, out myRet);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return myRet;
        }
        //check emptyBox
        public bool checkEmptyBoxFun(List<TextBox> list)
        {
            bool myRet = true;

            foreach (TextBox myBox in list)
            {
                if (myBox.Text.Equals(""))
                {
                    myBox.BackColor = Color.MediumVioletRed;
                    myRet = false;
                    break;
                }
                else
                {
                    myBox.BackColor = Color.White;
                }
            }
            return myRet;
        }
        //check emptyBox
        public bool checkEmptyBoxFun(List<DateTimePicker> list)
        {
            bool myRet = true;

            foreach (DateTimePicker myBox in list)
            {
                if (myBox.Text.Equals(""))
                {
                    myBox.BackColor = Color.MediumVioletRed;
                    myRet = false;
                    break;
                }
                else
                {
                    myBox.BackColor = Color.White;
                }
            }
            return myRet;
        }
        //clear textBox
        public void clearBoxFun(List<TextBox> list)
        {
            foreach (TextBox box in list)
            {
                box.Clear();
            }
        }
        //clear datetime picker
        public void clearBoxFun(List<DateTimePicker> list)
        {
            foreach (DateTimePicker box in list)
            {
                box.Text = "";
            }
        }
        //get selected date value
        public string getDatePickerDate(DateTimePicker box)
        {
            string myRet = "";

            myRet = box.Value.ToString("yyyy-MM-dd");

            return myRet;
        }
        //get seleccted time value
        public string getDatePickerTime(DateTimePicker box)
        {
            string myRet = "";

            myRet = box.Value.ToString("HH:mm:ss");

            return myRet;
        }
    }
}
