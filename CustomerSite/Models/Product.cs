﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CustomerSite.Models
{
    public class Product
    {
        [Key]
        public int ID { get; set; }
        [Required]
        [Column("NameProduct")]
        public string Name { get; set; }
        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Please enter a value bigger than 0")]
        public float Price { get; set; }
        public string Description { get; set; }

    }
}
