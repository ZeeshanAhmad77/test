using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public  class Engineer : Employees
    {
        public double AnnualAmount { get; set; }
        //public override void CalculateSalary()
        //{
        //    this.setFuelAllownce(100);
        //    this.setMedicalAllownce(500);
        //    this.setGrossSalary(this.getFuelAllownce() + this.getMedicalAllownce() + this.getBaseSallary());


        //}


        // constrcutor
        public Engineer()
        {
            this.Destination = "Engineer";
            this.BaseSallary = 1500;
            this.FuelAllownce = 0;
            this.MedicalAllownce = 0;
            this.AnnualAmount = 7000;
        
        }
        public override void CalculateSalary() 
        {
            this.GrossSalary = this.BaseSallary + this.FuelAllownce + this.MedicalAllownce + (this.AnnualAmount/12);
        }

        public override void ShowSalary()
        {
            Console.WriteLine("------SALARY Calculator------");
            Console.WriteLine($"The Designation of the Employee is : {Destination}");
            Console.WriteLine($"The Base Salary of the Employee is : {BaseSallary}");
            Console.WriteLine($"The Fuel Allownce of the Employee is : {FuelAllownce}");
            Console.WriteLine($"The Medical Allownce of the Employee is : {MedicalAllownce}");
            Console.WriteLine($"The Anuual amount given to  the Employee is : {AnnualAmount}");
            Console.WriteLine($"The gross sallary of the Employee is : {GrossSalary}");
        }
    }
}
