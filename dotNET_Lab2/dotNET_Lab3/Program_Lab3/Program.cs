using System;

namespace Program_Lab3
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            Console.WriteLine("\n------------ Welcome to Grant Program! -------------");
            var grant = new Grant();

            bool alive = true;
            while (alive)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n---------------- Choose what to do ------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1. Create request\t2. Show status\t\t3. Get money\t4. Next state");
                Console.WriteLine("5. Withdraw request\t6. Show request amount\t7. Close Game");
                Console.ForegroundColor = ConsoleColor.Black;
                
                try
                {
                    Console.Write("Choose What to Do: ");
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            grant.SetState(grant.Created);
                            grant.ShowState();
                            break;
                        case 2:
                            grant.ShowState();
                            break;
                        case 3:
                            grant.GetMoney();
                            break;
                        case 4:
                            grant.NextState();
                            break;
                        case 5:
                            grant.SetState(grant.Withdrawn);
                            grant.ShowState();
                            break;
                        case 6:
                            grant.GetRequestAmount();
                            break;
                        case 7:
                            alive = false;
                            Environment.Exit(0);
                            break;
                        default:
                            throw new Exception("No such command was found!");
                    }
                }
                catch (Exception ex)
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine(ex.Message);
                }
            }

            Console.ReadKey();
        }
    }
}

/*   ------ Варіант №14: ------
 Замовлення на отримання гранту для навчання може 
 перебувати в кількох станах: створений, розглядається,
 відхилений, підтверджений, відкликаний та інше. 
 Визначити логіку зміни станів і розробити модель системи. */