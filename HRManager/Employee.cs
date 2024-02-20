using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HRManager
{
    public class Employee
    {
        public int EmpNum { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public virtual string GetPaySummary()
        {
            return $"No pay info for {FirstName} {LastName}.";
        }

        public virtual string PaySummary
        {
            get {return $"No pay info for {FirstName} {LastName}."; }
        }
        public override string ToString()
        {

            return $"{EmpNum} - {FirstName} {LastName}";

        }
    }
}
