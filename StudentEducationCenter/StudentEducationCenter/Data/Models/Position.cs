using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.Data.Models
{
    public class Position
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public string PositionName { get; set; } = null!;
    }
}
