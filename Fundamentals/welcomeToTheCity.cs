using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fundamentals
{
    public class welcomeToTheCity
    {
        /// <summary>
        /// Create a method sayHello/say_hello/SayHello that takes as input a name, city, and state 
        /// to welcome a person. Note that name will be an array consisting of one or more values 
        /// that should be joined together with one space between each, and the length of the name array 
        /// in test cases will vary.
        /// Kata.SayHello(new String[]{"John", "Smith"}, "Phoenix", "Arizona")
        /// </summary>
        /// <param name="name"></param>
        /// <param name="city"></param>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string SayHello(string[] name, string city, string state)
        {
            string names = string.Empty;
            foreach (var item in name)
            {
                names += item + " ";
            }
            return String.Format($"Hello, {names.TrimEnd()}! Welcome to {city}, {state}!");
            //return $"Hello, {String.Join(" ", name)}! Welcome to {city}, {state}!";
        }
    }
}
