using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.ViewModels.Additional
{
    public class PositionViewModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string PositionName { get; set; } = null!;
    }
}
