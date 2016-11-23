using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class commentMap : EntityTypeConfiguration<comment>
    {
        public commentMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("comment", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.visibility).HasColumnName("visibility");
            this.Property(t => t.idea_id).HasColumnName("idea_id");
            this.Property(t => t.user_id).HasColumnName("user_id");

            // Relationships
            this.HasOptional(t => t.idea)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.idea_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.comments)
                .HasForeignKey(d => d.user_id);

        }
    }
}
