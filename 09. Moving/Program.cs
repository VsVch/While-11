using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Moving
{
    class Program
    {
        static void Main(string[] args)
        {

            int w = int.Parse(Console.ReadLine());
            int h = int.Parse(Console.ReadLine());
            int H = int.Parse(Console.ReadLine());

            int place = w * h * H;

            int sum = 0;

            string input = Console.ReadLine();

            while (input != "Done")
            {
                int num = int.Parse(input);
                sum += num;

                if (place < sum)
                {
                    int d = sum - place;
                    Console.WriteLine($"No more free space! You need {d} Cubic meters more.");
                    break;

                }

               

                input = Console.ReadLine();


                if (input == "Done")
                {
                    Console.WriteLine($"{ place - sum} Cubic meters left.");
                }

            }


        }
    }
}