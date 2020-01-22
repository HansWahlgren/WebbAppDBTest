using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppDBTest.Models
{
    public class PersonService : IPersonService
    {
        readonly TestDbContext _testDbContext;

        public PersonService(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }

        public Person Create(PersonViewModel person)
        {
            return null;
        }
        public Person Find(int id)
        {
            return null;
        }
        public List<Person> All()
        {
            return null;
        }
        public Person Update(PersonViewModel person, int id)
        {
            return null;
        }
        public void RemovePerson(Person person)
        {

        }
        public List<Person> FilterPeople(string userInput)
        {
            return null;
        }
    }
}
