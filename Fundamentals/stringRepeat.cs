namespace Fundamentals
{
    public class stringRepeat
    {
        /// <summary>
        /// Write a function that accepts an integer n and a string s as parameters, 
        /// and returns a string of s repeated exactly n times.
        /// </summary>
        /// <param name="n"></param>
        /// <param name="s"></param>
        /// <returns></returns>
        public static string RepeatStr(int n, string s)
        {
            return string.Concat(Enumerable.Repeat(s, n));
            //6, "I"     -> "IIIIII"
            //5, "Hello" -> "HelloHelloHelloHelloHello"
        }
    }
}
