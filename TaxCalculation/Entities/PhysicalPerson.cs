using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaxCalculation.Entities
{
    internal class PhysicalPerson : Taxpayer
    {
        public double HealthExpenditures { get; set; }
        public PhysicalPerson(string name, double annualIncome, double healthSpending):base(name, annualIncome) 
        {
            HealthExpenditures = healthSpending;

        }
        public override double TaxPay()
        {
            double income = 0;
            double taxRefound = (HealthExpenditures != 0) ? HealthExpenditures * 0.5 : 0;
            if (AnnualIncome < 20000.00)
            {
                income = AnnualIncome * 0.15 ;
            }
            else
            {
                income = AnnualIncome * 0.25;
            }
            return income - taxRefound;
        }
    }
}
