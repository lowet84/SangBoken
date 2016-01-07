namespace SangBoken.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.SongBooks",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                    })
                .PrimaryKey(t => t.Key);
            
            CreateTable(
                "dbo.Songs",
                c => new
                    {
                        Key = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Key);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Songs");
            DropTable("dbo.SongBooks");
        }
    }
}
