using Microsoft.EntityFrameworkCore;
using Whales.Models;

namespace Whales.Models {
    public class WhaleContext : DbContext {
        public WhaleContext(DbContextOptions options) : base(options) { }
        public DbSet<Owner> Owners {get;set;}
        public DbSet<Pet> Pets {get;set;}

        public void Create(Owner o)
        {
            Owners.Add(o);
            SaveChanges();
        }

        public void Create(Pet p)
        {
            Pets.Add(p);
            SaveChanges();
        }
    }
}