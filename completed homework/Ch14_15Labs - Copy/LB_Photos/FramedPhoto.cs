using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Photos
{
    public class FramedPhoto : Photo
    {
        public enum Material
        {
            PINE   = 0,
            OAK    = 1,
            STEEL  = 2,
            SILVER = 3,
            GOLD   = 4
        }
        public enum Style
        {
            SIMPLE = 0,
            MODERN = 1,
            ANTIQUE = 2,
            VINTAGE = 3,
            ECLECTIC = 4
        }
        protected Material _theMaterial;
        protected Style _theStyle;
        //constructor
        public FramedPhoto(double width, double height, Material theMaterial, Style theStyle):base (width,height)
        {
            this._theMaterial = theMaterial;
            this._theStyle    = theStyle;
        }
        public Material theMaterial
        { 
            get { return _theMaterial; } 
            set { _theMaterial = value; }

        }
        public Style theStyle
        {
            get { return _theStyle; }
            set { _theStyle = value; }
        }
        public override string ToString()
        {
            return base.ToString() + " framed " + _theMaterial.ToString() + " " + _theStyle.ToString();
        }
    }
}
