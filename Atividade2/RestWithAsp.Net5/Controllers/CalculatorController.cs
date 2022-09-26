using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithAsp.Net5.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalculatorController : ControllerBase
    {
        private readonly ILogger<CalculatorController> _logger;

        public CalculatorController(ILogger<CalculatorController> logger)
        {
            _logger = logger;
        }

        [HttpGet("sum/{fistNumeber}/{secondNumber}")]
        public IActionResult Sum(string fistNumber, string secondNumber)
        {
            if (isNumeric(fistNumber) && isNumeric(secondNumber))
            {
                var sum = ParceDecimal(fistNumber) + ParceDecimal(secondNumber);
                return Ok(sum);
            }
            return BadRequest("Invalid input");
        }
        [HttpGet("sub/{fistNumeber}/{secondNumber}")]
        public IActionResult Sub(string fistNumber, string secondNumber)
        {
            if (isNumeric(fistNumber) && isNumeric(secondNumber))
            {
                var Sub = ParceDecimal(fistNumber) - ParceDecimal(secondNumber);
                return Ok(Sub);
            }
            return BadRequest("Invalid input");
        }

        private bool isNumeric(string StrNumber)
        {
            double number;
            bool isNumeric = double.TryParse(
                StrNumber, 
                System.Globalization.NumberStyles.Any, 
                System.Globalization.NumberFormatInfo.InvariantInfo, 
                out number
            );
            return isNumeric;
        }

        private decimal ParceDecimal(string strNumber)
        {
            decimal decimalValue;
            if (decimal.TryParse(strNumber, out decimalValue))
            {
                return decimalValue;
            }
            return 0;
        }
    }
}
