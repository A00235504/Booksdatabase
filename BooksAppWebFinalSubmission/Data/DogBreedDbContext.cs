using System;
using BooksAppWebFinalSubmission.Models;
using Microsoft.EntityFrameworkCore;

namespace BooksAppWebFinalSubmission.Data
{
    public class DogBreedDbContext : DbContext
    {

        public DogBreedDbContext(DbContextOptions<DogBreedDbContext> options) : base(options)
        {
        }

        public DbSet<Books> Books { get; set; }
    }
}