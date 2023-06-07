using CoreDepartman.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace CoreDepartman.Models
{
    public class Departman 
    {
        [Key]
        public int Id { get; set; }
        public string DepartmanName { get; set;}

        public IList<Personel> personels { get; set; }

    }
}

