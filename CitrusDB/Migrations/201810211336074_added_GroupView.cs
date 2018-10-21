namespace CitrusDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_GroupView : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupViews",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Photo = c.Binary(),
                        Name = c.String(),
                        Students = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.GroupViews");
        }
    }
}
