using Microsoft.EntityFrameworkCore;

namespace WebApiAsp.Net6.Data
{
    public class MyDbContext : DbContext
    {
        public MyDbContext(DbContextOptions<MyDbContext> options) : base(options) {}

        #region DbSet
        public DbSet<Book> Books { get; set; }
        #endregion
    }
}
