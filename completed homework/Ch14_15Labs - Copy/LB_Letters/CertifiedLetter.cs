using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LB_Letters
{
    public class CertifiedLetter : Letter
    {
        public double CERTLETTERSENDPRICE = 0.65;
        //instance variable
        protected string _TrackingNumber;

        //constructor
        public CertifiedLetter(string recipient,DateTime sentDate, string trackingNumber) :base(recipient,sentDate)
        {
            _TrackingNumber = trackingNumber; 
        }

        public string TrackingNumber { get { return _TrackingNumber; } }

        override public double price { get { return CERTLETTERSENDPRICE; } }
        public override string ToString()
        {
            return sentDate.ToString("ddMMyyyy") + ", " + Recipient + "," + CERTLETTERSENDPRICE.ToString("c") + "," + TrackingNumber;
        }
    }
}
