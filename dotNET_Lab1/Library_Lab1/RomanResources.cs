namespace Library_Lab1
{
    public class RomanFinances : Finances
    {
        public override string Info()
        {
            return "5`400 Roman Milled Coins";
        }
    }

    public class RomanMountain : Mountain
    {
        public override string Info()
        {
            return "Roman Palatine Hill";
        }
    }

    public class RomanField : Field
    {
        public override string Info()
        {
            return "Roman Field";
        }
    }
    
    public class RomanDomus : Dwelling
    {
        public override string Info()
        {
            return "Roman Domus";
        }
    }
    

    public class RomanFactory : Factory
    {
        public override string Info()
        {
            return "Roman Factory";
        }
    }
}