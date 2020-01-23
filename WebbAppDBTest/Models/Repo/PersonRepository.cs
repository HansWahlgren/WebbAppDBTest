using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppDBTest.Models
{
    public class PersonRepository : IPersonRepository
    {
        readonly TestDbContext _testDbContext;

        public PersonRepository(TestDbContext testDbContext)
        {
            _testDbContext = testDbContext;
        }

        public List<Person> All()
        {
            return _testDbContext.People.ToList();
        }

        public Person Create(Person person)
        {
            _testDbContext.People.Add(person);
            _testDbContext.SaveChanges();

            return person;
        }

        public List<Person> FilterPeople(string userInput)
        {
            throw new NotImplementedException();
        }

        public Person Find(int id)
        {
            return _testDbContext.People.SingleOrDefault(person => person.Id == id);
        }

        public bool RemovePerson(Person person)
        {
            throw new NotImplementedException();
        }

        public Person Update(Person person)
        {
            throw new NotImplementedException();
        }
    }
}
