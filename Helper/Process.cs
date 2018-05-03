using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Helper.External.Model
{
    // <summary> 
    // This class processes user input and generates the subsequent workout routine. 
    // </summary>

    public class Process
    {
        // <method summary>
        // This method takes in a user and the total list of exercies read from the XML and creates a list of exercises (Routine) 
        // that fits the users criteria specified in the generator form. 6 random numbers are then generated, and these numbers are used to 
        // populate the finalRoutine which contains 6 exercises generated at random from the routines list. 
        // </method summary>

        public List<Exercises> ProcessUserInput(User u, List<Exercises> exercises)
        {
            // Store the list of routines that fit the users criteria
            List<Exercises> routines = new List<Exercises>();

            foreach(var e in exercises)
            {
                if(u._focus.Equals(e.focus) && u._type.Equals(e.type) ){
                    routines.Add(e);

                    if(u._difficulty.Equals("1"))
                                    {
                        e.reps = 5;
                        e.sets = 2;

                    }
                    if(u._difficulty.Equals("2"))
                                    {
                        e.reps = 10;
                        e.sets = 3;
                    }
                    if(u._difficulty.Equals("3"))
                                    {
                        e.reps = 15;
                        e.sets = 4;
                    }

                }
            }
            Random rnd = new Random();

            List<Exercises> finalRoutine = new List<Exercises>();
            int randomNumber = 0;
            Exercises temp = null;
            for(int i =0; i<6; i++)
            {
                randomNumber = rnd.Next(routines.Count);
                temp = routines.ElementAtOrDefault(randomNumber);
                if (!finalRoutine.Contains(temp))
                {
                    finalRoutine.Add(temp);
                }else
                {
                    i--;
                }
            }
            
            return finalRoutine;
        
        }
        
    }
}
