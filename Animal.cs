using System;

namespace GOF
{
    public abstract class Animal
    {
        protected abstract string MakeNoise();
        
        public void MakeSound()
        {
            Console.WriteLine(this.MakeNoise());
        }
    }

    public class Dog : Animal
    {
        protected override string MakeNoise()
        {
            return "Au au";
        }
    }
}
