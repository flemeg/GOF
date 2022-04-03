using GOF.Models;

namespace GOF.Creational.FactoryMethod
{
    internal abstract class CardFactory
    {
        public abstract CreditCard GetCreditCard();
    }
}
