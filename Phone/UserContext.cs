using Microsoft.EntityFrameworkCore;

namespace Phone
{
    public class UserContext : DbContext
    {
        public DbSet<User> Users { get; set; } 

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-O83IAAO;Database=TestDBSGMK;Trusted_Connection=True;"); // Замените "YourConnectionString" на вашу строку подключения к базе данных
        }
    }
}
