using GOF.Creational.Builder.Contracts;
using System;
using System.Linq;
using System.Text;

namespace GOF.Creational.Builder.Classes
{
    internal class MealBox : IMealComposite
    {
        private IMealComposite[] children = Array.Empty<IMealComposite>();
        public double GetPrice()
        {
            return this.children.Sum(x => x.GetPrice());
        }

        public void Add(IMealComposite[] meal)
        {
            meal.ToList().ForEach(x =>
            {
                children = children.Append(x).ToArray();
            });
        }

        public void Add(IMealComposite meal)
        {
            children = children.Append(meal).ToArray();
        }

        public override string ToString()
        {
            StringBuilder toString = new("Meal\n");
            children.ToList().ForEach(x => toString.AppendLine(x.ToString()));
            return toString.ToString();
        }
    }
}
