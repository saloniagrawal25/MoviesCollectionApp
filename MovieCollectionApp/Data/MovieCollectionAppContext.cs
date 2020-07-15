using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MovieCollectionApp.Models;

namespace MovieCollectionApp.Data
{
    public class MovieCollectionAppContext : DbContext
    {
        public MovieCollectionAppContext (DbContextOptions<MovieCollectionAppContext> options)
            : base(options)
        {
        }

        public DbSet<MovieCollectionApp.Models.Movie> Movie { get; set; }
    }
}
