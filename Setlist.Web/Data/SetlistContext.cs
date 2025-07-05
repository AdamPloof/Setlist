using Microsoft.EntityFrameworkCore;

using Setlist.Web.Models;

namespace Setlist.Web.Data;

public class SetlistContext : DbContext {
    public SetlistContext(
        DbContextOptions<SetlistContext> options
    ) : base(options) {}

    public DbSet<Song> Songs { get; set; } = null!;
    public DbSet<TuneList> TuneList { get; set; } = null!;
    public DbSet<TuneListSong> TuneListSongs { get; set; } = null!;
    public DbSet<Tag> Tags { get; set; } = null!;

    protected override void OnModelCreating(ModelBuilder modelBuilder) {
        modelBuilder.Entity<Song>().ToTable("Song");
        modelBuilder.Entity<TuneList>().ToTable("TuneList");
        modelBuilder.Entity<TuneListSong>().ToTable("TuneListSong");
        modelBuilder.Entity<Tag>().ToTable("Tag");
    }
}
