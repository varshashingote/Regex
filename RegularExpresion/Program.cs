using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegularExpresion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to User Registration Problems Statement Using REGEX");
            UserValidation userValidation = new UserValidation();
            Console.WriteLine("Enter your choice \n1.NameValidation \n2.LastNameValidation\n3.EmailValidation" +
                "\n4.PhoneNumberValidation \n5.PasswordValidation \n6. AtLeastoneUppercase \n7.AtLEastOneNumeric" +
                "\n8.AtLeastOneSpecialChar \n9 SpecialEmail");
            int choice = Convert.ToInt32(Console.ReadLine());

            switch (choice)
            {
                case 1:

                    Console.WriteLine("Enter The First Name: ");
                    string firstname = Console.ReadLine();
                    userValidation.ValidationFirstName(firstname);
                    Console.ReadLine();
                    break;
                case 2:
                    Console.WriteLine("Enter The Last Name: ");
                    string Lastname = Console.ReadLine();
                    userValidation.ValidationFirstName(Lastname);
                    Console.ReadLine();
                    break;
                case 3:
                    Console.WriteLine("Enter The Email: ");
                    string email = Console.ReadLine();
                    userValidation.ValidationEmail(email);
                    Console.ReadLine();
                    break;
                case 4:
                    Console.WriteLine("Enter PhoneNumber: ");
                    string phonenumber = Console.ReadLine();
                    userValidation.ValidationPhoneNumber(phonenumber);
                    Console.ReadLine();
                    break;
                case 5:
                    Console.WriteLine("Enter password 8 characters");
                    string password = Console.ReadLine();
                    userValidation.ValidationPassword(password);
                    Console.ReadLine();
                    break;
                case 6:
                    Console.WriteLine("Enter The Name ");
                    string Uppercase = Console.ReadLine();
                    userValidation.ValidationUppercase(Uppercase);
                    Console.ReadLine();
                    break;
                case 7:

                    Console.WriteLine("Enter The password ");
                    string numericpassword = Console.ReadLine();
                    userValidation.ValidationNumericPassword(numericpassword);
                    Console.ReadLine();
                    break;
                case 8:
                    Console.WriteLine("Enter The password ");
                    string SpecialChar = Console.ReadLine();
                    userValidation.ValidationSpecialCharacterPassword(SpecialChar);
                    Console.ReadLine();
                    break;
                case 9:
                    Console.WriteLine("Enter The Email");
                    string specialemail = Console.ReadLine();
                    userValidation.ValidationEmailall(specialemail);
                    Console.ReadLine();
                    break;







            }
        }

    
    }
}
