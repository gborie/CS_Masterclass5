using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS_Masterclass5
{
    class Program
    {
        static void Main(string[] args)
        {
            for(int counter = 0; counter < 50; counter+=5)
            {
                Console.WriteLine(counter);
            }
            Console.WriteLine("For Loop is done");
            Console.Read();
        }
    }
}
