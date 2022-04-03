using GOF.Creational.Builder.Classes;

namespace GOF.Creational.Builder.Contracts
{
    internal interface IMealBuilder
    {
        MainDishBuilder MakeMeal();
    }
}
