namespace KonquestKreations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Rishika : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.EnquiryFormEntries", "PhoneNumber", c => c.Long(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.EnquiryFormEntries", "PhoneNumber");
        }
    }
}
