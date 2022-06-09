using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class removeStringSpaces
    {
        /// <summary>
        /// Simple, remove the spaces from the string, then return the resultant string.
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>

        public static string NoSpace(string input)
        {
            return input.Replace(" ", "");
        }
    }
}
