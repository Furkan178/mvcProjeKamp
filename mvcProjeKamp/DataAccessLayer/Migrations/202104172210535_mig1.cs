namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class mig1 : DbMigration
    {
        public override void Up()  //değişiklikleri kaydedersem burası çalışacak
        {
            AddColumn("dbo.Contents", "WriterID", c => c.Int());
            CreateIndex("dbo.Contents", "WriterID");
            AddForeignKey("dbo.Contents", "WriterID", "dbo.Writers", "WriterID");
        }
        
        public override void Down() //değişiklikleri kaydetmezsem burası çalışacak
        {
            DropForeignKey("dbo.Contents", "WriterID", "dbo.Writers");
            DropIndex("dbo.Contents", new[] { "WriterID" });
            DropColumn("dbo.Contents", "WriterID");
        }
    }
}
