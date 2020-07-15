using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using MovieCollectionApp.Data;
using MovieCollectionApp.Models;

namespace MovieCollectionApp.Pages.Movies
{
    public class IndexModel : PageModel
    {
        private readonly MovieCollectionApp.Data.MovieCollectionAppContext _context;

        public IndexModel(MovieCollectionApp.Data.MovieCollectionAppContext context)
        {
            _context = context;
        }

        public IList<Movie> Movie { get;set; }

        public async Task OnGetAsync()
        {
            Movie = await _context.Movie.ToListAsync();
        }
    }
}
