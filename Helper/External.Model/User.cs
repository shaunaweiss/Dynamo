using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Helper.External.Model
{
    // <summary>
    // This class hold the properties of a User
    // </summary>

    public class User
    {
        [Required]
        public String _gender { get; set; }
        [Required]
        [Range(0,100)]
        public int _age { get; set; }
        [Required]
        public String _type { get; set; }
        [Required]
        public String _focus { get; set; }
        [Required]
        [Range(0, 400)]
        public int _currentweight { get; set; }
        [Required]
        [Range(0, 400)]
        public int _targetweight { get; set; }
        [Required]
        public int _height { get; set; }
        [Required]
        public String _difficulty { get; set; }
       

        // Empty Constructor
        public User()
        {
            this._gender = _gender;
            this._type = _type;
            this._focus = _focus;
            this._currentweight = _currentweight;
            this._targetweight = _targetweight;
            this._height = _height;
            this._difficulty = _difficulty;
        }

        public double BMI
        {
            get { return Math.Round(703 * (_currentweight / Math.Pow(_height, 2))); }
        }
        public double getDifferencce
        {
            get { return Math.Abs(_targetweight - _currentweight); }
        }
    }
}