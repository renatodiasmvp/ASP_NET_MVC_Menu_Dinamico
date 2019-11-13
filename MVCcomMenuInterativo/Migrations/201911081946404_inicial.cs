namespace MVCcomMenuInterativo.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class inicial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ItemDeMenus",
                c => new
                    {
                        ItemDeMenuId = c.Int(nullable: false, identity: true),
                        ItemPaiId = c.Int(nullable: false),
                        NomeDoItem = c.String(),
                        NomeDoController = c.String(),
                        NomeDaAction = c.String(),
                    })
                .PrimaryKey(t => t.ItemDeMenuId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.ItemDeMenus");
        }
    }
}
