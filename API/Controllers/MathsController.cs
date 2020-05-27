using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Challenges.Data;
using Challenges.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.Web.CodeGeneration.CommandLine;

namespace Challenges.Controllers
{
    [Route("v1/")]
    [ApiController]
    public class MathsController : ControllerBase
    {

        private readonly IMathematicalServices _services;
        private IUnitOfWork _unit;


        public MathsController(IMathematicalServices services, IUnitOfWork unit)
        {
            _services = services;
            _unit = unit;
        }

        [HttpPost]
        [Route("AddNumbers/{num1}/{num2}")]
        public ActionResult<int> AddNumbers(int num1, int num2)
        {
           var result = _services.Addition(num1, num2);
            _unit.MathsRepo.SaveAdditionToDatabase(num1,num2,result);
            return result;
        }

        [HttpPost]
        [Route("SubtractNumbers/{num1}/{num2}")]
        public ActionResult<int> SubtractNumbers(int num1, int num2)
        {
            var result = _services.Subtract(num1, num2);
            _unit.MathsRepo.SaveSubtractionToDatabase(num1, num2, result);

            return result;
        }

        [HttpPost]
        [Route("MultiplyNumbers/{num1}/{num2}")]
        public ActionResult<int> MultiplyNumbers(int num1, int num2)
        {
            var result = _services.Multiplication(num1, num2);
            _unit.MathsRepo.SaveMultiplicationToDatabase(num1, num2, result);

            return result;
        }

        [HttpPost]
        [Route("DivideNumbers/{num1}/{num2}")]
        public ActionResult<double> DivideNumbers(int num1, int num2)
        {
            var result = _services.Division(num1, num2);
            _unit.MathsRepo.SaveDivisionToDatabase(num1, num2, result);

            return result;
        }

        [HttpPost]
        [Route("CalculateFactorialOf/{num1}")]
        public ActionResult<int> Factorial(int num1)
        {
            var result = _services.CalculateFactorial(num1);
            _unit.MathsRepo.SaveFactorialToDatabase(num1, result);

            return result;
        }

    }
}