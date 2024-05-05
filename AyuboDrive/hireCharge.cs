using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace AyuboDrive
{
    public partial class hireCharge : Form
    {
        hireChargeClass hireChargeClassObj = new hireChargeClass();
        
        public hireCharge()
        {
            InitializeComponent();
        }

        private void hireCharge_Load(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string hireID = hireIDBox.Text;
            if (hireID == "")
            {
                MessageBox.Show("please Enter your hire ID before Search");

            }
            else
            {
                DataTable dt = hireChargeClassObj.findBtnClick(hireID);

                if (dt.Rows.Count > 0)
                {
                    //vehicle Catogery information
                    vehiCatogID.Text = dt.Rows[0]["vehicCatogID"].ToString();
                    vehicCatogName.Text = dt.Rows[0]["vehicCatogName"].ToString();

                    
                    //hire Packages information
                    hirePackID.Text = dt.Rows[0]["hirepackID"].ToString();
                    hirePackageName.Text = dt.Rows[0]["hirepackName"].ToString();
                    maximumKm.Text = dt.Rows[0]["maxKm"].ToString();
                    maxHours.Text = dt.Rows[0]["maxHrs"].ToString();
                    amountLabel.Text = dt.Rows[0]["packAmount"].ToString();

                    //Driver informaton
                    driverID.Text = dt.Rows[0]["driverID"].ToString();
                    driverName.Text = dt.Rows[0]["driverName"].ToString();
                    driverMobile.Text = dt.Rows[0]["driverMob"].ToString();
                    driverLicNo.Text = dt.Rows[0]["driverLiceNo"].ToString();
                    driverAddress.Text = dt.Rows[0]["driverAddress"].ToString();
                    
                    NightRate.Text = dt.Rows[0]["driverOvernightCharge"].ToString();

                    //Customer infomation

                    custID.Text = dt.Rows[0]["custID"].ToString();
                    custName.Text = dt.Rows[0]["custName"].ToString();
                    custLicNo.Text = dt.Rows[0]["custLicNo"].ToString();
                    custMobile.Text = dt.Rows[0]["custMob"].ToString();
                    custAddress.Text = dt.Rows[0]["custAddress"].ToString();

                    // Hire infomation

                    hireIDlbl.Text = dt.Rows[0]["hireID"].ToString();
                    hireExtraKmChg.Text = dt.Rows[0]["hireExtraKmChg"].ToString();
                    hireWaitingExtrahrChg.Text = dt.Rows[0]["hireWaitingChgExtraHours"].ToString();
                    hireStartDate.Text = dt.Rows[0]["hireStartDateTime"].ToString();
                    hireEndDate.Text = dt.Rows[0]["hireEndDateTime"].ToString();
                    hireStartOdoMeter.Text = dt.Rows[0]["hireStartOdoMeter"].ToString();



                    //hire Calculation infomation
                    //---------------------------------------------------------------------------------------------------------------
                    // Setting Hire Base charge 

                    hBaseChgBox.Text = Convert.ToString(amountLabel.Text);

                   //------------------------------------------------------------
                   // Hire total Duration/ Time Calculation

                    DateTime hireStart = Convert.ToDateTime(hireStartDate.Text);
                    DateTime hireEnd = Convert.ToDateTime(hireEndDate.Text);

                    double HireTotalDuration = (hireEnd - hireStart).TotalDays;
                    //------------------------------------------------------------
                    // Hire Total Km Calculation

                    double startOdoMeter = Convert.ToDouble(hireStartOdoMeter.Text);
                    double EndOdoMeter = 0;

                    double HireTotalKm = Convert.ToDouble(EndOdoMeter - startOdoMeter);
                    //-----------------------------------------------------------------
                    double HireExtraKmCharge = Convert.ToDouble(hireExtraKmChg.Text);                  
                    double WaitingExtraHrsChg = Convert.ToDouble(hireWaitingExtrahrChg.Text);
                    double MaxKM = Convert.ToDouble(maximumKm.Text);
                    double ExtraKmCharge = 0;
                    
                    double MaxHrs = Convert.ToDouble(maxHours.Text);
                    double waitingChg = (HireTotalDuration - MaxHrs) * HireExtraKmCharge;
                    double DriverOverNightRate = 1000;
                    double DriverNightChg = Convert.ToDouble(NightRate.Text);

                    if (HireTotalDuration < 1)
                    {
                        // daytour calculation
                        if ( HireTotalDuration >= MaxHrs )
                        {
                            waitingChg = (HireTotalDuration - MaxHrs) * WaitingExtraHrsChg; 
                        }

                        if (HireTotalKm >= MaxKM)
                        {
                            ExtraKmCharge = (HireTotalKm - MaxKM) * HireExtraKmCharge; 
                        }
                        
                    }
                    else
                    {
                        //long tour Calculation
                        if (HireTotalKm >= MaxKM)
                        {
                            ExtraKmCharge = (HireTotalKm - MaxHrs) * HireExtraKmCharge;
                        }

                        if (HireTotalDuration >= 2)
                        {
                            DriverOverNightRate = HireTotalDuration * DriverNightChg;
                        }
                        
                    }

                    overNightChgBox.Text = Convert.ToString(DriverOverNightRate);
                    waitingChgBox.Text = Convert.ToString(waitingChg);
                    extraKmChgBox.Text = Convert.ToString(ExtraKmCharge);




                }
                else
                {
                    MessageBox.Show("Invalid hire ID");
                    clearLabels();
                }



            }

            }
        private void clearLabels()
        {


            // Vehicle Type Information 
            // --------------------------------------------------------------
            vehiCatogID.Text = "Loading...";
            vehicCatogName.Text = "Loading...";
            

            // --------------------------------------------------------------
            // Hire Package information
            // --------------------------------------------------------------
            hirePackID.Text = "Loading...";
            hirePackageName.Text = "Loading...";
            maximumKm.Text = "Loading...";
            maxHours.Text = "Loading...";
            amountLabel.Text = "Loading...";


            // --------------------------------------------------------------
            // Driver information
            // --------------------------------------------------------------
            driverID.Text = "Loading...";
            driverName.Text = "Loading...";
            driverMobile.Text = "Loading...";
            driverLicNo.Text = "Loading...";
            driverAddress.Text = "Loading...";
            NightRate.Text = "Loading...";


            // --------------------------------------------------------------
            // Customer infomation
            // --------------------------------------------------------------
            custID.Text = "Loading...";
            custName.Text = "Loading...";
            custMobile.Text = "Loading...";
            custLicNo.Text = "Loading...";
            custAddress.Text = "Loading...";

            // --------------------------------------------------------------
            // Hire infomation
            // --------------------------------------------------------------
            hireIDlbl.Text = "Loading...";
            hireExtraKmChg.Text = "Loading...";
            hireWaitingExtrahrChg.Text = "Loading...";
            hireStartDate.Text = "Loading...";
            hireEndDate.Text = "Loading...";
            hireStartOdoMeter.Text = "Loading...";
        }

        private void vehiCatogID_Click(object sender, EventArgs e)
        {

        }

        private void driverChgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void hireIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void hBaseChgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void waitingChg_Click(object sender, EventArgs e)
        {

        }

        private void waitingChgBox_TextChanged(object sender, EventArgs e)
        {


        }

        private void extraKmChgBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void endOdometerBox_TextChanged(object sender, EventArgs e)
        {
            hireChargeClassObj.endOdoMeter = Convert.ToInt32(endOdometerBox.Text);
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }
    
}
