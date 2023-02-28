using DuettChallenge.Business.Entities;
using Microsoft.EntityFrameworkCore;

namespace DuettChallenge.Data
{
    public class DuettChallengeDbContext : DbContext
    {
        public DuettChallengeDbContext() { }
        public DuettChallengeDbContext(DbContextOptions<DuettChallengeDbContext> options) : base(options) { }

        public virtual DbSet<Fruit> Fruits { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Fruit>()
            .HasKey(fruit => fruit.Id);
        }
    }
}
