using Microsoft.EntityFrameworkCore;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMoive.Models;

public class SeedData{
    public static void Initialize(IServiceProvider serviceProvider) {
        using (var context = new MvcMovieContext(serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>())) {
            if (context.Movie.Any()){
                return;
            }
            
            context.Movie.AddRange(
                new Movie {
                    Title = "When Harry Met Sally", 
                    ReleaseDate = DateTime.Parse("1989-2-12"), 
                    Genre = "Romantic Comedy", 
                    price = 7.99M
                }, new Movie {
                    Title = "GhostBusters ", 
                    ReleaseDate = DateTime.Parse("1984-3-13"), 
                    Genre = "Comedy", 
                    price = 8.99M
                }, new Movie {
                    Title = "GhostBusters 2", 
                    ReleaseDate = DateTime.Parse("1986-2-23"), 
                    Genre = "Comedy", 
                    price = 9.99M
                }, new Movie {
                    Title = "Rio Bravo", 
                    ReleaseDate = DateTime.Parse("1959-4-15"), 
                    Genre = "Western", 
                    price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}