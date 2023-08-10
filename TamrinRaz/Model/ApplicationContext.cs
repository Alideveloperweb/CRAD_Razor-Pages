using Microsoft.EntityFrameworkCore;

namespace TamrinRaz.Model
{
    public class ApplicationContext:DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options):base(options)
        {

        }



        public DbSet<Book> Books { get; set; }
    }
}
