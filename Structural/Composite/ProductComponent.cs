using System.Collections.Generic;

namespace GOF.Structural.Composite
{
    internal abstract class ProductComponent
    {
        public abstract double GetPrice();
        public virtual void Add(ProductComponent product)
        {
        }
        public virtual void Add(IEnumerable<ProductComponent> products)
        {
        }
        public virtual void Remove(ProductComponent product)
        {
        }     
   
    }
}
