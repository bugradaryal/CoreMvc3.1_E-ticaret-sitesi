using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace eticaretsitesi.Models
{
    public class ProductContext : IdentityDbContext<User>
    {
        public DbSet<OfficeProduct> Products { get; set; }
        public DbSet<ProductType> Types { get; set; }
        public DbSet<Image> Images { get; set; }
        public ProductContext(DbContextOptions<ProductContext> options)
            : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<OfficeProduct>().HasOne(op => op.Type)
                        .WithMany(t => t.Products)
                        .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.ApplyConfiguration(new SeedProducts());
            modelBuilder.ApplyConfiguration(new SeedProductTypes());
            modelBuilder.ApplyConfiguration(new SeedImages());
        }
        public static async Task CreateAdminUser(IServiceProvider serviceProvider)
        {
            var userManager =
                serviceProvider.GetRequiredService<UserManager<User>>();
            var roleManager =
                serviceProvider.GetRequiredService<RoleManager<IdentityRole>>();

            //Admin girişi yaptığımız hesap - uygulama tarafından bu kısımda değiştiriliyor!!!
            var username = "Oyuasx";
            var password = "31082000bugra12";
            var roleName = "Admin";

            if (await roleManager.FindByNameAsync(roleName) == null)
            {
                await roleManager.CreateAsync(new IdentityRole(roleName));
            }

            if (await userManager.FindByNameAsync(username) == null)
            {
                var user = new User {UserName = username};
                var result = await userManager.CreateAsync(user, password);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(user, roleName);
                }
            }
        }
    }
}