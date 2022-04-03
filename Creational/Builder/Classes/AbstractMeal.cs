using GOF.Creational.Builder.Contracts;

namespace GOF.Creational.Builder.Classes
{
    internal abstract class AbstractMeal : IMealComposite
    {
        private string name;
        private double price;

        public AbstractMeal(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public double GetPrice()
        {
            return this.price;
        }

        public override string ToString()
        {
            return $"Name: {name} Price: {price}";
        }
    }
}
