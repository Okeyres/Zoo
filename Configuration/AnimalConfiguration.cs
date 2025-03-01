using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Zoo.Models;

namespace Zoo.Configuration
{
    public class AnimalConfiguration : IEntityTypeConfiguration<AnimalEntity>
    {
        public void Configure(EntityTypeBuilder<AnimalEntity> builder) 
        {
            builder.HasKey(a => a.Id);
        }
    }
}
