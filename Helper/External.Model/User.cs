using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Helper.External.Model
{
    // <summary>
    // This class hold the properties of a User
    // </summary>

    public class User
    {  
        public String _gender { get; set; }
        public int _age { get; set; }
        public String _type { get; set; }
        public String _focus { get; set; }
        public int _currentweight { get; set; }
        public int _targetweight { get; set; }
        public int _height { get; set; }
        public String _difficulty { get; set; }
       

        public List<Exercises> userRoutine { get; set; }

        public User(string _type, string _focus)
        {
            this._type = _type;
            this._focus = _focus;
        }

        public User()
        {

        }


        public double BMI
        {
            get { return Math.Round(703 * (_currentweight / Math.Pow(_height, 2))); }
        }
        public double getDifferencce
        {
            get { return Math.Abs(_targetweight - _currentweight); }
        }

        /*
        public User (string _type, string _focus)
        {
            this._type = _type;
            this._focus = _focus;
        }

        public User()
        {

        }
        */
    }
}