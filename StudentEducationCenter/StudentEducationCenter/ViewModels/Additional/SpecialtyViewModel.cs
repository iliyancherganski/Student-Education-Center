﻿using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.ViewModels.Additional
{
    public class SpecialtyViewModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string SpecialtyName { get; set; } = null!;
    }
}
