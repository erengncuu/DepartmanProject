using Microsoft.EntityFrameworkCore;

namespace CoreDepartman.Models
{
    public class Context : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=DESKTOP-H6BPHOP\\SQLEXPRESS; database=CorePersonel; integrated security=true; TrustServerCertificate=True"); //şu sql serverını kullan
        }
        public  DbSet<Departman> Departmans { get; set; }
        public  DbSet<Personel> Personels { get; set; }
        public  DbSet<Admin> Admins { get; set; }
    }
}
