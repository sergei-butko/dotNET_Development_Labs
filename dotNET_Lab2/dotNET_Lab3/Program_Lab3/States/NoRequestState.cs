using System;

namespace Program_Lab3.States
{
    public class NoRequestState : IState
    {
        private readonly Grant _grant;

        public NoRequestState(Grant grant)
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
            Console.WriteLine("\nThere is no request.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nSorry, there is no request.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nThere is no information");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}