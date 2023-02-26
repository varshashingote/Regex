using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using static RegularExpresion.CustomException;

namespace RegularExpresion
{
    public class Pattern
    {
        public string ValidateUserDetails(string inputs, string pattern)
        {
            try
            {
                if (inputs.Equals(string.Empty))
                {
                    Console.WriteLine("Given input \"Empty\" then\nthrow CustomExceptions");
                    throw new CustomExceptions("Input is having empty", CustomExceptions.ExceptionTypes.EMPTY_INPUT);
                }
                else if (Regex.IsMatch(inputs, pattern))
                {
                    Console.WriteLine("{0}    => Valid", inputs);
                    return "Valid";
                }
                else
                {
                    Console.WriteLine("{0}    => Invalid", inputs);
                    return "Invalid";
                }
            }
            catch (NullReferenceException)
            {
                Console.WriteLine("Given input \"null\" then\nthrow CustomExceptions");
                throw new CustomExceptions("Input is having null", CustomExceptions.ExceptionTypes.NULL_INPUT);
            }
        }
        /// <summary>
        /// UC13- Use Lambda function to validate User Entry
        /// </summary>
        /// <param name="firstname"></param>
        /// <param name="lastname"></param>
        /// <param name="emailId"></param>
        /// <param name="phoneNumber"></param>
        /// <param name="password"></param>
        /// <returns></returns>

        public string firstNamePattern = "^[A-Z]{1}[a-z]{2,}$";//Jyoti
        public string lastNamePattern = "^[A-Z]{1}[a-z]{2,}$";//Rao
        public string emailIdPattern = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$";//abc.xyz@bl.co.in
        public string mobileNumberPattern = "^[1-9]{2}?([ ])[0-9]{10}$";//91 9919819801
        public string passwordRule4Pattern = "^(?=.*?[A-Z])(?=.*?[a-z])(?=.*?[0-9])(?=.*?[#?!@$%^&*-]).{8,}$";//#Jyoti1rAO
        public string ValidateFirstName(string firstname) =>
              Regex.IsMatch(firstname, firstNamePattern) ? "Valid" : "Invalid";
        public string ValidateLastName(string lastname) =>
           Regex.IsMatch(lastname, lastNamePattern) ? "Valid" : "Invalid";
        public string ValidateEmail(string emailId) =>
           Regex.IsMatch(emailId, emailIdPattern) ? "Valid" : "Invalid";
        public string ValidatePhoneNumber(string phoneNumber) =>
           Regex.IsMatch(phoneNumber, mobileNumberPattern) ? "Valid" : "Invalid";
        public string ValidatePassword(string password) =>
            Regex.IsMatch(password, passwordRule4Pattern) ? "Valid" : "Invalid";
    }
}







        