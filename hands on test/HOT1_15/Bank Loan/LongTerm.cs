using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan
{
    internal class LongTerm 
    {
        const double PAY = 200;
        const double INTEREST = 0.05;

        string _name;
        string _type;
        double _balance;
        public LongTerm(string name, string type, double balance)
        {
            _name = name;
            _type = type;
            _balance = balance;
        }
        public string name
        {
            get { return _name; }
        }
        public string type
        {
            get { return _type; }
        }
        public double balance
        {
            get { return _balance; }
        }
        public double MakePayment()
        {
           return PAY;
        }
        public double ApplyInterest()
        {
            return INTEREST;
        }
    }
}
