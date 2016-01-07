namespace SangBokenAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m1 : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SongInSongBooks",
                c => new
                    {
                        SongKey = c.Int(nullable: false),
                        SongBookKey = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.SongKey, t.SongBookKey })
                .ForeignKey("dbo.Songs", t => t.SongKey, cascadeDelete: true)
                .ForeignKey("dbo.SongBooks", t => t.SongBookKey, cascadeDelete: true)
                .Index(t => t.SongKey)
                .Index(t => t.SongBookKey);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.SongInSongBooks", "SongBookKey", "dbo.SongBooks");
            DropForeignKey("dbo.SongInSongBooks", "SongKey", "dbo.Songs");
            DropIndex("dbo.SongInSongBooks", new[] { "SongBookKey" });
            DropIndex("dbo.SongInSongBooks", new[] { "SongKey" });
            DropTable("dbo.SongInSongBooks");
        }
    }
}
