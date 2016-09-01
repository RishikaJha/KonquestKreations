namespace KonquestKreations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.EnquiryFormEntries",
                c => new
                    {
                        EnquiryID = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false),
                        Message = c.String(nullable: false),
                        Email = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.EnquiryID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.EnquiryFormEntries");
        }
    }
}
