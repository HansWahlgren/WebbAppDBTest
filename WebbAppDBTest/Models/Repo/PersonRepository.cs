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

        //public List<Person> FilterPeople(string userInput)
        //{
        //    throw new NotImplementedException();
        //}

        public Person Find(int id)
        {
            return _testDbContext.People.SingleOrDefault(person => person.Id == id);
        }

        public bool RemovePerson(Person person)
        {
            var result = _testDbContext.People.Remove(person);

            _testDbContext.SaveChanges();

            return true;
        }

        public Person Update(PersonViewModel person, int id)
        {
            Person originalPerson = Find(id);

            originalPerson.Name = person.Name;
            originalPerson.PhoneNumber = person.PhoneNumber;
            originalPerson.City = person.City;

            _testDbContext.SaveChanges();

            return originalPerson;
        }
    }
}
