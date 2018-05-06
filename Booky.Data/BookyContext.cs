using Booky.Data.Mappings;
using System.Configuration;
using Booky.Models;
using System.Data.Entity;
namespace Booky.Data
{
    public class BookyContext: DbContext
    {
      
        public BookyContext() : base(ConfigurationManager.ConnectionStrings["Debug"].ConnectionString)
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new BookMap());
            base.OnModelCreating(modelBuilder);
        }

        public DbSet<Book> Books { get; set; }
    }
}
