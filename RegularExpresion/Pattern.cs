using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace RegularExpresion
{
    public class Pattern
    {
        public string ValidateUserEntry(string inputs, string pattern)
        {
            if (Regex.IsMatch(inputs, pattern))
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
    }

}