using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TarekDemo1.Models;

namespace TarekDemo1.Controllers
{
    public class CourseController : Controller
    {
        ApplicationDbContext _db = new ApplicationDbContext();
        

        public ActionResult Index()
        {
            var ListCourses = (from x in _db.Courses select x).ToList();
            return View(ListCourses);
        }

        /// <summary>
        /// C'est une action qui permet d'avoir une nouvelle page qui contient un formulaire pour l'ajout d'un nouveau cours
        /// </summary>
        /// <returns></returns>
        public ActionResult NewCourse()
        {
            return View();
        }

        /// <summary>
        /// C'est une méthode qui permet de valider un formulaire d'ajout
        /// </summary>
        /// <param name="CourseName_name"></param>
        /// <param name="CourseCredit_name"></param>
        /// <returns></returns>
        public ActionResult SaveCourse(string CourseName_name, int CourseCredit_name)
        {
            var NewCourse = new Course()
            {
                CourseName = CourseName_name,
                CourseCredit = CourseCredit_name
            };

            _db.Courses.Add(NewCourse);
            _db.SaveChanges();

            return RedirectToAction("Index");

        }
    }
}