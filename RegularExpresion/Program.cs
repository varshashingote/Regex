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
            Console.WriteLine("Enter your choice \n1.NameValidation \n2.LastNameValidation\n3.EmailValidation");
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

                    Console.WriteLine("Enter Email: ");
                    string email = Console.ReadLine();
                    userValidation.ValidationFirstName(email);
                    Console.ReadLine();
                    break;
            









            }
        }

    
    }
}
