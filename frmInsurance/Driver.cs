using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmInsurance
{
    public class Driver
    {
        private String strName;
        private String strOccupation;
        private DateTime dtDateOfBirth;
        private List<DateTime> dtClaims = new List<DateTime>();

        public string Name
        {
            get
            {
                return strName;
            }
            set
            {
                if (value.Length > 0 && value != null)
                {
                    strName = value;
                }
                else
                {
                    throw new ArgumentException("Name value is null, please try again");
                }
            }
        }
        public string Occupation
        {
            get
            {
                return strOccupation;
            }
            set
            {
                if (value.Length > 0 && value != null)
                {
                    strOccupation = value;
                }
                else
                {
                    throw new ArgumentException("Occupation value is null, please try again");
                }
            }
        }
        public DateTime DateOfBirth
        {
            get { return dtDateOfBirth; }
            set { dtDateOfBirth = value; }
        }
        public Boolean DriverCheck()
        {
            if(Name != null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }


        public List<DateTime> Claims
        {
            get { return dtClaims; }
            set { dtClaims = value; }
        }
        public void AddClaim(DateTime dClaim)
        {
            if (dtClaims.Count <= 5)
            {
                dtClaims.Add(dClaim);
            }
        }
        public Driver()
        {
            Name = "John Smith";
            Occupation = "Accountant";
            dtDateOfBirth = DateTime.Now;

        }
    }
}
