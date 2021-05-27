namespace Program_Lab4
{
    public class Helicopter
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int LoadCapacity { get; set; }
        public int MaxHeight { get; set; }
        public int FlightRange { get; set; }
        public int CompanyCode { get; set; }

        public override string ToString()
        {
            return $@"Helicopter:
                Helicopter type: {Type};
                Helicopter name: {Name};
                Load capacity: {LoadCapacity} kg;
                Maximum height: {MaxHeight} m;
                Flight range: {FlightRange} km;
                Company code: {CompanyCode};";
        }
    }
}