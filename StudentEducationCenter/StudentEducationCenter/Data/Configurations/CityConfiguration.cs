using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEducationCenter.Data.Models;

namespace StudentEducationCenter.Data.Configurations
{
    public class CityConfiguration : IEntityTypeConfiguration<City>
    {
        public void Configure(EntityTypeBuilder<City> builder)
        {
            List<City> list = new List<City>()
            {
                new City()
                {
                    Id = 1,
                    CityName = "Бургас",
                },
                new City()
                {
                    Id = 2,
                    CityName = "Варна",
                },
                new City()
                {
                    Id = 3,
                    CityName = "Велико Търново",
                },
                new City()
                {
                    Id = 4,
                    CityName = "Пловдив",
                },
                new City()
                {
                    Id = 5,
                    CityName = "Русе",
                },
                new City()
                {
                    Id = 6,
                    CityName = "София",
                },
            };
            builder.HasData(list);
        }
    }
}
