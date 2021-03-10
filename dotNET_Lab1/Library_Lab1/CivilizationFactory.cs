namespace Library_Lab1
{
    public abstract class CivilizationFactory
    {
        public abstract Warrior CreateWarrior();
        public abstract Workman CreateWorkman();
        public abstract Aristocrat CreateAristocrat();
        public abstract Finances CreateFinances();
        public abstract Mountain CreateMountain();
        public abstract Field CreateField();
        public abstract Dwelling CreateDwelling();
        public abstract Factory CreateFactory();
    }

    public class GreekCivilizationFactory : CivilizationFactory
    {
        public override Warrior CreateWarrior()
        {
            return new GreekWarrior();
        }

        public override Workman CreateWorkman()
        {
            return new GreekWorkman();
        }

        public override Aristocrat CreateAristocrat()
        {
            return new GreekAristocrat();
        }

        public override Finances CreateFinances()
        {
            return new GreekFinances();
        }

        public override Mountain CreateMountain()
        {
            return new GreekMountain();
        }

        public override Field CreateField()
        {
            return new GreekField();
        }

        public override Dwelling CreateDwelling()
        {
            return new GreekPastados();
        }

        public override Factory CreateFactory()
        {
            return new GreekFactory();
        }
    }

    public class RomanCivilizationFactory : CivilizationFactory
    {
        public override Warrior CreateWarrior()
        {
            return new RomanWarrior();
        }

        public override Workman CreateWorkman()
        {
            return new RomanWorkman();
        }

        public override Aristocrat CreateAristocrat()
        {
            return new RomanAristocrat();
        }
        public override Finances CreateFinances()
        {
            return new RomanFinances();
        }

        public override Mountain CreateMountain()
        {
            return new RomanMountain();
        }

        public override Field CreateField()
        {
            return new RomanField();
        }

        public override Dwelling CreateDwelling()
        {
            return new RomanDomus();
        }

        public override Factory CreateFactory()
        {
            return new RomanFactory();
        }
    }
}