using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using StudentEducationCenter.Data.Models;

namespace StudentEducationCenter.Data.Configurations
{
    public class SpecialityConfiguration : IEntityTypeConfiguration<Specialty>
    {
        public void Configure(EntityTypeBuilder<Specialty> builder)
        {
            List<Specialty> list = new List<Specialty>()
            {
                new Specialty()
                {
                    Id = 1,
                    SpecialtyName = "Математика",
                },
                new Specialty()
                {
                    Id = 2,
                    SpecialtyName = "Информатика",
                },
                new Specialty()
                {
                    Id = 3,
                    SpecialtyName = "Български език и литература",
                },
                new Specialty()
                {
                    Id = 4,
                    SpecialtyName = "Английски език",
                },
                new Specialty()
                {
                    Id = 5,
                    SpecialtyName = "Немски език",
                },
                new Specialty()
                {
                    Id = 6,
                    SpecialtyName = "Испански език",
                },
                new Specialty()
                {
                    Id = 7,
                    SpecialtyName = "Руски език",
                },
                new Specialty()
                {
                    Id = 8,
                    SpecialtyName = "Френски език",
                },
            };
            builder.HasData(list);
        }
    }
}
