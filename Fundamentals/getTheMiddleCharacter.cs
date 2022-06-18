using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class getTheMiddleCharacter
    {
        /// <summary>
        /// You are going to be given a word. 
        /// Your job is to return the middle character of the word. 
        /// If the word's length is odd, return the middle character. 
        /// If the word's length is even, return the middle 2 characters.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string GetMiddle(string str)
        {
            List<string> list = new List<string>();
            foreach (var item in str)
            {
                list.Add(item.ToString());
            }

            int length = str.Length;
            if ((length % 2) == 0)
                return list[(length / 2) - 1] + list[length / 2];
            else
                return list[length / 2];

            //return s.Length % 2 == 0 ? s.Substring(s.Length / 2 - 1, 2) : s.Substring(s.Length / 2, 1);

        }
    }
}
