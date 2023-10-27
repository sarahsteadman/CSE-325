using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using MyScriptureJournal.Data;
using MyScriptureJournal.Models;

namespace MyScriptureJournal.Pages.Scriptures
{
  public class IndexModel : PageModel
  {
    private readonly MyScriptureJournal.Data.MyScriptureJournalContext _context;

    public IndexModel(MyScriptureJournal.Data.MyScriptureJournalContext context)
    {
      _context = context;
    }

    public IList<Scripture> Scripture { get; set; } = default!;


    //Book
    [BindProperty(SupportsGet = true)]
    public string? SearchString { get; set; }

    public SelectList? Books { get; set; }

    [BindProperty(SupportsGet = true)]
    public string? ScriptureBook { get; set; }

    //Dates
    [BindProperty(SupportsGet = true)]
    public DateTime? StartDate { get; set; }

    [BindProperty(SupportsGet = true)]
    public DateTime? EndDate { get; set; }

    public SelectList? Dates { get; set; }


    public async Task OnGetAsync()
    {

      IQueryable<string> genreQuery = from s in _context.Scripture
                                      orderby s.Book
                                      select s.Book;


      IQueryable<DateTime> dateQuery = from s in _context.Scripture
                                       orderby s.DateAdded
                                       select s.DateAdded;

      var scriptures = from s in _context.Scripture
                       select s;

      if (!string.IsNullOrEmpty(SearchString))
      {
        scriptures = scriptures.Where(n => n.Notes.Contains(SearchString));
      }

      if (!string.IsNullOrEmpty(ScriptureBook))
      {
        scriptures = scriptures.Where(x => x.Book == ScriptureBook);
      }
      if (StartDate != null && EndDate != null)
      {
        scriptures = scriptures.Where(s => s.DateAdded >= StartDate && s.DateAdded <= EndDate);
      }

      Books = new SelectList(await genreQuery.Distinct().ToListAsync());
      Dates = new SelectList(await dateQuery.Distinct().ToListAsync());

      Scripture = await scriptures.ToListAsync();
    }
  }
}
