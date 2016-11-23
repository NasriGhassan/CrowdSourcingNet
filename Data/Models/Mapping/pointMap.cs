using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;
namespace Data.Models.Mapping
{
    public class pointMap : EntityTypeConfiguration<point>
    {
        public pointMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.achievement)
                .HasMaxLength(255);

            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.icone)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("point", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.achievement).HasColumnName("achievement");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.icone).HasColumnName("icone");
            this.Property(t => t.points).HasColumnName("points");
        }
    }
}
