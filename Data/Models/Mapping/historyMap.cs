using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class historyMap : EntityTypeConfiguration<history>
    {
        public historyMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.content)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("history", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.content).HasColumnName("content");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.user_id).HasColumnName("user_id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.histories)
                .HasForeignKey(d => d.user_id);

        }
    }
}
