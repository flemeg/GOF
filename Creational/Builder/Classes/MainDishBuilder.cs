using GOF.Creational.Builder.Contracts;

namespace GOF.Creational.Builder.Classes
{
    internal class MainDishBuilder : IMealBuilder
    {
        private MealBox meal = new();

        public MainDishBuilder MakeMeal()
        {
            var rice = new Rice("Rice", 5);
            var beans = new Beans("Beans", 10);
            var meat = new Meat("Meat", 20);

            this.meal.Add(new IMealComposite[3] { rice, beans, meat });
            return this;
        }

        public MainDishBuilder Reset()
        {
            this.meal = new();
            return this;
        }

        public MainDishBuilder MakeDessert()
        {
            Dessert dessert = new("Dessert", 10);
            this.meal.Add(dessert);
            return this;
        }

        public MainDishBuilder MakeBeverage()
        {
            Beverage beverage = new("Beverage", 7);
            this.meal.Add(beverage);
            return this;
        }

        public MealBox GetMeal()
        {
            return this.meal;
        }

        public double GetPrice()
        {
            return this.meal.GetPrice();
        }

    }
}
