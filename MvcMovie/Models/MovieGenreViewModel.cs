using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class MovieGenreViewModel
{
  public List<Movie>? Movies { get; set; }
  public SelectList? Genres { get; set; }
  public string? MovieGenre { get; set; }
  public string? SearchString { get; set; }
  public DateTime? StartDate { get; set; }

  public DateTime? EndDate { get; set; }
}
