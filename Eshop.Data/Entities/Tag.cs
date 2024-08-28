﻿using Eshop.Infrastructure.SharedKernel;
using System.ComponentModel.DataAnnotations;

namespace Eshop.Data.Entities
{
    public class Tag : DomainEntity<string>
    {
        [MaxLength(50)]
        [Required]
        public string Name { get; set; }

        [MaxLength(50)]
        [Required]
        public string Type { get; set; }
    }
}