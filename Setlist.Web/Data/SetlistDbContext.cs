using Microsoft.EntityFrameworkCore;

using Setlist.Web.Models;

namespace Setlist.Web.Data;

public class SetlistDbContext : DbContext {
    public SetlistDbContext(
        DbContextOptions<SetlistDbContext> options
    ) : base(options) {}

    public DbSet<Song> Songs { get; set; } = null!;
    public DbSet<Set> Sets { get; set; } = null!;
    public DbSet<Gig> Gigs { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Song>().ToTable("Song");
        modelBuilder.Entity<Set>().ToTable("Set");
        modelBuilder.Entity<Gig>().ToTable("Gig");
    }
}
