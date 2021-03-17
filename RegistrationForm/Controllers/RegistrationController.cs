using Microsoft.AspNetCore.Mvc;
using RegistrationForm.Models;
using RegistrationForm.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RegistrationForm.Controllers
{
    public class RegistrationController : Controller
    {
        private readonly AgeCulculation _ageCalculation;

        public RegistrationController(AgeCulculation ageCalculation)
        {
            _ageCalculation = ageCalculation;
        }

        public IActionResult Index()
        {
            var model = new RegistrationModel();
            return View(model);
        }

        public IActionResult Post(RegistrationModel model)
        {
            if (!ModelState.IsValid)
            {
                return View("Index", model);
            }
            model.Age = _ageCalculation.CalculateAge(model.BirthDate);
            return View(model);
        }
    }
}
