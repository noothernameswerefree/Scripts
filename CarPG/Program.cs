using System;

namespace CarPG.Core.GitTest
{
    public static class TestProgram
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            Console.WriteLine(Testing());
            Console.WriteLine("God I hope this got rid of the exe folder...");
        }

        public static string Testing()
        {
            return "This is cool!" + " I'm doing code in two places!";
        }
    }
}
