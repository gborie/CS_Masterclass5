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
            int next;
            string input;
            double sum = 0;
            double currentMark = 0;

            do
            {
                Console.WriteLine("Enter mark");
                next = counter + 1;
                Console.WriteLine("entry number " + next);
                input = Console.ReadLine();
        
                if (double.TryParse(input, out currentMark) && currentMark >= 0 && currentMark <= 20)
                {
                    sum += currentMark;
                    counter++;
                    Console.WriteLine();
                    Console.WriteLine("Mark is " + input);
                }
                else if (input == "-1")
                {
                    double average = sum / counter;
                    Console.WriteLine();
                    Console.WriteLine("Average is {0}", average);
                    break;
                }
                else
                {
                    Console.WriteLine();
                    Console.WriteLine("Error - Try again");
                    continue;
                }
            }
            while (true);

            Console.Read();

        }
    }
}
