using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    public class HourlyEmployee:Employee
    {
        public decimal HourlyRate { get; set; }

        public HourlyEmployee():base()
        {
            HourlyRate = 10.00M;
        }

        public override string GetPaySummary()
        {
            return $"Hourly employee {FirstName} {LastName} is owed {HourlyRate * 40M:C} for the week.";
        }

        public override string PaySummary
        {
            get { return $"Hourly employee {FirstName} {LastName} is owed {HourlyRate * 40M:C} for the week."; }
        }
        public override string ToString()
        {
            return base.ToString() + $" - {HourlyRate:C}/hour";

        }
    }
}
