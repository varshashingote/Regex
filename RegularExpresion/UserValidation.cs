﻿using System;
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
        public const string EMAIL_REGEX = "^[a-z A-Z0-9-](?:\\.[a-z A-Z 0-9_+-]+)*[@][a-zA-Z0-9]+[?:\\.[a-zA-Z0-9]+)*$";
        public const string MOBILENUMBER_REGEX = "^[0-9]+[\\s]+[0-9]{10}$";
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
    }
}
