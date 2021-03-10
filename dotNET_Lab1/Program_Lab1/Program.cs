using System;
using Library_Lab1;

namespace Program_Lab1
{
    static class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            //Console.BackgroundColor = ConsoleColor.White;
            //Console.Clear();

            Console.WriteLine("\n------- Welcome to Game \"Civilisation\"! -------");

            bool alive = true;
            while (alive)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("\n1. Create Greek Civilization\n2. Create Roman Civilization\n3. Close Game");
                Console.ForegroundColor = ConsoleColor.Black;

                try
                {
                    Console.Write("Choose What to Do: ");
                    int command = Convert.ToInt32(Console.ReadLine());
                    switch (command)
                    {
                        case 1:
                            GreekCivilizationFactory greekCivilizationFactory = new GreekCivilizationFactory();
                            Civilization greekCivilization = new Civilization(greekCivilizationFactory);
                            Citizen[] greekCitizens = greekCivilization.CreateCitizen();
                            Resources[] greekResources = greekCivilization.CreateResources();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nGreek Civilization was Created");
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("\nInhabitants of Ancient Greece:");
                            foreach (Citizen elemCitizen in greekCitizens)
                            {
                                string citizen = elemCitizen.Info();
                                Console.WriteLine(citizen);
                            }

                            Console.WriteLine("\nGreek Civilization has:");
                            foreach (Resources elemResources in greekResources)
                            {
                                string resources = elemResources.Info();
                                Console.WriteLine(resources);
                            }
                            break;
                        case 2:
                            RomanCivilizationFactory romanCivilizationFactory = new RomanCivilizationFactory();
                            Civilization romanCivilization = new Civilization(romanCivilizationFactory);
                            Citizen[] romanCitizens = romanCivilization.CreateCitizen();
                            Resources[] romanResources = romanCivilization.CreateResources();

                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine("\nRoman Civilization was Created");
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("\nInhabitants of Ancient Rome:");
                            foreach (Citizen elemCitizen in romanCitizens)
                            {
                                string citizen = elemCitizen.Info();
                                Console.WriteLine(citizen);
                            }

                            Console.WriteLine("\nRoman Civilization has:");
                            foreach (Resources elemResources in romanResources)
                            {
                                string resources = elemResources.Info();
                                Console.WriteLine(resources);
                            }
                            break;
                        case 3:
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
        }
    }
}

/*   ------ Варіант №14: ------
 Необхідно реалізувати задачу «Гра - цивілізації». 
 У грі беруть участь кілька цивілізацій. 
 У кожній цивілізації представлені індивідууми декількох видів: 
 воїн, робочий, аристократ і ін. 
 Кожна раса володіє фінансовим запасом і деяким набором територій 
 з обов'язково розміщеними на них об'єктами типів: 
 ліси, поля, житло і заводи. 
 Продемонструвати створення різних рас, команд індивідуумів, 
 ініціалізацію територій і зміну складу об'єктів гри. */