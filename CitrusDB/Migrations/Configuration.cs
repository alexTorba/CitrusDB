using System;
using System.Data.Entity;
using System.Data.Entity.Migrations;
using System.Linq;

using CitrusDB.Model.DataBaseLogic;

namespace CitrusDB.Migrations
{

  internal sealed class Configuration : DbMigrationsConfiguration<CitrusDbContext>
  {
    public Configuration()
    {
      AutomaticMigrationsEnabled = false;
      ContextKey = "CitrusDB.StudentDB";
    }

    protected override void Seed(CitrusDbContext context)
    {
      //  This method will be called after migrating to the latest version.

      //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
      //  to avoid creating duplicate seed data.
    }
  }
}
