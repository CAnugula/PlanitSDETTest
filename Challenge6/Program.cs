using System;

namespace Challenge6
{
    class Program
    {
        static void Main(string[] args)
        {
            // Get sample mock data
            var mockData = MockData.GetPersons();
            IPeopleManager peopleManager = new PeopleManager(mockData);

            // Get all duplicates by name
            var duplicates = peopleManager.GetDuplicates();

            Console.WriteLine("******************Duplicates********************");
            Console.WriteLine(string.Join("\n", duplicates));

            // Altered the original list and remove duplicates by name 
            peopleManager.RemoveDuplicates();
            Console.WriteLine("\n\n");
            Console.WriteLine("******************List without duplicates********************");
            Console.WriteLine(string.Join("\n", peopleManager.Persons));

            // Calculate average age
            var averageAge = peopleManager.CalculateAverageAge();
            Console.WriteLine("\n\n");
            Console.WriteLine("******************Average Age********************");
            Console.WriteLine(averageAge);

            // Find all the people with age less than N
            // eg, where N = 31
            var filteredPersons = peopleManager.FilterPeopleByAge(31);
            Console.WriteLine("\n\n");
            Console.WriteLine("******************Filtered People By Age less than 31 years********************");
            Console.WriteLine(string.Join("\n", filteredPersons));

            // Obtain a list of unique countries
            var uniqueCountries = peopleManager.GetUniqueCountries();
            Console.WriteLine("\n\n");
            Console.WriteLine("******************List of Unique Countries********************");
            Console.WriteLine(string.Join("\n", uniqueCountries));

            Console.ReadKey();
        }
    }
}
