using Microsoft.EntityFrameworkCore;
using RestWithAsp.Net5.Models;

namespace RestWithAsp.Net5.Data
{
    public class BaseContext: DbContext
    {
        public BaseContext(DbContextOptions<BaseContext> options): base(options)
        {
        }
        public DbSet<Person> Persons { get; set; }
    }
}
