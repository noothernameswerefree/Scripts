using System;

namespace CarPG.Core.GitTest
{
    public static class TestProgram
    {

        public static void Main(string[] args)
        {
            Console.WriteLine("Testing");
            Console.WriteLine(Testing());
        }

        public static string Testing()
        {
            return "This is cool!" + " I'm doing code in two places!";
        }
    }
}
