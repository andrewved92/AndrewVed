using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public class Country : Brand

    {
        public override void Display()
        {
            Console.WriteLine($"Country {Name}");
        }
    }
}
