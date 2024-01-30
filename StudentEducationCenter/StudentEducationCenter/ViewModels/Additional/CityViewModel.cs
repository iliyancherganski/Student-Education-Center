﻿using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace StudentEducationCenter.ViewModels.Additional
{
    public class CityViewModel
    {
        [Required]
        [MinLength(1)]
        [MaxLength(100)]
        public string CityName { get; set; } = null!;
    }
}
