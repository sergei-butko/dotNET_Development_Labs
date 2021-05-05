using System;

namespace Program_Lab3.States
{
    public class WithdrawnState : IState
    {
        private readonly Grant _grant;

        public WithdrawnState(Grant grant)
        {
            _grant = grant;
        }

        public void NextState()
        {
            Console.Clear();
            _grant.ShowState();
        }

        public void ShowState()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYour request was withdrawn.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nSorry, you withdrew request.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n3 requests was withdrawn.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}