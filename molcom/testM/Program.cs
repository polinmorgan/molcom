using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace testM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter any number:"); 
            string input= Console.ReadLine();
            MathString ms = new MathString();
            Console.WriteLine($"Result is: "+ ms.Inc(input));
            Console.ReadLine();
        }
    }
}
