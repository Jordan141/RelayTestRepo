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
                if (driver.Claims.Count + 1 <= 5)
                {
                    driver.AddClaim(dpDateOfClaim.Value);
                    rtbCalculation.AppendText("Driver Name - " + txtName.Text + "\nClaim No." + (driver.Claims.Count) + " - " + dpDateOfClaim.Value.Date.ToShortDateString() + "\n");
                }
                else
                {
                    MessageBox.Show("Driver cannot have more than 5 claims");
                }
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
                        if (Enumerable.Range(21,54).Contains(YearsBetween(dpDateOfBirth.Value.Date)))
                        {
                            if (driver.Claims.Count <= 2)
                            {
                                int Claims = driver.Claims.Count;
                                foreach(Driver d in policy.Drivers)
                                {
                                    Claims += d.Claims.Count;
                                }
                                if (Claims < 3)
                                {
                                    driver.Name = txtName.Text;
                                    driver.Occupation = cbOccupation.SelectedItem.ToString();
                                    driver.DateOfBirth = dpDateOfBirth.Value.Date;

                                    rtbDriverInfo.Text = ("Driver Information\nName: " + driver.Name + "\nOccupation: " + driver.Occupation + "Age: " + YearsBetween(driver.DateOfBirth));

                                    if (policy.Drivers.Count <= 5)
                                    {
                                        policy.AddCompletedDriver(driver);
                                        policy.Premium = calculatePremium(driver);
                                        btnSave.Enabled = true;
                                        //Reset the variables
                                        ResetInputs();
                                    }
                                    else
                                    {
                                        MessageBox.Show("You have exceeded the maximum limit of drivers per policy.");
                                    }
                                }
                                else
                                {
                                    MessageBox.Show("Policy has more than 3 claims","Policy Declined");
                                }
                            }
                            else
                            {
                                MessageBox.Show("Driver has more than 2 claims - " + txtName.Text,"Driver Declined");
                            }
                        }
                        else if(YearsBetween(dpDateOfBirth.Value.Date) < 21)
                        {
                            MessageBox.Show("Age of Youngest Driver - " + txtName.Text, "Driver Declined");
                        }
                        else if(YearsBetween(dpDateOfBirth.Value.Date) > 75)
                        {
                            MessageBox.Show("Age of Oldest Driver - " + txtName.Text, "Driver Declined");
                        }
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
            ResetInputs();
        }
        private void ResetInputs()
        {
            driver = new Driver();
            txtName.Clear();
            cbOccupation.ResetText();
            dpDateOfBirth.ResetText();
            dpDateOfClaim.ResetText();
        }
        private int YearsBetween(DateTime bday)
        {
            //Checks against policy startdate
            DateTime ageOnStart = policy.StartDate;

            int age = ageOnStart.Year - bday.Year;
            if (bday > ageOnStart.AddYears(-age))
                age--;
            return age;
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
            rtbCalculation.Text = ("Policy Start Date - " + policy.StartDate.Date.ToShortDateString() + "\n\n");
        }

        private double calculatePremium(Driver d)
        {
            double premium = 500.00;
            int age = YearsBetween(d.DateOfBirth);

            rtbCalculation.AppendText("Premiuim standard cost - £500.00\nDriver Occupation:\n");
            ///Occupation check
            if (d.Occupation == "Accountant")
            {
                premium = premium - (premium / 100 * 10);
                rtbCalculation.AppendText("After Occupation costs - £" + premium + "\n");
            }
            else if (d.Occupation == "Chauffeur")
            {
                premium = premium + (premium / 100 * 10);
                rtbCalculation.AppendText("After Occupation costs - £" + premium + "\n");
            }

            if(Enumerable.Range(21, 4).Contains(age))
            {
                premium = premium + (premium / 100 * 20);
                rtbCalculation.AppendText("Age - " + age + " - Premium is now £" + premium + "\n");
            }
            else if (Enumerable.Range(26, 49).Contains(age))
            {
                premium = premium - (premium / 100 * 10);
            }
            for (int i = 0; i < d.Claims.Count; i++)
            {
                if(YearsBetween(d.Claims[i].Date) <= 1)
                {
                    premium = premium + (premium / 100 * 20);
                    rtbCalculation.AppendText("Your claim is within a year of the start date, Premium increased by 20% - £" + premium);
                }
                else if (Enumerable.Range(2, 3).Contains(YearsBetween(d.Claims[i].Date))){
                    premium = premium + (premium / 100 * 10);
                    rtbCalculation.AppendText("Your claim is within 2-5 years of start date, Premium increased by 10% - £" + premium);
                }
            }
            return premium;
        }

        private void txtName_TextChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtName.Text))
            {
                cbOccupation.Enabled = true;
            }
            else
            {
                cbOccupation.Enabled = false;
            }
        }

        private void cbOccupation_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(cbOccupation.SelectedItem.ToString()))
            {
                dpDateOfBirth.Enabled = true;
            }
            else
            {
                dpDateOfBirth.Enabled = false;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                System.Xml.Serialization.XmlSerializer writer =
                new System.Xml.Serialization.XmlSerializer(typeof(Policy));

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Policies.xml";
                System.IO.FileStream file = System.IO.File.Create(path);

                writer.Serialize(file, policy);
                file.Close();
            }catch(Exception ex)
            {
                MessageBox.Show("Error saving file - " + ex.ToString());
            }
        }

        private void btnLoad_Click(object sender, EventArgs e)
        {try
            {
                System.Xml.Serialization.XmlSerializer reader =
            new System.Xml.Serialization.XmlSerializer(typeof(Policy));

                var path = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "//Policies.xml";

                System.IO.StreamReader file = new System.IO.StreamReader(path);
                policy = (Policy)reader.Deserialize(file);
                file.Close();

                rtbCalculation.Text = ("Policy Start Date : " + policy.StartDate.ToShortDateString() + "\n\nPolicy Premium: £" + policy.Premium.ToString());
                foreach (Driver d in policy.Drivers)
                {
                    rtbCalculation.AppendText("\nDriver:");
                    rtbCalculation.AppendText("\n\tName: " + d.Name + "\n\tOccupation: " + d.Occupation + "\n\tDate Of Birth: " + d.DateOfBirth.ToShortDateString());
                    for (int i = 0; i < d.Claims.Count; i++)
                    {
                        rtbCalculation.AppendText("\n\tClaim: " + d.Claims[i].ToShortDateString());
                    }
                }
            }
            catch (System.IO.FileNotFoundException)
            {
                MessageBox.Show("File not found");
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }

        }
    }
}
