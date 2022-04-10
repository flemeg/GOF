using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace GOF.Structural.Composite
{
    internal class ProductComposed : ProductComponent
    {
        private IList<ProductComponent> children = new List<ProductComponent>();

        public override void Add(ProductComponent product)
        {
            children.Add(product);
        }

        public override void Add(IEnumerable<ProductComponent> products)
        {
            foreach (var item in products)
            {
                children.Add(item);
            }
        }

        public override void Remove(ProductComponent product)
        {
            children.Remove(product);
        }

        public override double GetPrice()
        {
            return children.Sum(e => e.GetPrice());
        }

        public override string ToString()
        {
            return JsonConvert.SerializeObject(children);
        }

    }
}
