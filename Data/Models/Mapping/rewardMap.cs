using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class rewardMap : EntityTypeConfiguration<reward>
    {
        public rewardMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.itemName)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("reward", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.itemName).HasColumnName("itemName");
            this.Property(t => t.points).HasColumnName("points");
        }
    }
}
