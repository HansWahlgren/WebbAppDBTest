using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebbAppDBTest.Models;

namespace WebbAppDBTest.Controllers
{
    public class HomeController : Controller
    {
        readonly IPersonService _personService;

        public HomeController(IPersonService personService)
        {
            _personService = personService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View(_personService.All());
        }

        [HttpPost]
        public IActionResult Index(string userInput)
        {
            if (userInput != null)
            {
                return View(_personService.FilterPeople(userInput));
            }
            else
            {
                return View(_personService.All());
            }
        }

        //public IActionResult PersonPartialView()
        //{
        //    return PartialView("_personPartialView", _personService.All());
        //}

        [HttpGet]
        public IActionResult CreatePerson()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreatePerson(PersonViewModel person)
        {
            if (ModelState.IsValid)
            {
                _personService.Create(person);
                return RedirectToAction("Index");
            }

            return View(person);
        }

        [HttpGet]
        public IActionResult RemovePerson(int id)
        {
            bool removeStatus = _personService.RemovePerson(id);

            //if(removeStatus)
            //{

            //}
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult UpdatePerson(int id)
        {
            Person person = _personService.Find(id);
            return View(person);
        }

        [HttpPost]
        public IActionResult UpdatePerson(PersonViewModel person, int id)
        {
            if (ModelState.IsValid)
            {
                Person updatedPerson = _personService.Update(person, id);
                return RedirectToAction("Index");
            }
            return View(person);
        }
    }
}