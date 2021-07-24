using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
     public class Brand
    {
        public String Name { get; set; }
       
        public int Age { get; set; }
        public virtual void Display()

        {
            Console.WriteLine($"Name - { Name}");
            Console.WriteLine($"Age -  { Age}");



        }
    }
}
