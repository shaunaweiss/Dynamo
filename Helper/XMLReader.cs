using Helper.External.Model;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;

namespace Helper
{
    public class XMLReader
    {
        // <summary>
        // Returns list of products from XML
        // </summary>

        // <returns> List of exercises </returns>
        
        public List<Exercises> ReturnListOfExercises()
        {
            string xmlData = HttpContext.Current.Server.MapPath("~/App_Data/ExercisesD.xml");
            DataSet ds = new DataSet();
            ds.ReadXml(xmlData);

            var exercises = new List<Exercises>();
            exercises = (from row in ds.Tables[0].AsEnumerable()
                         select new Exercises
                         {
                             name = row[0].ToString(),
                             type = row[1].ToString(),
                             focus = row[2].ToString(),
                             description = row[3].ToString(),
                             // Setting a default values for sets and reps
                             sets = 10,
                             reps = 3
                         }).ToList();
            return exercises;

        }



    }
}
