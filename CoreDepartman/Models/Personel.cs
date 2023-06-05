using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Personel 
    {
        [Key]
        public  int PerId { get; set; }
        public string FirstName { get; set;}
        public string LastName { get; set;}
        public string City { get; set;}
    }
}
