using System;

namespace Prime_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1, num2, currentNum, devisor, sum;

            Console.WriteLine("Enter the first number");
            num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the second number");
            num2 = int.Parse(Console.ReadLine());

            for (currentNum = num1; currentNum <= num2; currentNum++)
            {
                sum = 0;

                for (devisor = 1; devisor <= currentNum; devisor++)
                {
                    if (currentNum%devisor == 0)
                    {
                        sum++;
                    }
                }

                if (sum == 2)
                {
                    Console.WriteLine(currentNum);
                }
            }
        }
    }
}
