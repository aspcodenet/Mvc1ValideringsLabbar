using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;
using Mvc1ValideringsLabbar.ViewModels;

namespace Mvc1ValideringsLabbar.Controllers
{
    public class DatumController : Controller
    {
        public IActionResult Index()
        {
            var viewModel = new DatumIndexViewModel();
            viewModel.Datum = DateTime.Now;
            return View(viewModel);
        }

        [HttpPost]
        public IActionResult Index(DatumIndexViewModel viewModel)
        {
            if (viewModel.Month == 2 && viewModel.Day > 28)
            {
                ModelState.AddModelError("Day","Bara 28 dagar i fenriarti");
            }

            if (ModelState.IsValid)
            {
                return RedirectToAction("Index", "Home");
            }
            return View(viewModel);
        }

    }
}
