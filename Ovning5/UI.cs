using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    public class UI : IUI
    {
        public void Print(string message)
        {
            Console.WriteLine(message);
        }

        public string GetInput()
        {
            return Console.ReadLine();
        }


    }
}
