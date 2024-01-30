using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEducationCenter.Data.Models;

namespace StudentEducationCenter.Data.Configurations
{
    public class PositionConfiguration : IEntityTypeConfiguration<Position>
    {
        public void Configure(EntityTypeBuilder<Position> builder)
        {
            List<Position> list = new List<Position>()
            {
                new Position()
                {
                    Id = 1,
                    PositionName = "Системен администратор",
                },
            };
            builder.HasData(list);
        }
    }
}
