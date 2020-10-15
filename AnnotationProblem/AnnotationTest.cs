using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace AnnotationProblem
{
    class AnnotationTest
    {
        public static void Display()
        {
            Console.WriteLine("User Registration Validation>>>>");
            Employee employee = new Employee();

            employee.firstName = "Sunny";
            employee.lastName = "Jha";
            employee.phoneNumber = "+919876543210";
            employee.emailAddress = "abc.xyz@gmail.com";
            employee.password = "VsCode@2019";

            ValidationContext validationContext = new ValidationContext(employee, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(employee, validationContext, results, true);

            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("Method name : " + result.MemberNames.First());
                    Console.WriteLine("Error name : " + result.ErrorMessage);
                }
            }
            else
                Console.WriteLine(employee.firstName + " " + employee.lastName + " " + employee.phoneNumber + " " + employee.emailAddress + " " + employee.password);

            Console.WriteLine("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}

    

