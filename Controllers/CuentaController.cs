using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CuentaBancarias.Data;
using CuentaBancarias.Models;

namespace CuentaBancarias.Controllers
{
    
    public class CuentaController : Controller
    {
        private readonly ILogger<CuentaController> _logger;
        private readonly ApplicationDbContext _context;

        public CuentaController(ILogger<CuentaController> logger, ApplicationDbContext context)
        {
            _logger = logger;
            _context = context;
        }

        public IActionResult Index()
        {
            var cuentas = _context.DataCuenta.ToList();
            return View(cuentas);
        }

        public IActionResult CrearCuenta()
        {
            return View();
        }
        [HttpPost]
        public IActionResult CrearCuenta(Cuenta cuenta)
        {
            if (ModelState.IsValid)
            {
                _context.DataCuenta.Add(cuenta);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(cuenta);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View("Error!");
        }
    }
}