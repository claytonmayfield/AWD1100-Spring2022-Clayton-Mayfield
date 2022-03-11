using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Photos
{
    public class Photo
    {
        protected double _width;
        protected double _height;
       // virtual double _price;

        public Photo(double width, double height)
        {
            _width = width;
            _height = height;
            
        }

            public double Width
            {
                get
                {
                return _width;
                }
                set
                {
                _width = value;
                }
            }
            public double Height
            {  
                get
                { 
                return _height; 
                }
                set 
                { 
                _height = value; 
                }
                 

            }
        public override string ToString()
        {
            return (Width + "x" + Height);
        }
    }
}
