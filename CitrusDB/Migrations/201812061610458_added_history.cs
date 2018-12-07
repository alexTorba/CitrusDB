namespace CitrusDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class added_history : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GroupsHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfOperation = c.String(),
                        Name = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.StudentsHistories",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TypeOfOperation = c.String(),
                        FirstName = c.String(),
                        LastName = c.String(),
                        Time = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.StudentsHistories");
            DropTable("dbo.GroupsHistories");
        }
    }
}
