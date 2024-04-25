namespace User_Management__with_Identity.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            // Map 'IdentityUser' entity to 'users' table
            builder.Entity<ApplicationUser>().ToTable("users", "security");

            // Map 'IdentityRole' entity to 'Roles' table
            builder.Entity<IdentityRole>().ToTable("Roles", "security");

            // Map 'IdentityUserRole' entity to 'userRoles' table
            builder.Entity<IdentityUserRole<String>>().ToTable("userRoles", "security");

            // Map 'IdentityUserClaim' entity to 'userClaims' table
            builder.Entity<IdentityUserClaim<String>>().ToTable("userClaims", "security");

            // Map 'IdentityUserLogin' entity to 'userLogins' table
            builder.Entity<IdentityUserLogin<String>>().ToTable("userLogins", "security");

            // Map 'IdentityRoleClaim' entity to 'RoleClaims' table
            builder.Entity<IdentityRoleClaim<String>>().ToTable("RoleClaims", "security");

            // Map 'IdentityUserToken' entity to 'userTokens' table
            builder.Entity<IdentityUserToken<String>>().ToTable("userTokens", "security");
        }

    }
}

