using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public class Hr : Employees
    {
        public double SumOfAllowancesPercentage { get; set; }

        public Hr()
        {
            this.Destination = "Hr";
            this.BaseSallary = 1500;
            this.FuelAllownce = 150;
            this.MedicalAllownce = 800;
            this.SumOfAllowancesPercentage = 10;

        }
        public override void CalculateSalary()
        {
            double salaryAmount = (this.BaseSallary + this.FuelAllownce + this.MedicalAllownce);
            this.GrossSalary = salaryAmount + (salaryAmount * SumOfAllowancesPercentage / 100);
        }

        public override void ShowSalary()
        {
            Console.WriteLine("------SALARY Calculator------");
            Console.WriteLine($"The Designation of the Employee is : {Destination}");
            Console.WriteLine($"The Base Salary of the Employee is : {BaseSallary}");
            Console.WriteLine($"The Fuel Allownce of the Employee is : {FuelAllownce}");
            Console.WriteLine($"The Medical Allownce of the Employee is : {MedicalAllownce}");
            Console.WriteLine($"The Sum of allownaces percentage  is : {SumOfAllowancesPercentage} %");
            Console.WriteLine($"The gross sallary of the Employee is : {GrossSalary}");
        }

    }
}
