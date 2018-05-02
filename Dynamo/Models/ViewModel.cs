using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Helper.External.Model;
using Helper;

namespace Dynamo.Models
{
    public class ViewModel
    {

        public User user { get; set; }
        public List<Exercises> routines { get; set; }

        public ViewModel()
        {
            Process p = new Process();
            routines = p.ProcessUserInput(user, routines);

        }









    }
}