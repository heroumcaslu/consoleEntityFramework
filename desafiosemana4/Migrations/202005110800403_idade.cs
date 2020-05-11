namespace consoleproject.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class idade : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Usuarios", "idade", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Usuarios", "idade");
        }
    }
}
