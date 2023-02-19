using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpresion
{
    public class UserValidation
    {
        public const string FIRST_NAME_REGEX = "^[A-Z]{1}[a-zA-Z]{3,}$";
        public const string LAST_NAME_REGEX = "^[A-Z]{1}[a-z A-Z]{3,}$";
        public const string EMAIL_REGEX = @"^([abc]+)(\.[a-z0-9_\+\-]+)?@([bl]+)\.([co]{2,4})(\.[a-z]{2,})?$";
        public const string MOBILENUMBER_REGEX = "^[0-9]+[\\s]+[0-9]{10}$";
        public const string PASSWORD_REGEX = "[a-z,A-Z,0-9]{8,}$"; 
        public const string UPPERCASE_REGEX = "^[A-Z][a-z]{7}$";
        public const string NUMERICPASSWORD_REGEX = "^[a-z0-9A-Z]{8}$";
        public const string SPECIALCHARACCTER_REGEX = "^[a-zA-Z0-9]{4,}(@)$";
        public const string EmailValidation= "^[a-zA-Z0-9]+[.+-_]{0,1}[a-zA-Z0-9]+[@][a-zA-Z]+[.][a-zA-Z]{2,3}([.][a-zA-Z]{2,3}){0,1}$";




        public void ValidationFirstName(string firstname)
        {
            Regex regex = new Regex(FIRST_NAME_REGEX);
            bool result = regex.IsMatch(firstname);
            Console.WriteLine(result);

        }
        public void ValidationLastName(string lastName)
        {
            Regex regex = new Regex(LAST_NAME_REGEX);
            bool result = regex.IsMatch(lastName);
            Console.WriteLine(result);
        }

        public void ValidationEmail(string email)
        {
            Regex regex = new Regex(EMAIL_REGEX);
            bool result = regex.IsMatch(email);
            Console.WriteLine(result);

        }

        public void ValidationPhoneNumber(string phonenumber)
        {
            Regex regex = new Regex(MOBILENUMBER_REGEX);
            bool result = regex.IsMatch(phonenumber);
            Console.WriteLine(result);

        }
       
        public void ValidationPassword(string password)
        {
            Regex regex = new Regex(PASSWORD_REGEX);
            bool result = regex.IsMatch(password);
            Console.WriteLine(result);
        }
        
        public void ValidationUppercase(string Uppercase)
        {
            Regex regex = new Regex(UPPERCASE_REGEX);
            bool result = regex.IsMatch(Uppercase);
            Console.WriteLine(result);
        }
        
        public void ValidationNumericPassword(string numericpassword)
        {
            Regex regex = new Regex(NUMERICPASSWORD_REGEX);
            bool result = regex.IsMatch(numericpassword);
            Console.WriteLine(result);
        }
        public void ValidationSpecialCharacterPassword (string SpecialChar)
        {
            Regex regex = new Regex(SPECIALCHARACCTER_REGEX);
            bool result = regex.IsMatch(SpecialChar);
            Console.WriteLine(result);
        }
        public void ValidationEmailall(String specialemail)
        {
            Regex regex = new Regex(EmailValidation);
            bool result = regex.IsMatch(specialemail);
            Console.WriteLine(result);
        }





    }
}
