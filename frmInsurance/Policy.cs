using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace frmInsurance
{
    class Policy
    {
        private DateTime startDate;
        private Driver[] DriverList = new Driver[4];


        public DateTime StartDate
        {
            get { return startDate; }
            set { startDate = value; }
        }
        public Driver[] Drivers
        {
            get { return DriverList; }
            set { DriverList = value; }
        }

    }
}
