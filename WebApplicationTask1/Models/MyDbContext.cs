using Microsoft.EntityFrameworkCore;

namespace WebApplicationTask1.Models
{

    public class MyDbContext : DbContext
        {
            public MyDbContext(DbContextOptions<MyDbContext> options)
                : base(options)
            { }
            public DbSet<Articles> Articles { get; set; }
        }

}
