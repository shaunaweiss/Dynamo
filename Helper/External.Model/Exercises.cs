using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Helper.External.Model
{   // <summary>
    // This class is being serialized to XML.
    // </summary>


    [Serializable]
    [XmlRoot("Exercises"), XmlType("Exercises")]

    public class Exercises
    {
        public String name { get; set; }
        public String type { get; set; }
        public String focus { get; set; }
        public String description { get; set; }
        public int sets { get; set; }
        public int reps { get; set; }
    }
}
