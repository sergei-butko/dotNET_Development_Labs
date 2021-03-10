namespace Library_Lab1
{
    public class Mountain : Territory
    {
        public override string Info()
        {
            return "Mountain";
        }
    }

    public class Field : Territory
    {
        public override string Info()
        {
            return "Field";
        }
    }

    public class Dwelling : Territory
    {
        public override string Info()
        {
            return "Dwelling";
        }
    }

    public class Factory : Territory
    {
        public override string Info()
        {
            return "Factory";
        }
    }
}