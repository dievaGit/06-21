using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ValidString
{
    public static class ValidatingString
    {
        public static String StringValidating(string initial)
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
