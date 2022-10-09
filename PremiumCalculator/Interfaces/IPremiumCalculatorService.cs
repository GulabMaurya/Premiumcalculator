using PremiumCalculator.Models;
using System.Collections.Generic;

namespace PremiumCalculator.Interfaces

{
  public  interface IPremiumCalculatorService
    {
        double CalculatePremium(double amount, string Occupation, int Age);
        public List<Occupation> GetOccupation();
    }
}
