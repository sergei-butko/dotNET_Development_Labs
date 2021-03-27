using System;
using Library_Lab2;

namespace Program_Lab2
{
    static class Program
    {

        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            Console.WriteLine("\n------------ Welcome to Home Cinema! -------------");

            var widescreenTv = new WidescreenTv();
            var dvdPlayer = new DvdPlayer();
            var avReceiver = new AvReceiver();

            var homeCinema = new HomeCinema(widescreenTv, dvdPlayer, avReceiver);

            bool alive = true;
            while (alive)
            {
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("\n---------------- Choose TV Mode ------------------");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1. Standard\t2. Cinema\t3. Сlassical Music\n4. Sport\t5. Custom\t6. Close Game");
                Console.ForegroundColor = ConsoleColor.Black;

                try
                {
                    Console.Write("Choose What to Do: ");
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n------ Standard Mode ------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            homeCinema.SetStandard();
                            break;
                        case 2:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n-------- Cinema Mode --------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            homeCinema.SetCinema();
                            break;
                        case 3:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n-- Сlassical Music Mode --");
                            Console.ForegroundColor = ConsoleColor.Black;
                            homeCinema.SetСlassicalMusic();
                            break;
                        case 4:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n-------- Sport Mode --------");
                            Console.ForegroundColor = ConsoleColor.Black;
                            homeCinema.SetSport();
                            break;
                        case 5:
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.WriteLine("\n------- Custom Mode -------");
                            CustomMode customMode = new CustomMode();
                            Console.ForegroundColor = ConsoleColor.Black;
                            customMode.Custom(homeCinema);
                            break;
                        case 6:
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
 Реалізувати задачу «Керування домашнім кінотеатром». 
 Домашній кінотеатр може включати наступні компоненти: 
 широкоформатний телевізор, DVD-програвач, ресивер з акустичною 
 системою. Кожен з компонентів має свій інтерфейс управління та 
 ряд налаштувань (наприклад: телевізор – формат відображення, 
 режим яскравості тощо; ресивер – гучність; тощо). 
 Реалізувати загальний інтерфейс керування домашнім кінотеатром, котрий 
 передбачає включення та комплекс налаштувань типових режимів перегляду/
 прослуховування (наприклад, спорт, кінофільми, класична музика тощо) */