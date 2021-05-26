using System.Collections.Generic;

namespace Challenge6
{
    public interface IPeopleManager
    {
        List<Person> Persons { get; }

        double CalculateAverageAge();
        List<Person> FilterPeopleByAge(int age);
        List<Person> GetDuplicates();
        List<string> GetUniqueCountries();
        void RemoveDuplicates();
    }
}