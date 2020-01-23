using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppDBTest.Models
{
    public class PersonService : IPersonService
    {
        readonly IPersonRepository _personRepository;

        public PersonService(IPersonRepository personRepository)
        {
            _personRepository = personRepository;
        }

        public Person Create(PersonViewModel person)
        {
            Person newPerson = new Person()
            {
                Name = person.Name,
                PhoneNumber = person.PhoneNumber,
                City = person.City
            };
            return _personRepository.Create(newPerson);
        }

        public Person Find(int id)
        {
            return _personRepository.Find(id);
        }

        public List<Person> All()
        {
            return _personRepository.All();
        }

        public Person Update(PersonViewModel person, int id)
        {
            throw new NotImplementedException();
        }

        public bool RemovePerson(int id)
        {

        }

        public List<Person> FilterPeople(string userInput)
        {
            throw new NotImplementedException();
        }
    }
}
