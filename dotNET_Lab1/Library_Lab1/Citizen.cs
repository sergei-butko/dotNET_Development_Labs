namespace Library_Lab1
{
    public abstract class Citizen
    {
        public abstract string Info();
    }

    public class Warrior : Citizen
    {
        public override string Info()
        {
            return "Warrior";
        }
    }

    public class Workman : Citizen
    {
        public override string Info()
        {
            return "Workman";
        }
    }

    public class Aristocrat : Citizen
    {
        public override string Info()
        {
            return "Aristocrat";
        }
    }
}