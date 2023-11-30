using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;

public class MovieReleaseDateViewModel
{
  public List<Movie>? Movies { get; set; }
  public SelectList? Dates { get; set; }

  public string? SearchString { get; set; }
}
