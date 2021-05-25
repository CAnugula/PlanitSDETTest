using System.Collections.Generic;
using System.Linq;

namespace Challenge6
{
    public class PeopleManager
    {
        private List<Person> _persons;
        public List<Person> Persons
        {
            get
            {
                return _persons;
            }
        }
        public PeopleManager(List<Person> persons)
        {
            _persons = persons;
        }

      
        public List<Person> GetDuplicates()
        {
            return _persons
                .GroupBy(p => p.Name)
                .Where(p => p.Count() > 1)
                .SelectMany(p => p.ToList()).ToList();
        }

        public void RemoveDuplicates()
        {
            var duplicates = GetDuplicates();
            _persons.RemoveAll(p => duplicates.Contains(p));
        }

        public double CalculateAverageAge()
        {
            return _persons.Select(p => p.GetAge()).Average();
        }

        public List<Person> FilterPeopleByAge(int age)
        {
            return _persons.Where(p => p.GetAge() < age).ToList();
        }

        public List<string> GetUniqueCountries()
        {
            return _persons.GroupBy(p => p.Country).Select(p => p.Key).ToList();
        }
    }
}
