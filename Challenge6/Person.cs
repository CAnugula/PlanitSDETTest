using System;

namespace Challenge6
{
    public class Person
    {
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }

        public string Nationality { get; set; }

        public string Country { get; set; }

        public override string ToString()
        {
            return $"Name : {Name} - Nationality : {Nationality}";
        }

        public int GetAge()
        {
            return (DateTime.Now - DateOfBirth).Days / 365;
        }
    }
}
