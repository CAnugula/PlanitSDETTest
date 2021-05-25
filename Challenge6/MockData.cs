using System;
using System.Collections.Generic;

namespace Challenge6
{
    public class MockData
    {
        public static List<Person> GetPersons()
        {
            List<Person> persons = new List<Person>();
            persons.Add(new Person
            {
                Name = "Jason",
                DateOfBirth = Convert.ToDateTime("1984-02-20"),
                Nationality = "Australian",
                Country = "Australia"
            });

            persons.Add(new Person
            {
                Name = "George",
                DateOfBirth = Convert.ToDateTime("1983-03-10"),
                Nationality = "Australian",
                Country = "Australia"
            });
            persons.Add(new Person
            {
                Name = "Kiran",
                DateOfBirth = Convert.ToDateTime("1985-05-20"),
                Nationality = "Indian",
                Country = "India"
            });
            persons.Add(new Person
            {
                Name = "Kristin",
                DateOfBirth = Convert.ToDateTime("1984-08-20"),
                Nationality = "American",
                Country = "USA"
            });
            persons.Add(new Person
            {
                Name = "Matt",
                DateOfBirth = Convert.ToDateTime("1981-07-30"),
                Nationality = "Russian",
                Country = "Russia"
            });
            persons.Add(new Person
            {
                Name = "Kiran",
                DateOfBirth = Convert.ToDateTime("1989-02-20"),
                Nationality = "Australian",
                Country = "Australia"
            });
            persons.Add(new Person
            {
                Name = "Jason",
                DateOfBirth = Convert.ToDateTime("1983-02-20"),
                Nationality = "Australian",
                Country = "Australia"
            });
            persons.Add(new Person
            {
                Name = "Sasha",
                DateOfBirth = Convert.ToDateTime("1992-02-20"),
                Nationality = "Russian",
                Country = "Russia"
            });

            return persons;
        } 
    }
}
