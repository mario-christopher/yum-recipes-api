using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Repository.Models
{
    [Table("Contributer")]
    public class Contributer: BaseModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [StringLength(50)]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [DataType(DataType.DateTime)]
        public DateTime Since { get; set; }
    }
}