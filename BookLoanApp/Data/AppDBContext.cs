using BookLoanApp.Modals;
using Microsoft.EntityFrameworkCore;

namespace BookLoanApp.Data
{
    public class AppDBContext : DbContext
    {

        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {

        }




        public DbSet<Book> Books { get; set; }
    }
}
