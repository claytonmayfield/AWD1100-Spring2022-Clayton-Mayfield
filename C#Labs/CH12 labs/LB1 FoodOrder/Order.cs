using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB1_FoodOrder
{
    internal class Order
    {
        private string _name;
        private string _sundae;
        private string _soda;
        private double _price;
        

        public Order(string name, string sundae, string soda, double price)
        {
            _name = name;
            _sundae = sundae;
            _soda = soda;
            _price = price;

        }
        public Order(string name)
        {
            _name = name;
            

        }



        public string Name
        {
           get { return _name; }
           set { _name = value; }
        }
        public string Sundae
        {
            get { return _sundae; }
            set { _sundae = value; }
        }
        public string Soda
        {
            get { return _soda; }
            set { _soda = value; }
        }
        public double Price
        {
           get { return _price; }
            set { _price = value; }
        }
        public override string ToString()
        {
            return (Name + Sundae + Soda);
        }

    }
}
