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
    public partial class rentCharge : Form
    {
        rentChargeClass rentChargeClassObj = new rentChargeClass();
        public rentCharge()
        {
            InitializeComponent();
        }

        private void rentCharge_Load(object sender, EventArgs e)
        {

        }

        private void groupBox8_Enter(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label36_Click(object sender, EventArgs e)
        {

        }

        private void label41_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void FindBtn_Click(object sender, EventArgs e)
        {
            string rentID = RentIDBox.Text;
            // Assigning the rentID id to rentID box and convert it to text format
            if(rentID == "")
            // the rentID didn't given the show this message.
            {
                MessageBox.Show("Please Enter your Rent ID before Search");
                
            }
            else
            // the rent ID is entered in textbox the rent data found from the datagridview and showing the rent data
            {
                DataTable dt = rentChargeClassObj.findBtnClick(rentID);
                

                if(dt.Rows.Count > 0)
                // The rows count greater than 0 after that the rent data will show on the form
                {
                    //vehicle type information
                    vehicCatogID.Text = dt.Rows[0]["vehicCatogID"].ToString();
                    vehicCatogName.Text = dt.Rows[0]["vehicCatogName"].ToString();
                    registerNo.Text = dt.Rows[0]["vehicRegNo"].ToString();

                    //vehicle information
                    vehicID.Text = dt.Rows[0]["vehicID"].ToString();
                    vehicName.Text = dt.Rows[0]["vehicName"].ToString();

                    //Rates information
                    tarrifID.Text = dt.Rows[0]["tID"].ToString();
                    perDay.Text = dt.Rows[0]["perDay"].ToString();
                    perWeek.Text = dt.Rows[0]["perWeek"].ToString();
                    perMonth.Text = dt.Rows[0]["perMonth"].ToString();

                    //Driver informaton
                    DriverID.Text = dt.Rows[0]["driverID"].ToString();
                    driverName.Text = dt.Rows[0]["driverName"].ToString();
                    driverMobile.Text = dt.Rows[0]["driverMob"].ToString();
                    driverLicNo.Text = dt.Rows[0]["driverLiceNo"].ToString();
                    driverAddress.Text = dt.Rows[0]["driverAddress"].ToString();
                    Rates.Text = dt.Rows[0]["driverSalary"].ToString();
                    NightRate.Text = dt.Rows[0]["driverOvernightCharge"].ToString();

                    //Customer infomation

                    custID.Text = dt.Rows[0]["custID"].ToString();
                    custName.Text = dt.Rows[0]["custName"].ToString();
                    custLic.Text = dt.Rows[0]["custLicNo"].ToString();
                    custMobile.Text = dt.Rows[0]["custMob"].ToString();
                    custAddress.Text = dt.Rows[0]["custAddress"].ToString();

                    // Rent infomation


                    rentIDlbl.Text = dt.Rows[0]["rID"].ToString();
                    rStartDate.Text = dt.Rows[0]["rentStartDate"].ToString();
                    rEndDate.Text = dt.Rows[0]["rentEndDate"].ToString();
                    rDays.Text = dt.Rows[0]["rentDays"].ToString();
                    rStartMeter.Text = dt.Rows[0]["startOdometer"].ToString();
                    rEndMeter.Text = dt.Rows[0]["endOdometer"].ToString();
                    rTotalMeter.Text = dt.Rows[0]["totalOdometerForRent"].ToString();

                    //Rent Calculation infomation
                    

                    double Days = Convert.ToDouble(rDays.Text);
                    double dayPayment = Convert.ToDouble(perDay.Text);
                    double weekPayment = Convert.ToDouble(perWeek.Text);
                    double monthPayment = Convert.ToDouble(perMonth.Text);
                    double driverPerDayCharge = Convert.ToDouble(Rates.Text);
                    double dumDays = Days;

                    // Assigning values to calculate the rent
                    int MonthsInDays = 0, WeeksInDays = 0, balanceDays = 0; 
                    
                    if (Days >= 30)
                    {
                        MonthsInDays = (int)Days / 30;

                        Days -= (MonthsInDays * 30);
                    }


                    if (Days >= 7)
                    {

                        WeeksInDays = (int)Days / 7;

                        Days -= (WeeksInDays * 7);
                    }


                    balanceDays = (int)Days;


                    rBaseChgBox.Text = Convert.ToString((MonthsInDays * monthPayment) + (weekPayment * WeeksInDays) + (dayPayment * balanceDays));
                    
                    driverChgBox.Text = Convert.ToString(driverPerDayCharge * dumDays);

                    double rBaseChg = Convert.ToDouble(rBaseChgBox.Text);
                    double driverChg = Convert.ToDouble(driverChgBox.Text);
                    totalBox.Text = Convert.ToString(rBaseChg + driverChg);

                }
                else
                {
                    MessageBox.Show("Invalid Rent ID");
                    clearLabels();
                }



            }

        }
        private void clearLabels()
        {


            // Vehicle Type Information 
            // --------------------------------------------------------------
            vehicCatogID.Text = "Loading...";
            vehicCatogName.Text = "Loading...";



            // --------------------------------------------------------------
            // Vehicle infomation
            // --------------------------------------------------------------
            vehicName.Text = "Loading...";
            vehicID.Text = "Loading...";
            registerNo.Text = "Loading...";

            // --------------------------------------------------------------
            // Rates infomation
            // --------------------------------------------------------------
            tarrifID.Text = "Loading...";
            perDay.Text = "Loading...";
            perWeek.Text = "Loading...";
            perMonth.Text = "Loading...";

            // --------------------------------------------------------------
            // Driver infomation
            // --------------------------------------------------------------
            DriverID.Text = "Loading...";
            driverName.Text = "Loading...";
            driverMobile.Text = "Loading...";
            driverLicNo.Text = "Loading...";
            driverAddress.Text = "Loading...";
            Rates.Text = "Loading...";
            NightRate.Text = "Loading...";


            // --------------------------------------------------------------
            // Customer infomation
            // --------------------------------------------------------------
            custID.Text = "Loading...";
            custName.Text = "Loading...";
            custMobile.Text = "Loading...";
            custLic.Text = "Loading...";
            custAddress.Text = "Loading...";

            
            // Rent infomation
            
            rentIDlbl.Text = "Loading...";
            rDays.Text = "Loading...";
            rDays.Text = "Loading...";
            rStartDate.Text = "Loading...";
            rEndDate.Text = "Loading...";
            rStartMeter.Text = "Loading...";
            rEndMeter.Text = "Loading...";
            rTotalMeter.Text = "Loading...";

            //rent Charge information
            rBaseChgBox.Text = "0";
            driverChgBox.Text = "0";
            totalBox.Text = "0";
            PaidAmountBox.Text = "0";
            BalanceAmountBox.Text = "0";
        }

        private void TotalAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PaidAmountBox_TextChanged(object sender, EventArgs e)
        {
            double TotalAmount = Convert.ToDouble(totalBox.Text);
            double paidAmount = Convert.ToDouble(PaidAmountBox.Text);

            BalanceAmountBox.Text = Convert.ToString(paidAmount - TotalAmount);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            

        }

        private void VehicleID_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void RentIDBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void proceedBtn_Click(object sender, EventArgs e)
        {
           
            rentChargeClassObj.rID_FK = Convert.ToInt32(rentIDlbl.Text);
            rentChargeClassObj.rBaseChg = Convert.ToInt32(rBaseChgBox.Text);
            
            rentChargeClassObj.driverChg = Convert.ToInt32((Rates.Text));
            rentChargeClassObj.save();

        }

        private void PaidAmountBox_TextChanged_1(object sender, EventArgs e)
        {
            double totalAmount = Convert.ToDouble(totalBox.Text);
            double paidAmount = Convert.ToDouble(PaidAmountBox.Text);

            BalanceAmountBox.Text = Convert.ToString( paidAmount - totalAmount);

        }

        private void totalBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void vehicCatogID_Click(object sender, EventArgs e)
        {

        }

        private void rentID_Click(object sender, EventArgs e)
        {

        }

        private void DriverID_Click(object sender, EventArgs e)
        {

        }

        private void vehicID_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void BalanceAmountBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Dashboard().Show();
        }
    }

            
    
}
