using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmInsurance
{
    public class Policy
    {
        private DateTime startDate;
        private List<Driver> DriverList = new List<Driver>();
        private double dbPremium;

        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public List<Driver> Drivers
        {
            get { return DriverList; }
            set { DriverList = value; }
        }
        public double Premium
        {
            get { return dbPremium; }
            set { dbPremium += value; }
        }
        public void AddCompletedDriver(Driver d)
        {
            DriverList.Add(d);
        }

        public Policy()
        {
            StartDate = DateTime.Now;
            Premium = 0;
        }
    }
}
