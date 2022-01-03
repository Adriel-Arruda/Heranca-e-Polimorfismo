using System;

namespace TaxCalculation.Entities
{
    public abstract class Taxpayer
    {
        public string Name { get; protected set; }
        protected double AnnualIncome { get; set; }

        public abstract double TaxPay();

        public Taxpayer(string name, double annualIncome)
        {
            Name = name;
            AnnualIncome = annualIncome;
        }
        
    }
}
