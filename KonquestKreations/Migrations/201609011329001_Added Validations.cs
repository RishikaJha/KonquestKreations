namespace KonquestKreations.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedValidations : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.EnquiryFormEntries", "Name", c => c.String(nullable: false, maxLength: 40));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.EnquiryFormEntries", "Name", c => c.String(nullable: false));
        }
    }
}
