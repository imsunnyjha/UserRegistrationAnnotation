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
            UserRegistration user = new UserRegistration();

            user.firstName = "Sunny";
            user.lastName = "Jha";
            user.phoneNumber = "+919876543210";
            user.emailAddress = "abc.xyz@gmail.com";
            user.password = "VsCode@2019";

            ValidationContext validationContext = new ValidationContext(user, null, null);
            List<ValidationResult> results = new List<ValidationResult>();

            bool valid = Validator.TryValidateObject(user, validationContext, results, true);

            if (!valid)
            {
                foreach (ValidationResult result in results)
                {
                    Console.WriteLine("Method name : " + result.MemberNames.First());
                    Console.WriteLine("Error name : " + result.ErrorMessage);
                }
            }
            else
                Console.WriteLine(user.firstName + " " + user.lastName + " " + user.phoneNumber + " " + user.emailAddress + " " + user.password);

            Console.WriteLine("\nPress any key to exit..");
            Console.ReadKey();
        }
    }
}

    

