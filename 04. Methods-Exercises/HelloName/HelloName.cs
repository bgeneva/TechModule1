using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloName
{
    class HelloName
    {
        static void Main(string[] args)
        {
            string strName = Console.ReadLine();
            Console.WriteLine(Hello(strName));

        }

        static string Hello(string name)
        {
            return "Hello, " + name + "!"; 
        }
    }

  
}
