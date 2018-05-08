using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Helper.External.Model;
using Helper;
using Dynamo.Models;
namespace Dynamo.Controllers
{
    public class GeneratorController : Controller
    {

        // GET: Generator
        public ActionResult Index()
        {
            return View();
        }

        public List<Exercises> getExerciseList()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfExercises();
            return data;
        }

        [HttpPost]
        public ActionResult ViewModel(User u)
        {
            // TODO
            // Need to add exception handling of form

            //if (ModelState.IsValid)
            //{
            //    return RedirectToAction("Index");
            //}

            //Send user information to viewmodel
            ViewModel vwUser = new ViewModel(u, getExerciseList());
            ViewBag.vwUser = vwUser;
            return View();
        }
        
    }
}