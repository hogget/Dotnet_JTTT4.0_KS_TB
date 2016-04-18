namespace WindowsFormsApplication1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.MyTasks",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AdresStrony = c.String(),
                        Klucz = c.String(),
                        Email = c.String(),
                        Name = c.String(),
                        MyTask_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.MyTasks", t => t.MyTask_Id)
                .Index(t => t.MyTask_Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.MyTasks", "MyTask_Id", "dbo.MyTasks");
            DropIndex("dbo.MyTasks", new[] { "MyTask_Id" });
            DropTable("dbo.MyTasks");
        }
    }
}
