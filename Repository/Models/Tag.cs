using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    [Table("Tag")]
    public class Tag : BaseModel
    {
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
    }
}