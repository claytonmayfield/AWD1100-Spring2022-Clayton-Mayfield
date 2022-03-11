using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Letters
{
    public class Letter
    {
        public double LETTERSENDPRICE = 0.50;
        //instance variables
        protected string _recipient;
        protected DateTime _sentDate;
        //constructor 
        public Letter (string recipient, DateTime sentDate)
        {
            _recipient = recipient;
            _sentDate = sentDate;
        }
            // methods 
            public string Recipient { get { return _recipient; } }
            public DateTime sentDate { get { return _sentDate; } } 

            public virtual double price { get { return LETTERSENDPRICE; } }
        public override string ToString()
        {
            return sentDate.ToString("ddMMyyyy") + ", " + Recipient + "," + LETTERSENDPRICE.ToString("c");
        }

    }
}
