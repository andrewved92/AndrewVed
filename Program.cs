using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Brand brand = new Brand() { Name = "BMW", Age = 1992 };
            Model model = new Model() { Name = "e34", Age = 1992 };
            Country country = new Country() { Name = "Germany", Age = 1992 };
            
            Brand[] brands = new Brand[] { brand, model, country };
            
            foreach(var item in brands)
            {
                item.Display();

            }
            }
        }
    }

