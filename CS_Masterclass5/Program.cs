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
            int counter = 0;
            do
            {
                Console.WriteLine(counter);
                counter++;
            }
            while (counter < 10);

            Console.Read();
        }
    }
}
