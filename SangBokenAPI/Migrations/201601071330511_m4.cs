namespace SangBokenAPI.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class m4 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Songs", "Text", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Songs", "Text");
        }
    }
}
