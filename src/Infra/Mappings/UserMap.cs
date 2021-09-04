using Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infra.Mappings
{
    public class UserMap : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.ToTable("User");
            builder.HasKey(x => x.Id);

            builder.Property(x => x.Id)
                   .UseIdentityColumn();

            builder.Property(x => x.Name)
                   .IsRequired()
                   .HasColumnName("name")
                   .HasMaxLength(80);


            builder.Property(x => x.Password)
                   .IsRequired()
                   .HasColumnName("password")
                   .HasMaxLength(30);


            builder.Property(x => x.Email)
                   .IsRequired()
                   .HasColumnName("email")
                   .HasMaxLength(180);

        }
    }
}