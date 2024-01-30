using Microsoft.AspNetCore.Identity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StudentEducationCenter.Data.Models
{
    public class Employee
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string MiddleName { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; } = null!;

        [ForeignKey(nameof(City))]
        public int CityId { get; set; }
        public City City { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Address { get; set; } = null!;

        [Required]
        [MaxLength(15)]
        public string PhoneNumber { get; set; } = null!;

        [Required]
        [MaxLength(50)]
        public string Email { get; set; } = null!;

        [ForeignKey(nameof(Position))]
        public int PositionId { get; set; }
        public Position Position { get; set; } = null!;

        [ForeignKey(nameof(User))]
        public string UserId { get; set; } = null!;
        public User User { get; set; } = null!;

        public List<Course> Courses { get; set; } = new List<Course>();
    }
}
