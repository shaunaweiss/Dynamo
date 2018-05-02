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

        [HttpPost]
        public ActionResult Index(User u)
        {
            string gender = u._gender;
            string type = u._type;
            int currentWeight = u._currentweight;
            int targetWeight = u._targetweight;
            int height = u._height;
            string difficulty = u._difficulty;
            string focus = u._focus;
            u.userRoutine= getExerciseList();

            //Send user information to viewmodel
            //ViewModel vwUser = new ViewModel();
            //vwUser.user = u;

            ViewBag.User = u;
            //return View(new ViewModel() { user = u });
            return View(u);
        }


        /*public ActionResult ExerciseList()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfExercises();

            // Sending exerciseList  to ViewModel
           // ViewModel vwList = new ViewModel();
          //  vwList.routines = data;

            return View(new ViewModel() { routines = data });
        }*/

        public List<Exercises> getExerciseList()
        {
            XMLReader readXML = new XMLReader();
            var data = readXML.ReturnListOfExercises();
            return data;
        }
       
        public ActionResult ViewModel()
        {
            ViewModel vm = new ViewModel();
         
            vm.user = ViewBag.User;
            vm.routines = getExerciseList();
            return View(vm);
        }
        
    }
}