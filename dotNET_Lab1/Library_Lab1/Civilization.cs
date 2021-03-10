namespace Library_Lab1
{
    public class Civilization
    {
        private readonly CivilizationFactory _civilizationFactory;
        private Citizen[] _civilizationCitizens;
        private Resources[] _civilizationResources;

        public Civilization(CivilizationFactory paramFactory)
        {
            _civilizationFactory = paramFactory;
        }

        public Citizen[] CreateCitizen()
        {
            _civilizationCitizens = new Citizen[3];
            _civilizationCitizens[0] = _civilizationFactory.CreateWarrior();
            _civilizationCitizens[1] = _civilizationFactory.CreateWorkman();
            _civilizationCitizens[2] = _civilizationFactory.CreateAristocrat();

            return _civilizationCitizens;
        }
        
        public Resources[] CreateResources()
        {
            _civilizationResources = new Resources[5];
            _civilizationResources[0] = _civilizationFactory.CreateFinances();
            _civilizationResources[1] = _civilizationFactory.CreateMountain();
            _civilizationResources[2] = _civilizationFactory.CreateField();
            _civilizationResources[3] = _civilizationFactory.CreateDwelling();
            _civilizationResources[4] = _civilizationFactory.CreateFactory();

            return _civilizationResources;
        }
    }
}