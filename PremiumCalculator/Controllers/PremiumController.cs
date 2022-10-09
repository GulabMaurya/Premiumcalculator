using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PremiumCalculator.Interfaces;
using System.Collections.Generic;
using PremiumCalculator.Models;
using Microsoft.AspNetCore.Cors;

namespace PremiumCalculator.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [EnableCors("AllowOrigin")]
    public class PremiumController : ControllerBase
    {
        private readonly IPremiumCalculatorService _premiumCalculatorService;
        public PremiumController(IPremiumCalculatorService premiumCalculatorService)
        {

            _premiumCalculatorService = premiumCalculatorService;
        }

        [HttpPost]
        [Route("calcPremium")]
        public double CalculatePremium([FromBody]Premium Premium)
        {
            return _premiumCalculatorService.CalculatePremium(Premium.SumAssured, Premium.Occupation, Premium.Age);

        }
        [HttpGet]
        [Route("getOccupation")]
        public List<Occupation> GetOccupation()
        {
            return _premiumCalculatorService.GetOccupation();

        }
    }
}
