using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.Data.Models
{
    public class City
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100)]
        public string CityName { get; set; } = null!;
    }
}
