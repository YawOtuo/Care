using Care.DBContexts;
using Care.Models;
using Care.Repository;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;

namespace Care.Repository
{
    public class PersontRepository : IPersonRepository
    {
        private readonly PersonContext _dbContext;

        public PersontRepository(PersonContext dbContext)
        {
            _dbContext = dbContext;
        }
        public void DeletePersont(int personId)
        {
            var person = _dbContext.Persons.Find(personId);
            _dbContext.Persons.Remove(person);
            Save();
        }

        public Person GetPersonByID(int personId)
        {
            return _dbContext.Persons.Find(personId);
        }

        public IEnumerable<Person> GetPerson()
        {
            return _dbContext.Persons.ToList();
        }

        public void InsertPerson(Person person)
        {
            _dbContext.Add(person);
            Save();
        }

        public void Save()
        {
            _dbContext.SaveChanges();
        }

        public void UpdatePerson(Person person)
        {
            _dbContext.Entry(person).State = EntityState.Modified;
            Save();
        }
    }
}