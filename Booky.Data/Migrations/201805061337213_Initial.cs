namespace Booky.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Books",
                c => new
                    {
                        IdBook = c.Int(nullable: false, identity: true),
                        Title = c.String(maxLength: 100),
                        Price = c.Single(nullable: false),
                        Description = c.String(maxLength: 256),
                        BookPublisher = c.String(maxLength: 100),
                        Author = c.String(maxLength: 100),
                        StockQty = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.IdBook);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Books");
        }
    }
}
