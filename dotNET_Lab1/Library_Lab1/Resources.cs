namespace Library_Lab1
{
    public abstract class Resources
    {
        public abstract string Info();
    }

    public class Finances : Resources
    {
        public override string Info()
        {
            return "Finances";
        }
    }

    public class Territory : Resources
    {
        public override string Info()
        {
            return "Territory";
        }
    }
}