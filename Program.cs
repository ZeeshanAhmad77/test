using System;

namespace Relationship
{
    class Program
    {   
        static void Main(string[] args)
        {

            Console.WriteLine("------Enter the Designation------");
            Console.WriteLine(" ' Engineer ' / ' Manager ' / ' Hr '");
            string designation = Console.ReadLine().ToUpper().Trim();

            // initialize the required object
            switch (designation)
            {
                case "ENGINEER":
                    {
                        Employees employe = new Engineer();                    
                        employe.CalculateSalary();
                        employe.ShowSalary();
                        break;
                    }

                case "MANAGER":
                    {
                        Employees employe = new Manager();                      
                        employe.CalculateSalary();
                        employe.ShowSalary();
                        break;

                    }
                case "HR":
                    {
                        Employees employe = new Hr();                    
                        employe.CalculateSalary();
                        employe.ShowSalary();
                        break;

                    }

            }
        }
    }
}

