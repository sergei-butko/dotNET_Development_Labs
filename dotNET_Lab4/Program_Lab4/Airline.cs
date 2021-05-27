namespace Program_Lab4
{
    public class Airline
    {
        public string Name { get; set; }
        public string OfficeLocation { get; set; }
        public string FormationDate { get; set; }
        public int CompanyCode { get; set; }

        public override string ToString()
        {
            return $@"Airline:
                Airline name: {Name};
                Office location: {OfficeLocation};
                Formation date: {FormationDate};
                Company code: {CompanyCode};";
        }
    }
}