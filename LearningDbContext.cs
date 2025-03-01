using Microsoft.EntityFrameworkCore;
using Zoo.Models;
using Zoo.Configuration;

namespace Zoo
{
    public class LearningDbContext(DbContextOptions<LearningDbContext> options)
        :DbContext(options)
    {
        public DbSet<AnimalEntity> Animals { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AnimalConfiguration());
        }
    }
}
