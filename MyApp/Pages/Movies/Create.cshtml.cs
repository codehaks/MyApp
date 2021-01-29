using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Pages.Movies
{
    public class CreateModel : PageModel
    {
        [BindProperty]
        public Movie Movie { get; set; }

        private readonly AppDbContext _db;

        public CreateModel(AppDbContext db)
        {
            _db = db;
        }

        public IActionResult OnPost()
        {
            _db.Movies.Add(Movie);
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}