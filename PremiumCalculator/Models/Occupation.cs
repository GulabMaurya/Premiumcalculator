using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PremiumCalculator.Models
{
    public class Occupation
    {
        public int Id { get; set; }
        public  string OccupationType { get; set; }
        public string Rating { get; set; }

        public double factor { get; set; }
    }
}
