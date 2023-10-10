using Microsoft.EntityFrameworkCore;

namespace HotelManagement.Models
{
    public class HotelManagementContext : DbContext 
    {
        public HotelManagementContext(DbContextOptions<HotelManagementContext> options) : base(options)
        {

        }
        public DbSet<Menu> Menus { get; set; }
    }
}
