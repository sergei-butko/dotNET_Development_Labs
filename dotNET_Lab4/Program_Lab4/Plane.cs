namespace Program_Lab4
{
    public class Plane
    {
        public string Type { get; set; }
        public string Name { get; set; }
        public int LoadCapacity { get; set; }
        public int FlightRange { get; set; }
        public double Wingspan { get; set; }
        public int CompanyCode { get; set; }

        public override string ToString()
        {
            return $@"Plane:
                Plane type: {Type};
                Plane name: {Name};
                Load capacity: {LoadCapacity} kg;
                Flight range: {FlightRange} km;
                Wingspan: {Wingspan} m;
                Company code: {CompanyCode};";
        }
    }
}

