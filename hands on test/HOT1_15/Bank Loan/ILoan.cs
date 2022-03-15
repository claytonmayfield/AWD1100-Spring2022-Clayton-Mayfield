using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bank_Loan
{
    internal interface ILoan
    {
        string name { get; set; }
        string type { get; set; }
        double balance { get; set; }
        void MakePayment();
        void ApplyInterest();

    }
}
