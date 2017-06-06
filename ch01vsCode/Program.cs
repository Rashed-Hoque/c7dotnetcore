using System;
using System.Collections.Generic;

namespace ch01vsCode
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!..Beautiful VSCode, Welcome to .NET Core");

            var actions = new List<Action>();
            for(var i=0; i<5; i++)
            {
                actions.Add(()=>System.Console.WriteLine(i));
            }

            foreach(var action in actions)
            {
                action.Invoke();
            }

        }
    }
}
