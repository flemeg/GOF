namespace GOF.Creational.Builder
{
    internal class Builder
    {
    }

    internal class PersonBuilder
    {
        private readonly Person person = new();

        public PersonBuilder SetName(string name)
        {
            this.person.Name = name;
            return this;
        }

        public PersonBuilder SetSurname(string surname)
        {
            this.person.Surname = surname;
            return this;
        }

        public Person GetResult()
        {
            return this.person;
        }

    }

}
