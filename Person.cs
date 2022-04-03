using System;

namespace GOF
{
    public class Person
    {
        public Guid Id { get; private set; }

        public string Name { get; set; }

        public string Surname { get; set; }
        
        public int Age { get; set; }

        public DateTime BirthDate { get; set; }

        public IdInfo IdInfo { get; set; }

        public Person ShallowCopy()
        {
            return (Person)this.MemberwiseClone();
        }
                
        public Person DeepCopy()
        {
            Person clone = (Person)this.MemberwiseClone();
            clone.IdInfo = new IdInfo(IdInfo.IdNumber);
            clone.Name = string.Copy(Name);
            return clone;
        }

    }
}
