using System.Data.Entity.Migrations;

namespace CitrusDB.Migrations
{
  public partial class InitialCreate : DbMigration
  {
    public override void Up()
    {
      CreateTable(
          "dbo.Groups",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            Name = c.String(),
          })
        .PrimaryKey(t => t.Id);

      CreateTable(
          "dbo.Students",
          c => new
          {
            Id = c.Int(nullable: false, identity: true),
            FirstName = c.String(),
            LastName = c.String(),
            MiddleName = c.String(),
            DateOfBirth = c.String(),
            Height = c.Single(nullable: false),
            Weight = c.Single(nullable: false),
            Сitizenship = c.String(),
            KnowledgeOfLanguage = c.String(),
            FirstPhoto = c.Binary(),
            SecondPhoto = c.Binary(),
            GroupId = c.Int(),
          })
        .PrimaryKey(t => t.Id)
        .ForeignKey("dbo.Groups", t => t.GroupId)
        .Index(t => t.GroupId);
    }

    public override void Down()
    {
      DropForeignKey("dbo.Students", "GroupId", "dbo.Groups");
      DropIndex("dbo.Students", new[] {"GroupId"});
      DropTable("dbo.Students");
      DropTable("dbo.Groups");
    }
  }
}