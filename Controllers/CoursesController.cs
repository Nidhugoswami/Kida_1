using Kida_1.Data;
using Kida_1.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Kida_1.Controllers
{
    public class CoursesController : Controller
    {
        private readonly DataContext _context;

        public CoursesController(DataContext context)
        {
            this._context = context;
        }
        /// <summary>
        /// Get methods
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public IActionResult Index()
        {
            var course = _context.Courses.ToList();
            return View(course);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Details(int id)
        {
            var course = _context.Courses.Where(x => x.ID == id).FirstOrDefault();
            return View(course);
        }
        
        [HttpGet]
        public IActionResult Edit(int id)
        {
            var course = _context.Courses.Where(x => x.ID == id).FirstOrDefault();
            return View(course);
        }

        [HttpGet]
        public IActionResult Delete(int id)
        {
            var course = _context.Courses.Where(x => x.ID == id).FirstOrDefault();
            return View(course);
        }

        /// <summary>
        /// Post methods
        /// </summary>
        /// <returns></returns>

        [HttpPost]
        public IActionResult Create(Course model)
        {
            _context.Courses.Add(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost]
        public IActionResult Edit(Course model)
        {
            _context.Courses.Update(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
        
        [HttpPost]
        public IActionResult Delete(Course model)
        {
            _context.Courses.Remove(model);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }
    }
}
