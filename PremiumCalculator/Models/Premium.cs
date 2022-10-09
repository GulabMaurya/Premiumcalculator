using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Premium
    {
        public string  Name { get; set; }
        public int Age { get; set; }
        public string  DOB { get; set; }

        public string Occupation { get; set; }
        public double SumAssured { get; set; }
    }
}
