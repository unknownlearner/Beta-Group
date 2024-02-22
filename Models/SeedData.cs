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
                    Product= "ABINGER SMOKE SOFA",
                    Description = "ss",
                    Material = "Fabric",
                    Rating = "R",
                    Price = 7.99M
                },
                new Movie
                {
                    Product = "MIRAVEL SLATE SOFA",
                    Description = "assa",
                    Material = "Fabric",
                    Rating = "R",
                    Price = 8.99M
                },
                new Movie
                {
                    Product = "GENOA STEEL SOFA",
                    Description = "aaa",
                    Material = "Leather",
                    Rating = "Good",
                    Price = 9.99M
                },
                new Movie
                {
                    Product = "ALTARI ALLOY SOFA",
                    Description = "If style is the question, then the Altari sofa is the answer.\r\n",
                    Material = "Fabric",
                    Rating = "R",
                    Price = 3.99M
                }
            );
            context.SaveChanges();
        }
    }
}