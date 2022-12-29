using System;

namespace ConsoleApplication
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("hello everyone");
			GreetWhite();
			GreetBlack();
        }

        private static void GreetWhite()
        {
            Console.WriteLine("hello white");
        }

		private static void GreetBlack()
        {
            Console.WriteLine("hello black");
        }
    }
}