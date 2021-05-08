using Microsoft.EntityFrameworkCore;
using Volo.Abp;

namespace Anto.AuthChange.EntityFrameworkCore
{
    public static class AuthChangeDbContextModelCreatingExtensions
    {
        public static void ConfigureAuthChange(this ModelBuilder builder)
        {
            Check.NotNull(builder, nameof(builder));

            /* Configure your own tables/entities inside here */

            //builder.Entity<YourEntity>(b =>
            //{
            //    b.ToTable(AuthChangeConsts.DbTablePrefix + "YourEntities", AuthChangeConsts.DbSchema);
            //    b.ConfigureByConvention(); //auto configure for the base class props
            //    //...
            //});
        }
    }
}