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
            if (string.IsNullOrWhiteSpace(person.Name) || string.IsNullOrWhiteSpace(person.PhoneNumber) || string.IsNullOrWhiteSpace(person.City))
            {
                return null;
            }

            return _personRepository.Update(person, id);
        }

        public bool RemovePerson(int id)
        {
            Person person = Find(id);

            if (person == null)
            {
                return false;
            }

            return _personRepository.RemovePerson(person);
        }

        public List<Person> FilterPeople(string userInput)
        {
            List<Person> fullList = All();
            List<Person> filteredList = new List<Person>();

            foreach (Person person in fullList)
            {
                if (person.Name.Contains(userInput) || person.City.Contains(userInput))
                {
                    filteredList.Add(person);
                }
            }
            return filteredList;
        }
    }
}
