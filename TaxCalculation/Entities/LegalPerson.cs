using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation.Entities
{
    internal class LegalPerson : Taxpayer
    {
        public int NumberOfEmployees { get; set; }
        public LegalPerson(string name, double annualIncome, int numberOfEmployees) : base(name, annualIncome)
        {
            NumberOfEmployees = numberOfEmployees;
        }
        public override double TaxPay()
        {
            double taxPay = (NumberOfEmployees<10)? 0.16 : 0.14;
            return taxPay * AnnualIncome;
        }
    }
}
