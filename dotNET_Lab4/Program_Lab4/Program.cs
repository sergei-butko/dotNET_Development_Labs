using System;
using System.Collections.Generic;
using System.Linq;

namespace Program_Lab4
{
    static class Program
    {
        static void Main(string[] args)
        {
            List<Plane> planes = new List<Plane>
            {
                new Plane
                {
                    Type = "Airliner",
                    Name = "de Havilland DH.106 Comet",
                    LoadCapacity = 73482,
                    FlightRange = 4900,
                    Wingspan = 35.05,
                    CompanyCode = 914385
                },
                new Plane
                {
                    Type = "Airliner",
                    Name = "A300 B2",
                    LoadCapacity = 152000,
                    FlightRange = 4300,
                    Wingspan = 44.84,
                    CompanyCode = 185246
                },
                new Plane
                {
                    Type = "Cargo Aircraft",
                    Name = "CASA C-295",
                    LoadCapacity = 23200,
                    FlightRange = 3700,
                    Wingspan = 25.81,
                    CompanyCode = 185246
                },
                new Plane
                {
                    Type = "Mail Plane",
                    Name = "Cessna 208A Caravan",
                    LoadCapacity = 3969,
                    FlightRange = 1797,
                    Wingspan = 15.88,
                    CompanyCode = 914385
                }
            };
            List<Helicopter> helicopters = new List<Helicopter>
            {
                new Helicopter
                {
                    Type = "Multipurpose Helicopter",
                    Name = "Ka-226",
                    LoadCapacity = 3400,
                    MaxHeight = 3700,
                    FlightRange = 600,
                    CompanyCode = 914385
                },
                new Helicopter
                {
                    Type = "Civilian Helicopter",
                    Name = "Aerospatiale AS 532",
                    LoadCapacity = 4500,
                    MaxHeight = 2800,
                    FlightRange = 618,
                    CompanyCode = 914385
                },
                new Helicopter
                {
                    Type = "Aerial Сrane",
                    Name = "Sikorsky CH-54 Tarche",
                    LoadCapacity = 10051,
                    MaxHeight = 3740,
                    FlightRange = 370,
                    CompanyCode = 185246
                }
            };
            List<Airline> airlines = new List<Airline>
            {
                new Airline
                {
                    Name = "EasyJet",
                    OfficeLocation = "London, UK",
                    FormationDate = "March, 1995",
                    CompanyCode = 914385
                },
                new Airline
                {
                    Name = "Air Cargo Carriers",
                    OfficeLocation = "Milwaukee, Wisconsin, USA",
                    FormationDate = "1986",
                    CompanyCode = 185246
                }
            };

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----- Request results -----");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n1. Show all planes:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAllPlanes(planes);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n2. Show all helicopters sorted by name:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAllSortedHelicopters(helicopters);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n3. Show planes and helicopters with load capacity over 10 tonnes:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAndHelicoptersOverLoadCapacity(planes, helicopters, 10000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n4. Show planes and helicopters of EasyJet with load capacity less than 5 tonnes:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAndHelicoptersOfEasyJet(planes, helicopters, 914385, 5000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n5. Show planes that are airliners:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAirliners(planes, airlines, "Airliner");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n6. Show planes with flight range from 2000 to 5000 km by flight range:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesByFlightRange(planes, 20000, 80000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n7. Show Min, Max and Avg height of EasyJet helicopters:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetHelicoptersOfEasyJetWithMaxHeight(helicopters, airlines, "EasyJet");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n8. Show planes grouped by Airline:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetGroupedPlanes(planes);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n9. Show all planes sorted by wingspan:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAllSortedPlanes(planes);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n10. Show airlines with office located in UK:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAirlinesOfUk(airlines);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n11. Show helicopters of airline with company code 185246:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetHelicoptersOfAirCargoCarriers(helicopters, airlines, 185246);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n12. Show helicopters with max height over 3.5 km or flight range over 500 km:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetHelicoptersByMaxHeightOrFlightRange(helicopters);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n13. Show name and type of plane with company name and office location:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAndAirlines(planes, airlines);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n14. Show airlines with planes and helicopters with flight range over 600 km:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAirlinesWithFlightRangeVehicle(planes, helicopters, airlines, 600);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n15. Show airline name and office location with formation date in 1986:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAirlinesOf1986(airlines, "1986");

            Console.ReadKey();
        }

        static void GetAllPlanes(List<Plane> planes)
        {
            var result = from p in planes select p;
            foreach (var row in result)
                Console.WriteLine(row.ToString());
            // Console.WriteLine("\nAlso:\n");
            // var result2 = planes.Select(row => row);
            // foreach (var row in result2)
            //     Console.WriteLine(row.ToString());
        }

        static void GetAllSortedHelicopters(List<Helicopter> helicopters)
        {
            var result = from h in helicopters
                orderby h.Name
                select h.Name;
            foreach (var row in result)
                Console.WriteLine(row);
            // Console.WriteLine("\nAlso:\n");
            // var result2 = helicopters.OrderBy(h => h.Name);
            // foreach (var row in result2)
            //     Console.WriteLine(row.Name.ToString());
        }

        static void GetPlanesAndHelicoptersOverLoadCapacity(List<Plane> planes,
            List<Helicopter> helicopters, double capacity)
        {
            var result1 = from p in planes
                where p.LoadCapacity > capacity
                select new {p.Name, p.LoadCapacity};
            var result2 = from h in helicopters
                where h.LoadCapacity > capacity
                select new {h.Name, h.LoadCapacity};
            foreach (var row in result1)
                Console.WriteLine(row.ToString());
            foreach (var row in result2)
                Console.WriteLine(row.ToString());
            // Console.WriteLine("Also:");
            // var result3 = planes.Where(h => h.LoadCapacity > capacity);
            // var result4 = helicopters.Where(h => h.LoadCapacity > capacity);
            // foreach (var row in result3)
            //     Console.WriteLine(row.ToString());
            // foreach (var row in result4)
            //     Console.WriteLine(row.ToString());
        }

        static void GetPlanesAndHelicoptersOfEasyJet(List<Plane> planes,
            List<Helicopter> helicopters, int code, int capacity)
        {
            var result1 = from p in planes
                where p.CompanyCode == code && p.LoadCapacity < capacity
                select new {p.Name, p.LoadCapacity};
            var result2 = from h in helicopters
                where h.CompanyCode == code && h.LoadCapacity < capacity
                select new {h.Name, h.LoadCapacity};
            foreach (var row in result1)
                Console.WriteLine(row);
            foreach (var row in result2)
                Console.WriteLine(row);
            // Console.WriteLine("Also:");
            // var result3 = planes.Where(p => (p.CompanyCode == code 
            //                                  && p.LoadCapacity < capacity)).Select(p => p.Name);
            // var result4 = helicopters.Where(h => (h.CompanyCode == code 
            //                                  && h.LoadCapacity < capacity)).Select(h => h.Name);
            // foreach (var row in result3)
            //     Console.WriteLine(row);
            // foreach (var row in result4)
            //     Console.WriteLine(row);
        }

        static void GetPlanesAirliners(List<Plane> planes, List<Airline> airlines, string type)
        {
            var result = from p in planes
                join a in airlines on p.CompanyCode equals a.CompanyCode
                where p.Type == type
                select new {Plane = p.Name, p.Type, Company = a.Name};
            foreach (var row in result)
                Console.WriteLine(row);
        }

        static void GetPlanesByFlightRange(List<Plane> planes, int minRan, int maxRan)
        {
            var result = from p in planes
                where p.LoadCapacity > minRan && p.LoadCapacity < maxRan
                select new {p.Name, p.LoadCapacity};
            Console.WriteLine("Total number of planes: " + result.Count());
            // Console.WriteLine("Also:");
            // int result2 = planes.Count(p => (p.LoadCapacity > minRan && p.LoadCapacity < maxRan));
            // Console.WriteLine("Total number of planes: " + result2);
        }

        static void GetHelicoptersOfEasyJetWithMaxHeight(List<Helicopter> helicopters,
            List<Airline> airlines, string name)
        {
            var result = from h in helicopters
                join a in airlines on h.CompanyCode equals a.CompanyCode
                where a.Name == name
                select h.MaxHeight;
            Console.WriteLine("Minimal {0}, maximal {1} and average {2}",
                result.Min(), result.Max(), result.Average());
            // Console.WriteLine("Also:");
            // var result2 = helicopters.Join(airlines,
            //     h => h.CompanyCode,
            //     a => a.CompanyCode,
            //     (h, a) => h.MaxHeight);
            // Console.WriteLine("Minimal {0}, maximal {1} and average {2}",
            //     result2.Min(), result2.Max(), result2.Average());
        }

        static void GetGroupedPlanes(List<Plane> planes)
        {
            var result = from p in planes
                group p by p.CompanyCode;
            foreach (var group in result)
            {
                Console.WriteLine("Airline: " + group.Key);
                foreach (var row in group)
                    Console.WriteLine("\t" + row.Name);
            }
            // Console.WriteLine("Also:");
            // var result2 = planes.GroupBy(p => p.CompanyCode);
            // foreach (var group in result2)
            // {
            //     Console.WriteLine("Airline: " + group.Key);
            //     foreach (var row in group)
            //         Console.WriteLine("\t" + row.Name);
            // }
        }

        static void GetAllSortedPlanes(List<Plane> planes)
        {
            var result = planes.OrderBy(h => h.Wingspan);
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }

        static void GetAirlinesOfUk(List<Airline> airlines)
        {
            var result = airlines.Where(h => h.OfficeLocation.Contains("UK"));
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }

        static void GetHelicoptersOfAirCargoCarriers(List<Helicopter> helicopters, List<Airline> airlines, int code)
        {
            var result = helicopters.Where(h => h.CompanyCode == code)
                .Join(airlines,
                    h => h.CompanyCode,
                    a => a.CompanyCode,
                    (h, a) => new {Company = a.Name, h.Type, Helicopter = h.Name});
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }

        static void GetHelicoptersByMaxHeightOrFlightRange(List<Helicopter> helicopters)
        {
            var result = helicopters.Where(h => (h.MaxHeight > 3500 || h.FlightRange > 600));
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }

        static void GetPlanesAndAirlines(List<Plane> planes, List<Airline> airlines)
        {
            var result = from p in planes
                join a in airlines on p.CompanyCode equals a.CompanyCode
                select new {Plane = p.Name, p.Type, Company = a.Name, a.OfficeLocation};
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }

        static void GetAirlinesWithFlightRangeVehicle(
            List<Plane> planes, List<Helicopter> helicopters, List<Airline> airlines, int range)
        {
            var result1 = from a in airlines
                join p in planes on a.CompanyCode equals p.CompanyCode
                where p.FlightRange > range
                select new {Company = a.Name, p.Type, Plane = p.Name};
            var result2 = from a in airlines
                join h in helicopters on a.CompanyCode equals h.CompanyCode
                where h.FlightRange > range
                select new {Company = a.Name, h.Type, Helicopter = h.Name};
            foreach (var row in result1)
                Console.WriteLine(row.ToString());
            foreach (var row in result2)
                Console.WriteLine(row.ToString());
        }

        static void GetAirlinesOf1986(List<Airline> airlines, string date)
        {
            var result = airlines.Select(a => new
            {
                a.Name, a.OfficeLocation,
                a.FormationDate
            }).Where(a => a.FormationDate == date);
            foreach (var row in result)
                Console.WriteLine(row.ToString());
        }
    }
}

/*   ------ Варіант №14: ------
 Розробити структуру даних для зберігання інформації про літаки. 
 Для об'єктів зберігається наступна інформація: 
 Літак - тип літака, вантажопідйомність, максимальна 
 дальність, розмах крил, шифр компанії; 
 Вертоліт - тип вертольоту, вантажопідйомність, максимальна 
 висота, дальність польоту, шифр компанії; 
 авіакомпанія - назва, місце розташування офісу, дата утворення фірми, шифр компанії.
*/