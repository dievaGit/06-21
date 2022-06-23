using System;
using System.Collections;

namespace ValidString
{
    public class ValidString
    {
        static void Main(string[] args)
        {
            string S = "";

            Console.WriteLine("Validating String");
            Console.WriteLine("Write the string:");
            
            S = Console.ReadLine();
            Console.WriteLine(ValidatingString(S));
            Console.WriteLine("Finish");
        }

        public static String ValidatingString(string initial)
        {
            Stack<char> parentisis = new Stack<char>();

            foreach (var i in initial)
            {
                if (i == ')')
                {
                    if (parentisis.Count != 0)
                        parentisis.Pop();
                    else
                    {
                        initial = initial.Trim(i);
                    }                       
                }
                else if (i == '(')
                    parentisis.Push(i);
            }

            if (parentisis.Count != 0)
            {
                initial = initial.Trim('(');
            }

            return initial;
        }
    }
}
