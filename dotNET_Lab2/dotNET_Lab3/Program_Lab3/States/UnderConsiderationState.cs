using System;

namespace Program_Lab3.States
{
    public class UnderConsiderationState : IState
    {
        private readonly Grant _grant;

        public UnderConsiderationState(Grant grant)
        {
            _grant = grant;
        }

        public void NextState()
        {
            Random rnd = new Random();
            if (rnd.Next(2) == 0)
            {
                _grant.SetState(_grant.Rejected);
            }
            else
            {
                _grant.SetState(_grant.Confirmed);
            }
            Console.Clear();
            _grant.ShowState();
        }

        public void ShowState()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nYour request are under consideration.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetMoney()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nDon't hurry up! It is only under consideration state.");
            Console.ForegroundColor = ConsoleColor.Black;
        }

        public void GetRequestAmount()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\n25 requests are under consideration.");
            Console.ForegroundColor = ConsoleColor.Black;
        }
    }
}