using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Photos
{
    public class MattedPhoto : Photo
    {
        // color enums
        public enum Color
        {
            BLACK = 0,
            RED = 1,
            GREEN = 2,
            BLUE = 4,
            WHITE = 7
        }
        protected Color _theColor;
        

        //constructor
        public MattedPhoto(double width, double height, Color theColor) : base(width, height)
        {
            this._theColor = theColor;
        }
        //getters and setters
        public Color theColor
        {   get
            { return _theColor; } 
            set
            { _theColor = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " Matted " + _theColor.ToString();
        }
    }
}
