using System;

namespace Program_Lab3.States
{
    public class ConfirmedState : IState
    {
        private readonly Grant _grant;

        public ConfirmedState(Grant grant)
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
            Console.WriteLine("\nYour request was confirmed.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nCongratulations! You can take your money.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n7 requests was confirmed.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}