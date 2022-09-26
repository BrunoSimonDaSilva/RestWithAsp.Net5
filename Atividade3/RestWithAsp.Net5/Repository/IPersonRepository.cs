using RestWithAsp.Net5.Models;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Repository
{
    public interface IPersonRepository
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
        bool Exist(long id);
    }
}
