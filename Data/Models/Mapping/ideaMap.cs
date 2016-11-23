using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class ideaMap : EntityTypeConfiguration<idea>
    {
        public ideaMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            this.Property(t => t.subject)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("idea", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.subject).HasColumnName("subject");
            this.Property(t => t.visibility).HasColumnName("visibility");
            this.Property(t => t.category_id).HasColumnName("category_id");
            this.Property(t => t.user_id).HasColumnName("user_id");

            // Relationships
            this.HasOptional(t => t.category)
                .WithMany(t => t.ideas)
                .HasForeignKey(d => d.category_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.ideas)
                .HasForeignKey(d => d.user_id);

        }
    }
}
