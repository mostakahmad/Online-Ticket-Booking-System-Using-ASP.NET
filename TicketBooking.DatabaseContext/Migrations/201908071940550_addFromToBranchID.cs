namespace TicketBooking.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addFromToBranchID : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Fairs", "FromBranchID", c => c.Int(nullable: false));
            AddColumn("dbo.Fairs", "ToBranchID", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Fairs", "ToBranchID");
            DropColumn("dbo.Fairs", "FromBranchID");
        }
    }
}
