using System.Collections.Generic;
using PremiumCalculator.Models;
using PremiumCalculator.Interfaces;

namespace PremiumCalculator.Services
{
    public class PremiumCalculatorService : IPremiumCalculatorService
    {
        public double CalculatePremium(double amount, string Occupation, int Age)
        {


            //Death Premium = (Death Cover amount * Occupation Rating Factor * Age) /1000 * 12
            return (amount * Age * RatingFactor(Occupation)) / 1000 * 12;

        }
        private double RatingFactor(string Occupation)
        {

            if (Occupation == "Professional")
                return 1.0;
            if (Occupation == "White Collar")
                return 1.25;
            if (Occupation == "Light Manual")
                return 1.50;
            if (Occupation == "Heavy Manual")
                return 1.75;

            return 0;
        }
        public List<Occupation> GetOccupation()
        {

            return new List<Occupation>() {
            new Occupation(){Id=1,OccupationType="Cleaner",Rating="Light Manual" },
            new Occupation() { Id = 2, OccupationType = "Doctor", Rating = "Professional" },
            new Occupation() { Id = 3, OccupationType = "Author", Rating = "White Collar" },
            new Occupation() { Id = 4, OccupationType = "Farmer", Rating = "Heavy Manual" },
            new Occupation() { Id = 5, OccupationType = "Mechanic", Rating = "Heavy Manual" },
            new Occupation() { Id = 6, OccupationType = "Florist", Rating = "Light Manual" },

      };

        }

       
    }




}
