namespace Library_Lab1
{
    public class GreekFinances : Finances
    {
        public override string Info()
        {
            return "6`000 Greek Talents";
        }
    }

    public class GreekMountain : Mountain
    {
        public override string Info()
        {
            return "Greek Olympus";
        }
    }

    public class GreekField : Field
    {
        public override string Info()
        {
            return "Greek Field";
        }
    }

    public class GreekPastados : Dwelling
    {
        public override string Info()
        {
            return "Greek Pastados House";
        }
    }

    public class GreekFactory : Factory
    {
        public override string Info()
        {
            return "Greek Factory";
        }
    }
}