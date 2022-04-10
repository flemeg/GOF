namespace GOF.Structural.Composite
{
    class ProductLeaf : ProductComponent
    {
        private string name;
        private double price;
                
        public string Name => this.name;
        public double Price => this.price;

        public ProductLeaf(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        public override double GetPrice()
        {
            return this.price;
        }        
    }
}
