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
                throw new CustomExceptions("Input is having null", CustomExceptions.ExceptionTypes.NULL_INPUT);
            }
        }
    }
}



    