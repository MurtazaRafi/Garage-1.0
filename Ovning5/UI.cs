using System;
using System.Collections.Generic;
using System.Text;

namespace Ovning5
{
    class UI
    {
        internal void Print(string message)
        {
            Console.WriteLine(message);
        }

        internal string GetInput()
        {
            return Console.ReadLine();
        }

        
    }
}
