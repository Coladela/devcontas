using DevContas.Domain;
using System.Data.Entity.ModelConfiguration;

namespace DevContas.Infra.Data.Maps
{
    public class UserMap : EntityTypeConfiguration<User>
    {
        public UserMap()
        {
            ToTable("User");

            HasKey(x => x.Id);
            Property(x => x.Name).IsRequired().HasMaxLength(60);
        }
    }
}
