using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_FoodOrder
{
    internal class Sundae : Order
    {
        public enum Toppings
        {
            NONE,
            SPRKINKLES, 
            NUTS,
            CHOCOLATE_SYRUP
        }
        const double BASEPRICE = 4.50;
        const double TOPPINGPRICE = 0.50;


        Toppings _theToppings;
        private int toppingCount;
        private double price;
        public Sundae(string name, string sundae, string soda, Toppings toppings, int toppingcount, double price ): base (name,sundae,soda,price)
        {
            this._theToppings = toppings;
            this.toppingCount = toppingcount;
            this.price = price;

        }
        public Sundae (string name, string sundae, string soad ) : base (name,sundae,soda)
        {
            

        }
        public Toppings theToppings
        {
            get { return this._theToppings; }
            set { this._theToppings = value; }
        } 
        public int toppingcount
        {
            get { return toppingcount; }
            set { toppingcount = value; }
        }
        public double sundaeprice
        {
            get { return price; }
            set { price = value; }
        }
        public override string ToString()
        {
            return base.ToString() + "sundae" + theToppings.ToString() + BASEPRICE;
        }

    }
}
