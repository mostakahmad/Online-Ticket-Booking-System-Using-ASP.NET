namespace TicketBooking.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Branches",
                c => new
                    {
                        BranchID = c.Int(nullable: false, identity: true),
                        BranchName = c.String(),
                        BranchAdmin = c.String(),
                        AdminCell = c.String(),
                    })
                .PrimaryKey(t => t.BranchID);
            
            CreateTable(
                "dbo.Fairs",
                c => new
                    {
                        FairID = c.Int(nullable: false, identity: true),
                        FromBranch = c.String(),
                        ToBranch = c.String(),
                        AC = c.Int(nullable: false),
                        NonAC = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.FairID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Fairs");
            DropTable("dbo.Branches");
        }
    }
}
