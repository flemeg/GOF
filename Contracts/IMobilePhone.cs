using GOF.Contracts;

namespace GOF.Creational.Contracts
{
    internal interface IMobilePhone
    {
        ISmartPhone GetSmartPhone();
        INormalPhone GetNormalPhone();
    }
}
