using System;

namespace BranchWorkflow5
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number: ");
            int a = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i <= a; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
