using Setlist.Web.Models;

namespace Setlist.Web.Data;

public static class DataSeeder {
    public static async Task SeedSongsAsync(SetlistDbContext context) {
        if (context.Songs.Any()) {
            return;
        }

        List<string> titles = ["Summertime", "Yesterdays", "Blue Monk"];
        foreach (string title in titles) {
            await context.Songs.AddAsync(new Song() {
                Title = title
            });
        }

        await context.SaveChangesAsync();
    }
}
