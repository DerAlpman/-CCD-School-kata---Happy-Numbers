using System;

namespace HappyNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                foreach (var item in HappyNumberChecker.GetHappyNumbersInRange(10, 20))
                {
                    Console.WriteLine(item);
                }
            }
            catch (StackOverflowException e)
            {
                Console.Write(e.Message);
            }

            Console.ReadKey();
        }
    }
}
