using Ex_02.Data.Entity;
using Microsoft.EntityFrameworkCore;

namespace Ex_02.Data
{
    public class DataContext : DbContext

    {
        public DbSet<Plantas> plantas { set; get; }
        public DbSet<Riego> riesgo { set; get; }



        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {


        }

    }
}
