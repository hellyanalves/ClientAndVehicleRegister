using System;

namespace Register.Domain
{
    public class Person
    {
        public int IdPerson { get; set; }
        public string Name { get; set; }
        public Vehicle Vehicle { get; set; }

        public bool IsValid()
        {
            return Name.Length <= 25;
        }
    }
}
