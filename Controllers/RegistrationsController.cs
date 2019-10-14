using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using XM.Models;
using XM.Models.Entity;
using XM.Models.ViewModel;


namespace Exam.Controllers
{
    public class RegistrationsController : Controller
    {
        private readonly EMSContext _context;
       // private TestType TestTypes { get; set; }
        public Test Test { get; set; }
        public RegistrationsController(EMSContext context)
        {
            //this.TestTypes = _TestType;
            this._context = context;
            //this.Test = _test;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
       
        public IActionResult Create()
        {
            ViewData["TestId"] = new SelectList(_context.Test, "Name", "Name");
            return View();
        }
        [HttpPost]
        public IActionResult Create(Registration registration)
        {
            ViewData["TestId"] = new SelectList(_context.Test, "Id", "Id", registration.TestId);

            Student student = new Student
            {
                Name = registration.Student.Name,
                FatherName = registration.Student.FatherName,
                Phone = registration.Student.Phone,
                Email = registration.Student.Email,
                Nid = registration.Student.Nid,
                EnteryDate = DateTime.Now

                
            };
            _context.Add(student);
            _context.SaveChanges();

            Registration _registration = new Registration()
            {
                StudentId = student.Id
            };
            _context.Add(_registration);
            _context.SaveChanges();


            _context.Add(registration);
            _context.SaveChanges();

            return View();
        }

        //public void SelectList()
        //{
        //    ViewBag.TestList = new SelectList(TestTypes.GetAllTest(), "Id", "Name");
        //}


    }
}
