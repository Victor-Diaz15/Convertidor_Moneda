using Application.Services;
using Application.ViewModels;
using ConversorMoneda.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ConversorMoneda.Controllers
{
    public class CurrencyController : Controller
    {
        private readonly ILogger<CurrencyController> _logger;
        private readonly CurrenciesViewModel vm = new();
        private readonly CurrencyService service = new();
        public CurrencyController(ILogger<CurrencyController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View(vm);
        }
        [HttpPost]
        public IActionResult Index(CurrenciesViewModel currencies)
        {
            currencies.ValorDivisa = service.CalculateCurrency(currencies);
            return View(currencies);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
