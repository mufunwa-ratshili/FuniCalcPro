using System.Diagnostics;
using FuniCalcPro.Models;
using Microsoft.AspNetCore.Mvc;

namespace FuniCalcPro.Controllers
{
    public class HomeController : Controller
    {
        
            public IActionResult Index()
            {
                return View(new CalculatorModel());
            }

            [HttpPost]
            public IActionResult Calculate(CalculatorModel model)
            {
                switch (model.Operation)
                {
                    case "+":
                        model.Result = model.Number1 + model.Number2;
                        break;

                    case "-":
                        model.Result = model.Number1 - model.Number2;
                        break;

                    case "*":
                        model.Result = model.Number1 * model.Number2;
                        break;

                    case "/":
                        model.Result = model.Number2 != 0
                            ? model.Number1 / model.Number2
                            : 0;
                        break;
                }

                return View("Index", model);
            }
        
    }
}

