using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using MvcMovie.Data;
using System;
using System.Linq;

namespace MvcMovie.Models
{
  public static class SeedData
  {
    public static void Initialize(IServiceProvider serviceProvider)
    {
      using (var context = new MvcMovieContext(
          serviceProvider.GetRequiredService<DbContextOptions<MvcMovieContext>>()))
      {
        // Look for any movies.
        if (context.Movie.Any())
        {
          return;   // DB has been seeded
        }

        context.Movie.AddRange(
          new Movie
          {
            Title = "The Other Side of Heaven",
            ReleaseDate = DateTime.Parse("2001-04-12"),
            Genre = "Drama",
            Price = 9.99M,
            Rating = "PG",
            ImagePath = "Images/othersideofheaven.jpg"
          },
          new Movie
          {
            Title = "17 Miracles",
            ReleaseDate = DateTime.Parse("2011-06-03"),
            Genre = "Adventure",
            Price = 10.99M,
            Rating = "PG",
            ImagePath = "Images/17miracles.jpg"

          },
          new Movie
          {
            Title = "The Testaments: Of One Fold and One Shepherd",
            ReleaseDate = DateTime.Parse("2000-03-24"),
            Genre = "Drama",
            Price = 8.99M,
            Rating = "PG",
            ImagePath = "Images/thetestaments.jpg"
          },
          new Movie
          {
            Title = "The Cokeville Miracle",
            ReleaseDate = DateTime.Parse("2015-06-05"),
            Genre = "Drama",
            Price = 7.99M,
            Rating = "PG-13",
            ImagePath = "Images/thecokevillemiracle.jpg"
          }
        );
        context.SaveChanges();
      }
    }
  }
}
