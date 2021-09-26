using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CodingChallenge.Models;
using CodingChallenge.Data;

namespace CodingChallenge.Controllers
{
    public class CarsController : Controller
    {
        private readonly ICarsData _carsData;
        public CarsController(ICarsData carsData)
        {
            _carsData = carsData;
        }

        [HttpGet]
        public ActionResult Cars()
        {
            var CarData= new CarViewModel{
              AllCars=  _carsData.GetAllCars().Select(x=>new SelectCar{Brand = x.Brand , Id= x.Id}).ToList()
            };
            return View ("Cars", CarData);
        }

        [HttpPost]
        public ActionResult Cars(CarViewModel carViewModel)
        {
            return View("CarDetails", _carsData.GetAllCars().FirstOrDefault(x=>x.Id == carViewModel.Id));
        }

        [HttpGet]
        public ActionResult CarDetails(CarViewModel carViewModel)
        {
            return PartialView("PartialViewCarDetails", _carsData.GetAllCars().FirstOrDefault(x=>x.Id == carViewModel.Id));
        }
    }
}