using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace childbirth
{
    class Program
    {
        static void Main(string[] args)
        {
            uint [] childbirths={1,2,3,4};
            foreach(uint temp in childbirths)
            {
               Console .WriteLine(temp);            
            }
            Console.ReadLine();
        }
    }
}
