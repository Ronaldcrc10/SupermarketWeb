﻿using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace SupermarketWeb.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; } //Primary Key de mi modelo/clase Category

        [Required]
        [DisplayName("Category Name")]
        public string CategoryName { get; set; }
        [Required]
        public string Description { get; set; }
      


    }
}