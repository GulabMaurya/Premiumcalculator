namespace PremiumCalculator
{
    public interface IPremium
    {
      
            public string Name { get; set; }
            public string DOB { get; set; }
            public int Age { get; set; }
            public string Occupation { get; set; }
            public double SumInsured { get; set; }
        
    }
}
