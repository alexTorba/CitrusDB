namespace CitrusDB.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class changed_views : DbMigration
  {
    public override void Up()
    {
      DropTable("dbo.GroupViews");
      DropTable("dbo.StudentViews");
    }

    public override void Down()
    {
      CreateTable(
          "dbo.StudentViews",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            FirstName = c.String(),
            LastName = c.String(),
            MiddleName = c.String(),
            Group = c.String(),
          })
          .PrimaryKey(t => t.Id);

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
  }
}
