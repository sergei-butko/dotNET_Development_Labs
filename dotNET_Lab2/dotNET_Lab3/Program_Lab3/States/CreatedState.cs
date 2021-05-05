using System;

namespace Program_Lab3.States
{
    public class CreatedState : IState
    {
        private readonly Grant _grant;

        public CreatedState(Grant grant)
        {
            _grant = grant;
        }

        public void NextState()
        {
            _grant.SetState(_grant.UnderConsideration);
            Console.Clear();
            _grant.ShowState();
        }
        
        public void ShowState()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYour request was created.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nDon't hurry up! It is only created state.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n27 requests was created.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}