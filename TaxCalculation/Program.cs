using System;
using System.Collections.Generic;
using System.Globalization;
using TaxCalculation.Entities;
namespace Ex1
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.Write("Enter the number of taxpayers: ");
            int n = int.Parse(Console.ReadLine());
            List<Taxpayer> list = new List<Taxpayer>();
            for (int i=0;  i< n; i++)
            {
                Console.WriteLine($"Taxpayer #{i+1} data:");
                Console.Write("Individual or Company (i/c): ");
                char type = char.Parse(Console.ReadLine());
                Console.Write("Name: ");
                string name = Console.ReadLine();
                Console.Write("Annual income: ");
                double annualIncome = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                if (type == 'i')
                {
                    Console.Write("Health Expenditures: ");
                    double healthExpenditures = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    PhysicalPerson taxPayer = new PhysicalPerson(name, annualIncome, healthExpenditures);
                    list.Add(taxPayer);
                }
                else
                {
                    Console.Write("Number of Employees: ");
                    int numberOfEmployees = int.Parse((Console.ReadLine()));
                    LegalPerson taxPayer = new LegalPerson(name, annualIncome, numberOfEmployees);
                    list.Add(taxPayer);
                }
            }
            double sum = 0;
            Console.WriteLine("Taxes paid:");
            foreach (Taxpayer taxpayer in list)
            {
                Console.WriteLine(taxpayer.Name + " $ " + taxpayer.TaxPay().ToString("F2", CultureInfo.InvariantCulture));
                sum += taxpayer.TaxPay();
            }
            Console.WriteLine("TOTAL TAXES: $ " + sum.ToString("F2", CultureInfo.InvariantCulture));
          

        }
    }
}