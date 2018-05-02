using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.External.Model
{
    // <summary> 
    // This class takes the user input and the collection ofe exercises and assigns a routine to a user
    // </summary>

    public class Process
    {
        public List<Exercises> ProcessUserInput(User u, List<Exercises> exercises)
        {
            List<Exercises> routines = new List<Exercises>();

            foreach(var e in exercises)
            {
                if(u._focus.Equals(e.focus) && u._type.Equals(e.type) ){
                    routines.Add(e);
                }
            }
            return routines;
        }
        
    }
}
