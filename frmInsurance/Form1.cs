using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmInsurance
{
    public partial class frmMain : Form
    {
        private Policy policy = new Policy();
        private Driver driver = new Driver();


        public frmMain()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void btnAddClaim_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text))
            {
                driver.AddClaim(dpDateOfClaim.Value);
                rtbCalculation.AppendText("Driver Name - " + txtName.Text + "\nClaim No." + (driver.Claims.Count) + " - " + dpDateOfClaim.Value.Date + "\n");
            }else
            {
                MessageBox.Show("Please enter driver details");
            }
        }

        private void btnAddDriver_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text))
            {
                if (!String.IsNullOrWhiteSpace(cbOccupation.SelectedItem.ToString()))
                {
                    if(dpDateOfBirth.Value.Date < DateTime.Now.Date)
                    {
                        driver.Name = txtName.Text;
                        driver.Occupation = cbOccupation.SelectedItem.ToString();
                        driver.DateOfBirth = dpDateOfBirth.Value.Date;

                    }
                    else
                    {
                        MessageBox.Show("Please enter a valid date of birth");
                    }
                }
                else
                {
                    MessageBox.Show("Please choose an Occupation");
                }
            }
            else
            {
                MessageBox.Show("Please enter a name for the driver.");
            }
        }

        private void dtpPolicyStart_ValueChanged(object sender, EventArgs e)
        {
            if(dtpPolicyStart.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("You cannot select a date prior to today.");
                return;
            }
            
            gbAddDriver.Enabled = true;
            policy.StartDate = dtpPolicyStart.Value.Date;
            rtbCalculation.Text = ("Policy Start Date - " + policy.StartDate.Date + "\n\n");
        }
        private double calculatePremium(Driver d)
        {
            double premium = 500.00;


            ///Occupation check
            if(d.Occupation == "Accountant")
            {
                premium = premium - (premium / 100 * 10);
            }
            else if (d.Occupation == "Chauffeur")
            {
                premium = premium + (premium / 100 * 10);
            }

            if()
        }
    }
}
