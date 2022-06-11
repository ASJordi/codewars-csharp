using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class stringEndsWith
    {
        /// <summary>
        /// Complete the solution so that it returns true if the first argument(string) 
        /// passed in ends with the 2nd argument (also a string).
        /// Examples
        /// solution('abc', 'bc') returns true
        /// solution('abc', 'd') returns false
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ending"></param>
        /// <returns></returns>
        /// 
        public static bool endsWith(string str, string ending)
        {
            if (str.EndsWith(ending))
                return true;
            else
                return false;
            //return str.EndsWith(ending);
        }
    }
}
