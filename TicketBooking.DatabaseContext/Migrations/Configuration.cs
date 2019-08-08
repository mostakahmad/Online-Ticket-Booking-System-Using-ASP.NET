namespace TicketBooking.DatabaseContext.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TicketBooking.DatabaseContext.DatabaseContext.TicketBookingDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "TicketBooking.DatabaseContext.DatabaseContext.TicketBookingDBContext";
        }

        protected override void Seed(TicketBooking.DatabaseContext.DatabaseContext.TicketBookingDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
