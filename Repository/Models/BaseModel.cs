using System;
using System.ComponentModel.DataAnnotations;

namespace Repository.Models
{
    public abstract class BaseModel
    {
        [Key]
        public int ID { get; set; }

        [Required]
        public int CreatedBy { get; set; }

        [Required]
        public DateTime CreatedDate { get; set; }

        [Required]
        public int ModifiedBy { get; set; }

        [Required]
        public DateTime ModifiedDate { get; set; }
    }
}