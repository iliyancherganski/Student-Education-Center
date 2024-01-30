using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.ViewModels.Additional
{
    public class AgeGroupViewModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string AgeGroupName { get; set; } = null!;
    }
}
