using RestWithAsp.Net5.Data;
using RestWithAsp.Net5.Models;
using System;
using System.Collections.Generic;
using System.Linq;


namespace RestWithAsp.Net5.Repository
{
    public class PersonRepository : IPersonRepository
    {
        private readonly Data.BaseContext _base;

        public PersonRepository(Data.BaseContext basecontext)
        {
            _base = basecontext;
        }

        public Person Create(Person person)
        {
            _base.Persons.Add(person);
            _base.SaveChanges();
            return person;
        }

        public void Delete(long id)
        {
            Person result = FindById(id);
            if (result != null)
            {
                try
                {
                    _base.Persons.Remove(result);
                    _base.SaveChanges();
                }
                catch (Exception)
                {

                    throw;
                }
            }

        }

        public List<Person> FindAll()
        {
            return _base.Persons.ToList();
        }

        public Person FindById(long id)
        {
            return _base.Persons.FirstOrDefault(p => p.Id == id);
        }

        public Person Update(Person person)
        {
            if (!Exist(person.Id)) return null;
            Person personToUpdate = FindById(person.Id);

            if (personToUpdate != null)
            {
                try
                {
                    personToUpdate.Address = person.Address;
                    personToUpdate.Fistname = person.Fistname;
                    personToUpdate.Lastname = person.Lastname;
                    personToUpdate.Gender = person.Gender;

                    _base.Persons.Update(personToUpdate);
                    _base.SaveChanges();

                    return personToUpdate;
                }
                catch (Exception)
                {
                    throw;
                }
            }
            return person;
        }
        public bool Exist(long id)
        {
            return _base.Persons.Any(x => x.Id == id);
        }
    }
}
