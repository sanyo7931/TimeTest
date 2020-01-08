using System;
using System.Text.RegularExpressions;

namespace TimeTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入24時制時間: ");
            string militaryTime = Console.ReadLine();

            Regex regex = new Regex(@"^([0-1][0-9]|[2][0-3])\:[0-5][0-9]$");
            bool result = regex.IsMatch(militaryTime);
            try
            {
                if (result)
                {
                    Console.WriteLine(militaryTime);
                }
                else
                {
                    Console.WriteLine("Error");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
            Console.ReadKey();
        }
    }
}
