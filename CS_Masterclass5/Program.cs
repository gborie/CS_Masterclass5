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
            int lentghOfText = 0;
            string wholeText = "";

            do
            {
                Console.WriteLine("Please enter the name of a friend");
                string nameOfAFriend = Console.ReadLine();
                int currentLentgh = nameOfAFriend.Length;
                lentghOfText += currentLentgh;
                wholeText += nameOfAFriend;
            }
            while (lentghOfText < 20);

            Console.WriteLine("Thanksm that was enough " + wholeText);
            Console.Read();
        }
    }
}
