using StudentCatalog3.Models;
using StudentCatalog3.Repositories;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentCatalog2.Controllers
{
    public class StudentsController : Controller
    {
        private IStudentRepository studentRepo;
        public StudentsController(IStudentRepository repo)
        {
            studentRepo = repo;
        }


        // GET: Students
        //action method
        public ActionResult Index()
        {
           
            return View(studentRepo.GetAll());
        }

        public string WannaPlayDad()
        {
            return "No, I am coding..";
        }

        public ActionResult MadView()
        {
            //defining Cat property
            ViewBag.Cat = "Miauu, I am a cat";

            return View();
        }
        [HttpGet]
        public ActionResult Edit(int id)
        {
            //Find the student from the id 
            //and send to view.

            return View(studentRepo.Find(id));
        }

        [HttpPost]
        public ActionResult Edit(Student student)
        {
            //set it to update the student object when you save
            if (ModelState.IsValid) {
                studentRepo.InsertOrUpdate(student);
                return RedirectToAction("Index");
            }
            return View();
            //go back to index-view after succesful edit.
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Student student)
        {
            //if no broken rules, defined in student
            if (ModelState.IsValid)
            {
                studentRepo.InsertOrUpdate(student);
                return View("Thanks");
            }
            return View();

        }
    }
}