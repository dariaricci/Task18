using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task18
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "([]{})[]";
            Stack<char> stack = new Stack<char>();
            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] == '(')
                    stack.Push(')');

                if ((s[i] == '{'))
                    stack.Push('}');

                if ((s[i] == '['))
                    stack.Push(']');

                if ((s[i] == ')') && (stack.Peek() == ')'))
                    stack.Pop();
                if ((s[i] == '}') && (stack.Peek() == '}'))
                    stack.Pop();
                if ((s[i] == ']') && (stack.Peek() == ']'))
                    stack.Pop();
            }


                if (stack.Count == 0)
                Console.WriteLine("Скобки расставлены корректно");
            else
                Console.WriteLine("Скобки расставлены некорректно");
            Console.ReadKey();


        }
    }
}
