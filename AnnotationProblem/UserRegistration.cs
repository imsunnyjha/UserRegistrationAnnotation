using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace AnnotationProblem
{
    class UserRegistration
    {
        
        [RegularExpression("^[A-Z][a-z]+$")]
        [StringLength(20,MinimumLength =3, ErrorMessage = "Minimum 3 Letters must be present in name!")]
        public string firstName { get; set; }


        [RegularExpression("^[A-Z][a-z]+$")]
        [StringLength(20, MinimumLength = 3, ErrorMessage = "Minimum 3 Letters must be present in name!")]
        public string lastName { get; set; }

        [RegularExpression("^[+][1-9][0-9]+[1-9][0-9]{9}$")]
        [DataType(DataType.PhoneNumber)]
        [StringLength(13, MinimumLength = 10, ErrorMessage = "Proper format should be present in phone number!")]
        [Phone]
        public string phoneNumber { get; set; }

        [DataType(DataType.EmailAddress,ErrorMessage ="Email should be in proper format!")]
        [EmailAddress]
        public string emailAddress { get; set; }

        [DataType(DataType.Password)]
        [StringLength(32,MinimumLength = 8, ErrorMessage = "Proper format should be present in password!")]
        [PasswordPropertyText]
        public string password { get; set; }
    }
}