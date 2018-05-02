
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Helper;
using System.Web.Mvc;
using Dynamo.Models;

namespace Dynamo.Controllers
{

    public class HomeController : Controller
    {
        // GET Home
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult ExerciseList()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfExercises();
            return View(data);
        }

        /*
        public ActionResult ViewModel()
        {
            ViewModel vm = new ViewModel();
            vm.user = user
            return View(vm);
        }

        */

        //[HttpPost]
        /*
        public ActionResult ExerciseList(string focus, string type)
        {   
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfExercises(focus, type);
            return View(data);
        }
        */
    }


}
