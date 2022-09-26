using RestWithAsp.Net5.Models;
using System.Collections.Generic;

namespace RestWithAsp.Net5.Business
{
    public interface IPersonBusiness
    {
        Person Create(Person person);
        Person FindById(long id);
        List<Person> FindAll();
        Person Update(Person person);
        void Delete(long id);
    }
}
