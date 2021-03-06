﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebbAppDBTest.Models
{
    public interface IPersonService
    {
        Person Create(PersonViewModel person);
        Person Find(int id);
        List<Person> All();
        Person Update(PersonViewModel person, int id);
        bool RemovePerson(int id);
        List<Person> FilterPeople(string userInput);
    }
}
