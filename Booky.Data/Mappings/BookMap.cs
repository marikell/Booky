using Booky.Models;
using System.Data.Entity.ModelConfiguration;

namespace Booky.Data.Mappings
{
    public class BookMap : EntityTypeConfiguration<Book>
    {
        public BookMap()
        {
            HasKey(k => k.IdBook);
            Property(o => o.IdBook).HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);
            Property(o => o.Title).HasMaxLength(100);
            Property(o => o.Description).HasMaxLength(256);
            Property(o => o.BookPublisher).HasMaxLength(100);
            Property(o => o.Author).HasMaxLength(100);
            
        }
    }
}
