using CheckIt.Helper;
using Microsoft.EntityFrameworkCore;

namespace CheckIt.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {
        }

        public DbSet<Expense> Expenses => Set<Expense>();
    }
}
