using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class userMap : EntityTypeConfiguration<user>
    {
        public userMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.email)
                .HasMaxLength(255);

            this.Property(t => t.login)
                .HasMaxLength(255);

            this.Property(t => t.nickname)
                .HasMaxLength(255);

            this.Property(t => t.nom)
                .HasMaxLength(255);

            this.Property(t => t.password)
                .HasMaxLength(255);

            this.Property(t => t.photo)
                .HasMaxLength(255);

            this.Property(t => t.prenom)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("user", "crowdsourcing");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.birthday).HasColumnName("birthday");
            this.Property(t => t.email).HasColumnName("email");
            this.Property(t => t.gender).HasColumnName("gender");
            this.Property(t => t.login).HasColumnName("login");
            this.Property(t => t.nickname).HasColumnName("nickname");
            this.Property(t => t.nom).HasColumnName("nom");
            this.Property(t => t.password).HasColumnName("password");
            this.Property(t => t.photo).HasColumnName("photo");
            this.Property(t => t.prenom).HasColumnName("prenom");
            this.Property(t => t.banned).HasColumnName("banned");
            this.Property(t => t.coffee_points).HasColumnName("coffee_points");
            this.Property(t => t.exp).HasColumnName("exp");
            this.Property(t => t.level).HasColumnName("level");
            this.Property(t => t.registration).HasColumnName("registration");

            // Relationships
            this.HasMany(t => t.points)
                .WithMany(t => t.users)
                .Map(m =>
                    {
                        m.ToTable("user_point", "crowdsourcing");
                        m.MapLeftKey("User_id");
                        m.MapRightKey("achievements_id");
                    });


        }
    }
}
