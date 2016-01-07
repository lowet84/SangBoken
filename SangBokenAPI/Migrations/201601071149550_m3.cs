namespace SangBokenAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m3 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.SongBooks", "Name", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.SongBooks", "Name");
        }
    }
}
