using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEducationCenter.Data.Models;

namespace StudentEducationCenter.Data.Configurations
{
    public class AgeGroupConfiguration : IEntityTypeConfiguration<AgeGroup>
    {
        public void Configure(EntityTypeBuilder<AgeGroup> builder)
        {
            List<AgeGroup> list = new List<AgeGroup>()
            {
                new AgeGroup()
                {
                    Id = 1,
                    AgeGroupName = "5 клас",
                },
                new AgeGroup()
                {
                    Id = 2,
                    AgeGroupName = "6 клас",
                },
                new AgeGroup()
                {
                    Id = 3,
                    AgeGroupName = "7 клас",
                },
                new AgeGroup()
                {
                    Id = 4,
                    AgeGroupName = "5-7 клас",
                },
            };
            builder.HasData(list);
        }
    }
}
