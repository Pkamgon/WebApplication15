using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using WebApplication15.Models;

namespace WebApplication15.Controllers
{
    
    public class StudentController : Controller
    {
        // GET: Student
        
        StudentContext db = new StudentContext();
        public ActionResult Index()
        {
            db.StudentTable.ToList();
            db.GradeTable.ToList();
            
            return View();
        }
    }
}