using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.Generic;

namespace Repository.Models
{
    [Table("Recipe")]
    public class Recipe : BaseModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }

        [Required]
        [StringLength(1000)]
        [DataType(DataType.MultilineText)]
        public string Description { get; set; }

        [Required]
        [StringLength(5000)]
        [DataType(DataType.MultilineText)]
        public string Preparation { get; set; }

        [Required]
        [ForeignKey("ContributerID")]
        public virtual Contributer Contributer { get; set; }

        [Required]
        [Range(1, 360)]
        public int PreparationTimeInMinutes { get; set; }

        public virtual IList<Tag> Tags { get; set; }

        public virtual IList<Ingredient> Ingredients { get; set; }
    }
}