namespace MVC5Course.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Movies",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Title = c.String(),
                        ReleaseDate = c.DateTime(nullable: false),
                        Genre = c.String(),
                        Price = c.Decimal(nullable: false, precision: 18, scale: 2),
                    })
                .PrimaryKey(t => t.ID);
            
            
            //CreateTable(
            //    "dbo.Staffs",
            //    c => new
            //        {
            //            Id = c.Int(nullable: false, identity: true),
            //            Name = c.String(),
            //            Position = c.String(),
            //            Salary = c.Decimal(nullable: false, precision: 18, scale: 2),
            //        })
            //    .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Staffs");
            DropTable("dbo.Movies");
        }
    }
}
