using System;
using Xunit;
using PremiumCalculator.Services;

namespace PremiumCalculator.Tests
{
    public class PremiumCalculateServiceTest
    {
        [Fact]
        public void should_calculate_premium()
        {
            PremiumCalculatorService obj = new PremiumCalculatorService();
            var premium = obj.CalculatePremium(1000000, "Professional", 35);
            Assert.Equal(420000,premium);
                
        }
    }
}
