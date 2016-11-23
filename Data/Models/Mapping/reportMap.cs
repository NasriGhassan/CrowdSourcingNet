using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class reportMap : EntityTypeConfiguration<report>
    {
        public reportMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            this.Property(t => t.status)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("report", "crowdsourcing");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.status).HasColumnName("status");
            this.Property(t => t.idea_id).HasColumnName("idea_id");
            this.Property(t => t.comment_id).HasColumnName("comment_id");
            this.Property(t => t.customer_id).HasColumnName("customer_id");

            // Relationships
            this.HasOptional(t => t.comment)
                .WithMany(t => t.reports)
                .HasForeignKey(d => d.comment_id);
            this.HasOptional(t => t.idea)
                .WithMany(t => t.reports)
                .HasForeignKey(d => d.idea_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.reports)
                .HasForeignKey(d => d.customer_id);

        }
    }
}
