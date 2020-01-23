using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppDBTest.Models
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person Find(int id);
        List<Person> All();
        Person Update(Person person);
        bool RemovePerson(Person person);
        List<Person> FilterPeople(string userInput);
    }
}
