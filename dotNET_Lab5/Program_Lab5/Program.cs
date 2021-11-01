using System;
using System.Linq;
using System.Xml.Linq;

namespace Program_Lab5
{
    static class Program
    {
        static void Main(string[] args)
        {
            XDocument aircraft = new XDocument(new XElement("aircrafts",
                new XElement("planes",
                    new XElement("plane",
                        new XElement("Type", "Airliner"),
                        new XElement("Name", "de Havilland DH.106 Comet"),
                        new XElement("LoadCapacity", "73482"),
                        new XElement("FlightRange", "4900"),
                        new XElement("Wingspan", "35.05"),
                        new XElement("CompanyCode", "914385")),
                    new XElement("plane",
                        new XElement("Type", "Airliner"),
                        new XElement("Name", "A300 B2"),
                        new XElement("LoadCapacity", "152000"),
                        new XElement("FlightRange", "4300"),
                        new XElement("Wingspan", "44.84"),
                        new XElement("CompanyCode", "185246")),
                    new XElement("plane",
                        new XElement("Type", "Cargo Aircraft"),
                        new XElement("Name", "CASA C-295"),
                        new XElement("LoadCapacity", "23200"),
                        new XElement("FlightRange", "3700"),
                        new XElement("Wingspan", "25.81"),
                        new XElement("CompanyCode", "185246")),
                    new XElement("plane",
                        new XElement("Type", "Mail Plane"),
                        new XElement("Name", "Cessna 208A Caravan"),
                        new XElement("LoadCapacity", "3969"),
                        new XElement("FlightRange", "1797"),
                        new XElement("Wingspan", "15.88"),
                        new XElement("CompanyCode", "914385"))
                ),
                new XElement("helicopters",
                    new XElement("helicopter",
                        new XElement("Type", "Multipurpose Helicopter"),
                        new XElement("Name", "Ka-226"),
                        new XElement("LoadCapacity", "3400"),
                        new XElement("MaxHeight", "3700"),
                        new XElement("FlightRange", "600"),
                        new XElement("CompanyCode", "914385")),
                    new XElement("helicopter",
                        new XElement("Type", "Civilian Helicopter"),
                        new XElement("Name", "Aerospatiale AS 532"),
                        new XElement("LoadCapacity", "4500"),
                        new XElement("MaxHeight", "2800"),
                        new XElement("FlightRange", "618"),
                        new XElement("CompanyCode", "914385")),
                    new XElement("helicopter",
                        new XElement("Type", "Aerial Сrane"),
                        new XElement("Name", "Sikorsky CH-54 Tarche"),
                        new XElement("LoadCapacity", "10051"),
                        new XElement("MaxHeight", "3740"),
                        new XElement("FlightRange", "370"),
                        new XElement("CompanyCode", "185246"))
                ),
                new XElement("airlines",
                    new XElement("airline",
                        new XElement("Name", "EasyJet"),
                        new XElement("OfficeLocation", "London, UK"),
                        new XElement("FormationDate", "March, 1995"),
                        new XElement("CompanyCode", "914385")),
                    new XElement("airline",
                        new XElement("Name", "Air Cargo Carriers"),
                        new XElement("OfficeLocation", "Milwaukee, Wisconsin, USA"),
                        new XElement("FormationDate", "1986"),
                        new XElement("CompanyCode", "185246"))
                )));
            aircraft.Save("Aircrafts.xml");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("\n--- XML Document Elements ---");
            Console.ForegroundColor = ConsoleColor.Black;
            ShowCollection(aircraft);

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("\n----- Request results -----");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n1. Show all planes:");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAllPlanes(aircraft);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n2. Show all helicopters sorted by name:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAllSortedHelicopters(aircraft);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n3. Show planes and helicopters with load capacity over 10 tonnes:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAndHelicoptersOverLoadCapacity(aircraft, 10000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n4. Show planes and helicopters of EasyJet with load capacity less than 5 tonnes:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAndHelicoptersOfEasyJet(aircraft, 914385, 5000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n5. Show planes that are airliners:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetPlanesAirliners(aircraft, "Airliner");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n6. Count planes with flight range from 20000 to 80000 km:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            CountPlanesByFlightRange(aircraft, 20000, 80000);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n7. Show Min, Max and Avg height of EasyJet helicopters:\n");
            Console.ForegroundColor = ConsoleColor.Black;
            GetHelicoptersOfEasyJetWithMaxHeight(aircraft, "EasyJet");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n8. Show planes grouped by Airline:");
            Console.ForegroundColor = ConsoleColor.Black;
            GetGroupedPlanes(aircraft);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n9. Show airlines with office located in UK:");
            Console.ForegroundColor = ConsoleColor.Black;
            GetAirlinesOfUk(aircraft);

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("\n10. Show helicopters with max height over 3.5 km or flight range over 500 km:");
            Console.ForegroundColor = ConsoleColor.Black;
            GetHelicoptersByMaxHeightOrFlightRange(aircraft);

            Console.ReadKey();
        }

        static void ShowPlane(XElement plane)
        {
            Console.WriteLine($"\nType: {plane.Element("Type").Value}");
            Console.WriteLine($"Name: {plane.Element("Name").Value}");
            Console.WriteLine($"Load capacity: {plane.Element("LoadCapacity").Value}");
            Console.WriteLine($"Flight range: {plane.Element("FlightRange").Value}");
            Console.WriteLine($"Wingspan: {plane.Element("Wingspan").Value}");
            Console.WriteLine($"Company code: {plane.Element("CompanyCode").Value}");
        }
        static void ShowHelicopter(XElement helicopter)
        {
            Console.WriteLine($"\nType: {helicopter.Element("Type").Value}");
            Console.WriteLine($"Name: {helicopter.Element("Name").Value}");
            Console.WriteLine($"Load capacity: {helicopter.Element("LoadCapacity").Value}");
            Console.WriteLine($"Maximum height: {helicopter.Element("MaxHeight").Value}");
            Console.WriteLine($"Flight range: {helicopter.Element("FlightRange").Value}");
            Console.WriteLine($"Company code: {helicopter.Element("CompanyCode").Value}");
        }
        static void ShowAirline(XElement airline)
        {
            Console.WriteLine($"\nName: {airline.Element("Name").Value}");
            Console.WriteLine($"Office location: {airline.Element("OfficeLocation").Value}");
            Console.WriteLine($"Formation date: {airline.Element("FormationDate").Value}");
            Console.WriteLine($"Company code: {airline.Element("CompanyCode").Value}");
        }

        static void ShowCollection(XDocument aircraft)
        {
            foreach (XElement plane in aircraft.Element("aircrafts").Element("planes").Elements("plane"))
                ShowPlane(plane);
            foreach (XElement helicopter in aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter"))
                ShowHelicopter(helicopter);
            foreach (XElement airline in aircraft.Element("aircrafts").Element("airlines").Elements("airline"))
                ShowAirline(airline);
        }

        // Request 1
        static void GetAllPlanes(XDocument aircraft)
        {
            var result = from p in
                    aircraft.Element("aircrafts").Element("planes").Elements("plane")
                select p;

            foreach (var item in result)
                ShowPlane(item);
        }

        // Request 2
        static void GetAllSortedHelicopters(XDocument aircraft)
        {
            var result = from h in
                    aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter")
                orderby h.Element("Name").Value
                select h.Element("Name").Value;

            foreach (var item in result)
                Console.WriteLine(item);
        }

        // Request 3
        static void GetPlanesAndHelicoptersOverLoadCapacity(XDocument aircraft, int capacity)
        {
            var result1 = from p in
                    aircraft.Element("aircrafts").Element("planes").Elements("plane")
                where Convert.ToInt32(p.Element("LoadCapacity").Value) > capacity
                select new
                {
                    Name = p.Element("Name").Value,
                    LoadCapacity = p.Element("LoadCapacity").Value
                };
            var result2 = from h in
                    aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter")
                where Convert.ToInt32(h.Element("LoadCapacity").Value) > capacity
                select new
                {
                    Name = h.Element("Name").Value,
                    LoadCapacity = h.Element("LoadCapacity").Value
                };

            foreach (var item in result1)
                Console.WriteLine(item.ToString());
            foreach (var item in result2)
                Console.WriteLine(item.ToString());
        }

        // Request 4
        static void GetPlanesAndHelicoptersOfEasyJet(XDocument aircraft, int code, int capacity)
        {
            var result1 = from p in
                    aircraft.Element("aircrafts").Element("planes").Elements("plane")
                where Convert.ToInt32(p.Element("CompanyCode").Value) == code
                      && Convert.ToInt32(p.Element("LoadCapacity").Value) < capacity
                select new
                {
                    Name = p.Element("Name").Value,
                    Type = p.Element("Type").Value,
                    LoadCapacity = p.Element("LoadCapacity").Value
                };
            var result2 = from h in
                    aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter")
                where Convert.ToInt32(h.Element("CompanyCode").Value) == code
                      && Convert.ToInt32(h.Element("LoadCapacity").Value) < capacity
                select new
                {
                    Name = h.Element("Name").Value,
                    Type = h.Element("Type").Value,
                    LoadCapacity = h.Element("LoadCapacity").Value
                };

            foreach (var item in result1)
                Console.WriteLine(item.ToString());
            foreach (var item in result2)
                Console.WriteLine(item.ToString());
        }

        // Request 5
        static void GetPlanesAirliners(XDocument aircraft, string type)
        {
            var result = from p in
                    aircraft.Element("aircrafts").Element("planes").Elements("plane")
                join a in aircraft.Element("aircrafts").Element("airlines").Elements("airline")
                    on p.Element("CompanyCode").Value equals a.Element("CompanyCode").Value
                where p.Element("Type").Value == type
                select new
                {
                    Plane = p.Element("Name").Value,
                    Type = p.Element("Type").Value,
                    Company = a.Element("Name").Value
                };

            foreach (var item in result)
                Console.WriteLine(item.ToString());
        }

        // Request 6
        static void CountPlanesByFlightRange(XDocument aircraft, int minRan, int maxRan)
        {
            int result = aircraft.Element("aircrafts").Element("planes").Elements("plane").Count(p =>
                (Convert.ToInt32(p.Element("LoadCapacity").Value) > minRan &&
                 Convert.ToInt32(p.Element("LoadCapacity").Value) < maxRan));
            Console.WriteLine($"Total number of planes: {result}.");
        }

        // Request 7
        static void GetHelicoptersOfEasyJetWithMaxHeight(XDocument aircraft, string name)
        {
            var result = aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter").Join(
                aircraft.Element("aircrafts").Element("airlines").Elements("airline"),
                h => h.Element("CompanyCode").Value,
                a => a.Element("CompanyCode").Value,
                (h, a) => Convert.ToInt32(h.Element("MaxHeight").Value));
            Console.WriteLine("Minimal {0}, maximal {1} and average {2}.",
                result.Min(), result.Max(), Math.Round(result.Average()));
        }

        // Request 8
        static void GetGroupedPlanes(XDocument aircraft)
        {
            var result = aircraft.Element("aircrafts").Element("planes").Elements("plane")
                .GroupBy(p => p.Element("CompanyCode").Value);
            foreach (var group in result)
            {
                Console.WriteLine("\nAirline: " + group.Key);
                foreach (var item in group)
                    Console.WriteLine($"\t{item.Element("Type").Value} - {item.Element("Name").Value}");
            }
        }

        // Request 9
        static void GetAirlinesOfUk(XDocument aircraft)
        {
            var result = aircraft.Element("aircrafts").Element("airlines").Elements("airline")
                .Where(a => a.Element("OfficeLocation").Value.Contains("UK"));

            foreach (var item in result)
                ShowAirline(item);
        }

        // Request 10
        static void GetHelicoptersByMaxHeightOrFlightRange(XDocument aircraft)
        {
            var result = aircraft.Element("aircrafts").Element("helicopters").Elements("helicopter").Where(h =>
                (Convert.ToInt32(h.Element("MaxHeight").Value) > 3500
                 || Convert.ToInt32(h.Element("FlightRange").Value) > 600));

            foreach (var item in result)
                ShowHelicopter(item);
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