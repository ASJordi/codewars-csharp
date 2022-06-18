using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class twoToOne
    {
        /// <summary>
        /// Take 2 strings s1 and s2 including only letters from a to z. 
        /// Return a new sorted string, the longest possible, 
        /// containing distinct letters - each taken only once - coming from s1 or s2.
        /// </summary>
        /// <param name="s1"></param>
        /// <param name="s2"></param>
        /// <returns></returns>
        public static string Longest(string s1, string s2)
        {
            string str = s1 + s2;

            List<string> unsortedList = new List<string>();
            foreach (var item in str)
            {
                unsortedList.Add(item.ToString());
            }

            List<string> orderList = unsortedList.Distinct().OrderBy(letter => letter).ToList();

            return string.Join("", orderList);
            //return string.Concat((s1 + s2).Distinct().OrderBy(c => c));
        }
    }
}
