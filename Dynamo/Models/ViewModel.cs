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

        // Empty Constructor
        public ViewModel()
        {
            // TODO 
            // Exception Handling..? 
        }

        // Workhorse Constructor
        public ViewModel(User u, List<Exercises> e)
        {
            this.user = u;
            this.routines = e;
            Process p = new Process();
            routines = p.ProcessUserInput(user, routines);

        }

    }
}