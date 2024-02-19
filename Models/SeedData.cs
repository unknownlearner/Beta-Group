using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models;

public static class SeedData
{
    public static void Initialize(IServiceProvider serviceProvider)
    {
        using (var context = new MvcMovieContext(
            serviceProvider.GetRequiredService<
                DbContextOptions<MvcMovieContext>>()))
        {
            // Look for any movies.
            if (context.Movie.Any())
            {
                return;   // DB has been seeded
            }
            context.Movie.AddRange(
                new Movie
                {
                    Product= "When Harry Met Sally",
                    Description = "When Harry Met Sally",
                    Material = "Romantic Comedy",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Product = "Ghostbusters ",
                    Description = "When Harry Met Sally",
                    Material = "Romantic Comedy",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Product = "Ghostbusters 2",
                    Description = "When Harry Met Sally",
                    Material = "Romantic Comedy",
                    Rating = "R",
                    Price = 9.99M
                },
                new Movie
                {
                    Product = "Rio Bravo",
                    Description = "When Harry Met Sally",
                    Material = "Romantic Comedy",
                    Rating = "R",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}