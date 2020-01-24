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
        Person Update(PersonViewModel person, int id);
        bool RemovePerson(Person person);
        //List<Person> FilterPeople(string userInput);
    }
}
