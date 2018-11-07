namespace CitrusDB.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changestandartCRUDtostoredprocedurelogic : DbMigration
    {
        public override void Up()
        {
            CreateStoredProcedure(
                "dbo.InsertGroup",
                p => new
                    {
                        Name = p.String(),
                        Photo = p.Binary(),
                    },
                body:
                    @"INSERT [dbo].[Groups]([Name], [Photo])
                      VALUES (@Name, @Photo)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Groups]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Groups] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateGroup",
                p => new
                    {
                        Id = p.Int(),
                        Name = p.String(),
                        Photo = p.Binary(),
                    },
                body:
                    @"UPDATE [dbo].[Groups]
                      SET [Name] = @Name, [Photo] = @Photo
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteGroup",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Groups]
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.InsertStudent",
                p => new
                    {
                        firstName = p.String(),
                        lastName = p.String(),
                        middleName = p.String(),
                        dateOfBirth = p.String(),
                        height = p.Single(),
                        weight = p.Single(),
                        citizenship = p.String(),
                        knowledgeOfLanguage = p.String(),
                        firstPhoto = p.Binary(),
                        secondPhoto = p.Binary(),
                        groupId = p.Int(),
                    },
                body:
                    @"INSERT [dbo].[Students]([FirstName], [LastName], [MiddleName], [DateOfBirth], [Height], [Weight], [Сitizenship], [KnowledgeOfLanguage], [FirstPhoto], [SecondPhoto], [GroupId])
                      VALUES (@firstName, @lastName, @middleName, @dateOfBirth, @height, @weight, @citizenship, @knowledgeOfLanguage, @firstPhoto, @secondPhoto, @groupId)
                      
                      DECLARE @Id int
                      SELECT @Id = [Id]
                      FROM [dbo].[Students]
                      WHERE @@ROWCOUNT > 0 AND [Id] = scope_identity()
                      
                      SELECT t0.[Id]
                      FROM [dbo].[Students] AS t0
                      WHERE @@ROWCOUNT > 0 AND t0.[Id] = @Id"
            );
            
            CreateStoredProcedure(
                "dbo.UpdateStudent",
                p => new
                    {
                        Id = p.Int(),
                        firstName = p.String(),
                        lastName = p.String(),
                        middleName = p.String(),
                        dateOfBirth = p.String(),
                        height = p.Single(),
                        weight = p.Single(),
                        citizenship = p.String(),
                        knowledgeOfLanguage = p.String(),
                        firstPhoto = p.Binary(),
                        secondPhoto = p.Binary(),
                        groupId = p.Int(),
                    },
                body:
                    @"UPDATE [dbo].[Students]
                      SET [FirstName] = @firstName, [LastName] = @lastName, [MiddleName] = @middleName, [DateOfBirth] = @dateOfBirth, [Height] = @height, [Weight] = @weight, [Сitizenship] = @citizenship, [KnowledgeOfLanguage] = @knowledgeOfLanguage, [FirstPhoto] = @firstPhoto, [SecondPhoto] = @secondPhoto, [GroupId] = @groupId
                      WHERE ([Id] = @Id)"
            );
            
            CreateStoredProcedure(
                "dbo.DeleteStudent",
                p => new
                    {
                        Id = p.Int(),
                    },
                body:
                    @"DELETE [dbo].[Students]
                      WHERE ([Id] = @Id)"
            );
            
        }
        
        public override void Down()
        {
            DropStoredProcedure("dbo.DeleteStudent");
            DropStoredProcedure("dbo.UpdateStudent");
            DropStoredProcedure("dbo.InsertStudent");
            DropStoredProcedure("dbo.DeleteGroup");
            DropStoredProcedure("dbo.UpdateGroup");
            DropStoredProcedure("dbo.InsertGroup");
        }
    }
}
