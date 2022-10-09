using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public class Manager : Employees
    {

        public double Tax { get; set; }



        public Manager()
        {
            this.Destination = "Manager";
            this.BaseSallary = 1500;
            this.FuelAllownce = 250;
            this.MedicalAllownce =1000;
            this.Tax = 17;

        }
        public override void CalculateSalary()
        {
            double salaryAmount = (this.BaseSallary + this.FuelAllownce + this.MedicalAllownce);
            this.GrossSalary = salaryAmount - (salaryAmount * Tax/100);
        }

        public override void ShowSalary()
        {
            Console.WriteLine("------SALARY Calculator------");
            Console.WriteLine($"The Designation of the Employee is : {Destination}");
            Console.WriteLine($"The Base Salary of the Employee is : {BaseSallary}");
            Console.WriteLine($"The Fuel Allownce of the Employee is : {FuelAllownce}");
            Console.WriteLine($"The Medical Allownce of the Employee is : {MedicalAllownce}");
            Console.WriteLine($"The Tax Percentage deducted  is : {Tax} %");
            Console.WriteLine($"The gross sallary of the Employee is : {GrossSalary}");
        }


    }
}
