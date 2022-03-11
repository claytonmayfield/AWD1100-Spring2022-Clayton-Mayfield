using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ch12_lab6
{
   
   
    public class Class1
    {
        const double Extra = 1;
        const double Feet = 12;
      

        private string _name;
        private  int _length;
        private  int _width;
        private  int _area;
        private  int _boxes;
        private  double _total;

        public Class1(string name,int Width, int Length)
        {
            _name = name;
            _width = Width;
            _length = Length;


        }

        public string Name
        {
            get { return _name; }
            
        }
        public int Length
        {
            get { return _length; }
          
        }
        public int Width
        {
            get { return _width; }
            
        }
        public int Area
        {
            get { return _area; }
           
        }

        public int Boxes
        {
            get { return _boxes; }
            
        }
        public double Total
        {
            get { return _total; }
            
        }
       public  override string ToString()
        {
            double box = Width * Length / Feet + 1;
            
            return Name.ToString() + " " + Width.ToString() + " X " + Length.ToString() + " " + " " + "needs" + " " + Math.Round(box)+" " + "Boxes";
            

            
        }




    }
}
