using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    [Table("Ingredient")]
    public class Ingredient : BaseModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [StringLength(500)]
        [DataType(DataType.ImageUrl)]
        public string ImageUrl { get; set; }
    }
}