using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.RazorPages;
using MyApp.Data;
using MyApp.Models;

namespace MyApp.Pages.Movies
{
    public class EditModel : PageModel
    {
        private readonly AppDbContext _db;

        public EditModel(AppDbContext db)
        {
            _db = db;
        }

        [BindProperty]
        public Movie Movie { get; set; }

        public void OnGet(int id)
        {
            Movie = _db.Movies.Find(id);

        }

        public IActionResult OnPost()
        {
            var movie = _db.Movies.Find(Movie.Id);
            movie.Name = Movie.Name;
            movie.Year = Movie.Year;
            _db.SaveChanges();

            return RedirectToPage("Index");
        }
    }
}