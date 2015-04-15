using DevContas.Domain;
using DevContas.Infra.Data.Maps;
using System.Data.Entity;

namespace DevContas.Infra.Data.Contexts
{
    public class DevContasDataContext : DbContext
    {
        public DevContasDataContext() 
            : base("DevContasConnectionString")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMap());
        }
    }
}
