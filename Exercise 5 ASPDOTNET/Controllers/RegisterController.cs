using Exercise_5_ASPDOTNET.DataContext;
using Exercise_5_ASPDOTNET.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Exercise_5_ASPDOTNET.Controllers
{
    public class RegisterController : Controller
    {
        private readonly CrudDBContext _cruddbcontext;

        public RegisterController(CrudDBContext crudDBContext)
        {
            _cruddbcontext = crudDBContext;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Register(Register r) 
        {
            if (ModelState.IsValid)
            {
                _cruddbcontext.Registers.Add(r);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("AllRegistered");
            }
            return View("Index");
        }
        public IActionResult AllRegistered()
        {
            return View(_cruddbcontext.Registers.ToList());
        }
        [HttpGet]
        public IActionResult Edit(int id) 
        {
            if (id == 0) 
            {
                return NotFound();
            }
            var register = _cruddbcontext.Registers.FirstOrDefault(r => r.UserId == id);
            return View(register);
        }
        [HttpPost]
        public IActionResult Edit(Register r)
        {
            if (r == null) 
            {
                return NotFound();
            }
            if (ModelState.IsValid) 
            {
                _cruddbcontext.Update(r);
                _cruddbcontext.SaveChanges();
                return RedirectToAction("AllRegistered");

            }
            return View("Edit");
        }
        [HttpGet]
        public IActionResult Delete(int id) 
        {
            var register = _cruddbcontext.Registers.FirstOrDefault(r => r.UserId == id);
            _cruddbcontext.Remove(register);
            _cruddbcontext.SaveChanges();
            return RedirectToAction("AllRegistered");
        }
    }
}
