using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CoreDepartman.Models
{
    public class Admin
    {
        [Key]
        public int? AdminId { get; set; }
        [Column(TypeName ="Varchar(20)")]
        public string? Kullanici { get; set; }
        [Column(TypeName = "Varchar(10)")]
        public string? password { get; set; }
    }
}
