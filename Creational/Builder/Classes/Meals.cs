namespace GOF.Creational.Builder.Classes
{
    internal class Rice : AbstractMeal
    {
        public Rice(string name, double price) : base(name, price) { }
    }

    internal class Beans : AbstractMeal
    {
        public Beans(string name, double price) : base(name, price) { }
    }

    internal class Meat : AbstractMeal
    {
        public Meat(string name, double price) : base(name, price) { }
    }

    internal class Beverage : AbstractMeal
    {
        public Beverage(string name, double price) : base(name, price) { }
    }

    internal class Dessert : AbstractMeal
    {
        public Dessert(string name, double price) : base(name, price) { }
    }


}
