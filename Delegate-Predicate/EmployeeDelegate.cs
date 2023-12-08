using Delegate_Predicate.Models;

namespace Delegate_Predicate
{
    internal class EmployeeDelegate
    {
        public delegate bool CheckSalary(List<Person> person);
        public void ShowPersons(List<Person> persons, Predicate<Person> predicate)
        {
            foreach (Person person in persons)
            {
                if (predicate(person))
                {
                    Console.WriteLine($"{person.Name} - {person.Surname} - {person.Address}");
                }
            }
        }

        public void Result()
        {
            List<Person> people = new List<Person>()
            {
            new Person() { Name = "Metanet", Surname = "Abbasova", Salary = 2000, Address = "Sumgait" },
            new Person() { Name = "Irane", Surname = "Muxtarli", Salary = 3800, Address = "Baki" },
            new Person() { Name = "Turkan", Surname = "Qurbanova", Salary = 980, Address = "Xizi" },
            new Person() { Name = "Necef", Surname = "Necefov", Salary = 400, Address = "Salyan" },

            };

            ShowPersons(people, people => people.Salary > 1000);
        }
    }
}
