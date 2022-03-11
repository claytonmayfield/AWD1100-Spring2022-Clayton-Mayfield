using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_FoodOrder
{
    internal class Soda : Order
    {

        public enum sodaFlavor
        {
            NONE,
            LIME,
            PEACH,
            MANGO
        }
        const double BASEPRICE = 1.75;
        const double FLAVORPRICE = 0.15;

        sodaFlavor _theSodaFlavor;
        private double _price;
        public Soda (string name, string sundae, string soda, double price, sodaFlavor sodaflavor): base (name,sundae,soda,price)
        {
           this._theSodaFlavor = sodaflavor;

        }
        public sodaFlavor theSodaFlavor
        {
            get { return _theSodaFlavor; }
            set { _theSodaFlavor = value;}

        }
        public double sodaPrice
        {
            get { return _price; }
            set { _price = value;}
        }
        public override string ToString()
        {
            return base.ToString() + "soda" + _theSodaFlavor.ToString() + BASEPRICE;
        }
    }
}
