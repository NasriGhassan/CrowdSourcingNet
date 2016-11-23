using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using Domain.Entities;

namespace Data.Models.Mapping
{
    public class chatMap : EntityTypeConfiguration<chat>
    {
        public chatMap()
        {
            // Primary Key
            this.HasKey(t => t.id);

            // Properties
            this.Property(t => t.message)
                .HasMaxLength(255);

            // Table & Column Mappings
            this.ToTable("chat", "crowdsourcing");
            this.Property(t => t.id).HasColumnName("id");
            this.Property(t => t.date).HasColumnName("date");
            this.Property(t => t.message).HasColumnName("message");
            this.Property(t => t.SourceUser_Id).HasColumnName("SourceUser_Id");
            this.Property(t => t.TargetUser_Id).HasColumnName("TargetUser_Id");

            // Relationships
            this.HasOptional(t => t.user)
                .WithMany(t => t.chats)
                .HasForeignKey(d => d.TargetUser_Id);
            this.HasOptional(t => t.user1)
                .WithMany(t => t.chats1)
                .HasForeignKey(d => d.SourceUser_Id);

        }
    }
}
