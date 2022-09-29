using System;

namespace _08._Graduation_pt._2
{
    class Program
    {
        static void Main(string[] args)
        {

            string name = Console.ReadLine();

            int grades = 1;

            double sum = 0.0;
            int cou = 0;

            while (grades <= 12)
            {
                double grade = double.Parse(Console.ReadLine());
                cou++;
                grade += grade;
                double ave = grade / cou;

                if (ave < 4.00)
                {
                    Console.WriteLine($"{name}  has been excluded at {grdes} grade");
                }

                cou++;
                grade += grade;
                double ave = grade / cou;

                Console.WriteLine($"{name}");


            }





        }
    }
}
