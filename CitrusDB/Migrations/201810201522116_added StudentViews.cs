namespace CitrusDB.Migrations
{
  using System;
  using System.Data.Entity.Migrations;

  public partial class addedStudentViews : DbMigration
  {
    public override void Up()
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

      AddColumn("dbo.Groups", "Photo", c => c.Binary());
    }

    public override void Down()
    {
      DropColumn("dbo.Groups", "Photo");
      DropTable("dbo.StudentViews");
    }
  }
}
