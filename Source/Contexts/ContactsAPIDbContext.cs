using Microsoft.EntityFrameworkCore;
using Source.Models;

namespace Source.Contexts
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions options) : base(options)
        {
            
        }
        public DbSet<Contact> Contacts { get; set; }

    }
}
