using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CalculatorLibrary;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace CalculatorApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DivideController : Controller
    {
        CalculatorLibraryClass calculator = new CalculatorLibraryClass();

        [HttpGet]
        public decimal Get([FromQuery] decimal input1, [FromQuery] decimal input2)
        {
            return calculator.Divide(input1, input2);
        }
    }
}
