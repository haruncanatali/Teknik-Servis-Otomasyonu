namespace TeknikServis.DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<TeknikServis.DataAccess.Concrete.EntityFramework.TeknikServisDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            AutomaticMigrationDataLossAllowed = true;
        }

        protected override void Seed(TeknikServis.DataAccess.Concrete.EntityFramework.TeknikServisDbContext context)
        {
        }
    }
}
