namespace NBetting.EFMapping.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bets",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.Int(nullable: false),
                        GameId = c.Int(nullable: false),
                        IsDraw = c.Boolean(nullable: false),
                        WinnerId = c.Int(),
                        CreationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                        Score_Team1Score = c.Byte(),
                        Score_Team2Score = c.Byte(),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Games", t => t.GameId, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserId)
                .ForeignKey("dbo.Teams", t => t.WinnerId)
                .Index(t => t.UserId)
                .Index(t => t.GameId)
                .Index(t => t.WinnerId);
            
            CreateTable(
                "dbo.Games",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        Team1Id = c.Int(),
                        Team2Id = c.Int(),
                        TournamentId = c.Int(nullable: false),
                        Score_Team1Score = c.Byte(nullable: false),
                        Score_Team2Score = c.Byte(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Teams", t => t.Team1Id)
                .ForeignKey("dbo.Teams", t => t.Team2Id)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId, cascadeDelete: true)
                .Index(t => t.Team1Id)
                .Index(t => t.Team2Id)
                .Index(t => t.TournamentId);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        TournamentId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Tournaments", t => t.TournamentId, cascadeDelete: true)
                .Index(t => t.TournamentId);
            
            CreateTable(
                "dbo.Tournaments",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        Description = c.String(),
                        StartDate = c.DateTime(nullable: false),
                        FinishDate = c.DateTime(nullable: false),
                        UserId = c.Int(nullable: false),
                        CreationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Users", t => t.UserId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Login = c.String(),
                        CreationDate = c.DateTime(nullable: false),
                        IsDeleted = c.Boolean(nullable: false),
                        DeleteDate = c.DateTime(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bets", "WinnerId", "dbo.Teams");
            DropForeignKey("dbo.Bets", "UserId", "dbo.Users");
            DropForeignKey("dbo.Bets", "GameId", "dbo.Games");
            DropForeignKey("dbo.Games", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.Games", "Team2Id", "dbo.Teams");
            DropForeignKey("dbo.Games", "Team1Id", "dbo.Teams");
            DropForeignKey("dbo.Teams", "TournamentId", "dbo.Tournaments");
            DropForeignKey("dbo.Tournaments", "UserId", "dbo.Users");
            DropIndex("dbo.Tournaments", new[] { "UserId" });
            DropIndex("dbo.Teams", new[] { "TournamentId" });
            DropIndex("dbo.Games", new[] { "TournamentId" });
            DropIndex("dbo.Games", new[] { "Team2Id" });
            DropIndex("dbo.Games", new[] { "Team1Id" });
            DropIndex("dbo.Bets", new[] { "WinnerId" });
            DropIndex("dbo.Bets", new[] { "GameId" });
            DropIndex("dbo.Bets", new[] { "UserId" });
            DropTable("dbo.Users");
            DropTable("dbo.Tournaments");
            DropTable("dbo.Teams");
            DropTable("dbo.Games");
            DropTable("dbo.Bets");
        }
    }
}
