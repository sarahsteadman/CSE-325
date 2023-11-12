using System.ComponentModel.DataAnnotations;

namespace MyScriptureJournal.Models;

public class Scripture
{
  public int Id { get; set; }
  public string? Book { get; set; }
  public string? Chapter { get; set; } = string.Empty;
  public string? Verses { get; set; }

  public string? Text { get; set; }
  public string? Notes { get; set; }

  [DataType(DataType.Date)]
  public DateTime DateAdded { get; set; }

  public Scripture()
  {
    DateAdded = DateTime.Now;
  }
}
