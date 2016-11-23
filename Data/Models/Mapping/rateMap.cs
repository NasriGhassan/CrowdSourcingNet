using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class rateMap : EntityTypeConfiguration<rate>
    {
        public rateMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.DTYPE)
                .IsRequired()
                .HasMaxLength(31);

            // Table & Column Mappings
            this.ToTable("rate", "crowdsourcing");
            this.Property(t => t.DTYPE).HasColumnName("DTYPE");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.visibility).HasColumnName("visibility");
            this.Property(t => t.review).HasColumnName("review");
            this.Property(t => t.user_id).HasColumnName("user_id");
            this.Property(t => t.comment_id).HasColumnName("comment_id");
            this.Property(t => t.idea_id).HasColumnName("idea_id");

            // Relationships
            this.HasOptional(t => t.comment)
                .WithMany(t => t.rates)
                .HasForeignKey(d => d.comment_id);
            this.HasOptional(t => t.idea)
                .WithMany(t => t.rates)
                .HasForeignKey(d => d.idea_id);
            this.HasOptional(t => t.user)
                .WithMany(t => t.rates)
                .HasForeignKey(d => d.user_id);

        }
    }
}
