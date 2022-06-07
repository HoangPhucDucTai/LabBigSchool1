using System.ComponentModel.DataAnnotations;

namespace LabBigSchool_DucTai.Models
{
    public class Category
    {
        public byte Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
    }
}