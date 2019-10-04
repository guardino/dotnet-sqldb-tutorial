namespace DotNetAppSqlDb.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddDoneProperty : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Todoes", "Done", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Todoes", "Done");
        }
    }
}
