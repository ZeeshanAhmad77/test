using System;
using System.Collections.Generic;
using System.Text;

namespace Relationship
{
    public  abstract class Employees
    {
        // Properties

        public string Destination { get; set; }
        public double BaseSallary { get; set; }
        public double FuelAllownce { get; set; }
        public double MedicalAllownce { get; set; }
        public double GrossSalary { get; set; }

        // These are abstract methods and  their bodies will be defined in the child classes
        public abstract void CalculateSalary();
        public abstract void ShowSalary();

    }
}
