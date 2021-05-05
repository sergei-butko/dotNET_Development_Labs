using System;

namespace Program_Lab3.States
{
    public class RejectedState : IState
    {
        private readonly Grant _grant;

        public RejectedState(Grant grant)
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
            Console.WriteLine("\nYour request was rejected.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nSorry, your request was rejected.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n17 requests was rejected.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}